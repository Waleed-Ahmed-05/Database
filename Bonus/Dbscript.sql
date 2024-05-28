/* 1. Write a query that print all employees and their job IDs. Display the last name concatenated with the job ID (separated by a comma and space) and name of the column Employee and Title. */

SELECT last_name + ', ' + job_title  AS 'Employee and Title' FROM employees,jobs WHERE employees.job_id = jobs.job_id;

/* 2. Due to budget issues, the HR department needs a report that displays the last name and salary of employees who earn more than $12,000. */

SELECT last_name AS LAST_NAME,CAST(salary AS INT) AS SALARY FROM employees WHERE salary > 12000;

/* 3. Display the last name and salary for any employee whose salary is not in the range of $5,000 to $12,000. */

SELECT last_name AS LAST_NAME,CAST(salary AS INT) AS SALARY FROM employees WHERE salary < 5000 OR salary > 12000;

/* 4. The HR department needs a report that displays the last name and hire date for all employees who were hired in 1994. */

SELECT last_name AS LAST_NAME,UPPER(FORMAT(hire_date,'dd-MMM-yy')) AS HIRE_DATE FROM employees AS E1 WHERE (SELECT YEAR(hire_date) FROM employees AS E2 WHERE E1.employee_id = E2.employee_id) = '1994';

/* 5. Create a report to display the last name, salary, and commission of all employees who earn commissions. Sort data in descending order of salary and commissions. */

SELECT last_name AS LAST_NAME,CAST(salary AS INT) AS SALARY,CAST((((salary - min_salary) / min_salary) * 100) AS DECIMAL(10,1)) AS COMISSION_PCT FROM employees,jobs WHERE employees.job_id = jobs.job_id ORDER BY 2,3 DESC;

/* 6. Display all employees last names in which the third letter of the name is a. */

SELECT last_name AS LAST_NAME FROM employees WHERE last_name LIKE '__a%';

/* 7. Display the last name of all employees who have both an 'a' and an 'e' in their last name. */

SELECT last_name AS LAST_NAME FROM employees AS E1 WHERE last_name LIKE '%a%' AND last_name LIKE '%e%';

/* 8. Display the last name, job, and salary for all employees whose job is sales representative or stock clerk and whose salary is not equal to $2,500, $3,500, or $7,000. */

SELECT last_name AS LAST_NAME,job_title AS JOB_ID,CAST(salary AS INT) AS SALARY FROM employees,jobs WHERE employees.job_id = jobs.job_id AND (job_title = 'Sales Representative' OR job_title = 'Stock Clerk') AND (salary <> 7000 AND salary <> 3500 AND salary <> 2500);

/* 9. The HR department needs a report to display the employee number, last name, salary, and salary increased by 15.5% (expressed as a whole number) for each employee. */

SELECT employee_id AS EMPLOYEE_ID,last_name AS LAST_NAME,CAST(salary AS INT) AS SALARY,CAST((salary + salary * 0.155) AS INT) AS 'New Salary' FROM employees;

/* 10. Write a query that displays the last name (with the first letter uppercase and all other letters lowercase) and the length of the last name for all employees whose name starts with the letters J, A,or M.Give each column an appropriate label. Sort the results by the employee's last names. */

SELECT last_name AS Name,LEN(last_name) AS Length FROM employees WHERE last_name LIKE 'A%' OR last_name LIKE 'J%' OR last_name LIKE 'M%' ORDER BY last_name;

/* 11. The HR department wants to find the length of employment for each employee. For each employee, display the last name and calculate the number of months between today and the date on which the employee was hired. Label the column MONTHS_WORKED. Order your results by the number of months employed. Round the number of months up to the closest whole number. */

SELECT last_name AS LAST_NAME,(MONTH(GETDATE()) - MONTH(hire_date)) + (12 * (YEAR(GETDATE()) - YEAR(hire_date))) AS MONTHS_WORKED FROM employees ORDER BY 2;

/* 12. Create a report that produces the following for each employee: <employee last_name> earns <salary> monthly but wants <3 times salary>. Label the column Dream Salaries. */

SELECT last_name + ' earns $' + CAST(CAST(salary AS INT) AS NVARCHAR) + ' monthly but wants $' + CAST(CAST(3 * salary AS INT) AS NVARCHAR) + '.' AS [Dream Salaries] FROM employees;

/* 13. Create a query to display the last name and salary for all employees. Format the salary to be 15 characters long, left-padded with the $ symbol. Label the column SALARY. */

SELECT REPLICATE('$',15 - LEN(CAST(salary AS INT))) + CAST(CAST(salary AS INT) AS NVARCHAR) AS SALARY FROM employees;

/* 14. Display each employee’s last name, hire date, and salary review date, which is the first Monday after six months of service. Label the column REVIEW. Format the dates to appear similar to “Monday, the Thirty-First of July, 2000.” */

SELECT last_name AS LAST_NAME,UPPER(FORMAT(hire_date,'dd-MMM-yy')) AS HIRE_DATE,DATENAME(WEEKDAY,hire_date) + ',the ' + FORMAT(hire_date,'dd')  + CASE WHEN DAY(hire_date) IN (1, 21, 31) THEN 'st' WHEN DAY(hire_date) IN (2, 22) THEN 'nd'WHEN DAY(hire_date) IN (3, 23) THEN 'rd' ELSE 'th' END + ' of ' + DATENAME(MONTH, DATEADD(MONTH,6,hire_date)) + ', ' + FORMAT(DATEADD(MONTH,6,hire_date), 'yyyy') AS REVIEW FROM employees;

/* 15. Display the last name, hire date, and day of the week on which the employee started. Label the column DAY. Order the results by the day of the week, starting with Monday. */

SELECT last_name AS LAST_NAME,UPPER(FORMAT(hire_date,'dd-MMM-yy')) AS HIRE_DATE,DATENAME(WEEKDAY,hire_date) AS DAY FROM employees ORDER BY 3;

/* 16. Create a query that displays the employees’ last names and commission amounts. If an employee does not earn commission, show “No Commission.” Label the column COMM. */

SELECT last_name AS LAST_NAME,CAST(salary AS INT) AS SALARY,CAST((salary - min_salary) AS INT) AS 'COMM' FROM employees,jobs WHERE employees.job_id = jobs.job_id;

/* 17. Create a query that displays the first eight characters of the employees’ last names and indicates the amounts of their salaries with asterisks. Each asterisk signifies a thousand dollars. Sort the data in descending order of salary. Label it EMPLOYEES_AND_THEIR_SALARIES. */

SELECT LEFT(last_name,8) + ' ' + REPLICATE('*',CAST(salary/1000 AS INT)) AS 'EMPLOYEES_AND THEIR_SALARIES' FROM employees;

/* 18. Using the DECODE() function, write a query that displays the grade of all employees based on the value of the column JOB_ID, using the following data in Job Grades: For AD_PRES Print A,For ST_MAN Print B,For IT_PROG Print C,For SA_REP Print D,For ST_CLERK Print E,For None of the above Print 0.
                                                 DECODE() Function is an ORACLE SQL function that's why it doesn't work in MS SQL. */

SELECT job_title AS JOB_ID,CASE job_title WHEN 'Administration Vice President' THEN 'A' WHEN 'Stock Manager' THEN 'B' WHEN 'Programmer' THEN 'C' WHEN 'Sales Representative' THEN 'D' WHEN 'Stock Clerk' THEN 'E' ELSE '0' END AS 'GRA' FROM jobs,employees WHERE employees.job_id = jobs.job_id;

/* 19. Rewrite above with case statement. */

SELECT job_title AS JOB_ID,CASE job_title WHEN 'Administration Vice President' THEN 'A' WHEN 'Stock Manager' THEN 'B' WHEN 'Programmer' THEN 'C' WHEN 'Sales Representative' THEN 'D' WHEN 'Stock Clerk' THEN 'E' ELSE '0' END AS 'GRA' FROM jobs,employees WHERE employees.job_id = jobs.job_id;

/* 20. Find the highest, lowest sum and average salary of all employees. Label the columns Maximum, Minimum, Sum, and Average, respectively. */

SELECT CAST(MAX(salary) AS INT) AS Maximum,CAST(MIN(salary) AS INT) AS Minimum,CAST(SUM(salary) AS INT) AS Sum,CAST(AVG(salary) AS INT) AS Average FROM employees;

/* 21. Find the highest, lowest, sum, and average salary for each job. Label the columns Maximum, Minimum, Sum, and Average. */

SELECT job_title AS JOB_ID,CAST(MAX(salary) AS INT) AS Maximum,CAST(MIN(salary) AS INT) AS Minimum,CAST(SUM(salary) AS INT) AS Sum,CAST(AVG(salary) AS INT) AS Average FROM employees,jobs WHERE employees.job_id = jobs.job_id GROUP BY job_title;

/* 22. Write a query to display the number of people with the same job. */

SELECT job_title,COUNT(*) AS 'COUNT(*)' FROM employees,jobs WHERE employees.job_id = jobs.job_id GROUP BY jobs.job_title;

/* 23. Create a query to display the total number of employees and, of that total, the number of employees hired in 1995, 1996, 1997, and 1998. Create appropriate column headings. */

SELECT COUNT(*) AS 'TOTAL',(SELECT COUNT(*) FROM employees WHERE YEAR(employees.hire_date) = '1995') AS '1995',(SELECT COUNT(*) FROM employees WHERE YEAR(employees.hire_date) = '1996') AS '1996',(SELECT COUNT(*) FROM employees WHERE YEAR(employees.hire_date) = '1997') AS '1997',(SELECT COUNT(*) FROM employees WHERE YEAR(employees.hire_date) = '1998') AS '1998' FROM employees;

/* 24. Create a report to display the manager number and the salary of the lowest-paid employee for that manager. Exclude anyone whose manager is not known. Exclude any groups where the minimum salary is $6,000 or less. Sort the output in descending order of salary. */

SELECT manager_id AS MANAGER_ID,CAST(MIN(salary) AS INT) AS 'MIN(SALARY)' FROM employees WHERE manager_id IS NOT NULL and salary <> '6000' and salary > '6000' GROUP BY manager_id ORDER BY 2 DESC;

/* 25. Write a query for the HR department to produce the addresses of all the departments. Use the LOCATIONS and COUNTRIES tables. Show the location ID, street address, city, state or province, and country in the output. Use a JOIN to produce the results. */

SELECT locations.location_id AS LOCATION_ID,locations.street_address AS STREET_ADDRESS,locations.city AS CITY ,locations.state_province AS STATE_PROVINCE,countries.country_name AS COUNTRY_NAME FROM locations CROSS JOIN countries CROSS JOIN departments WHERE countries.country_id = locations.country_id AND locations.location_id = departments.location_id;

/* 26. The HR department needs a report of all employees. Write a query to display the last name, department number, and department name for all employees. */

SELECT employees.last_name AS LAST_NAME,employees.department_id AS DEPARTMENT_ID,departments.department_name AS DEPARTMENT_NAME FROM employees,departments WHERE employees.department_id = departments.department_id;

/* 27. The HR department needs a report of employees in Toronto. Display the last name, job, department number, and department name for all employees who work in Toronto. */

SELECT employees.last_name AS LAST_NAME,employees.department_id AS DEPARTMENT_ID,departments.department_name AS DEPARTMENT_NAME FROM employees,departments WHERE employees.department_id = departments.department_id AND (SELECT location_id FROM locations WHERE city = 'Toronto') = departments.location_id;

/* 28. Create a report to display employees’ last name and employee number along with their manager’s last name and manager number. */

SELECT E1.last_name AS Employee,E1.employee_id AS EMP#,E2.last_name AS Manager,E2.employee_id AS MAN# FROM employees AS E1,employees AS E2 WHERE E1.manager_id = E2.employee_id;

/* 29. Modify above query that also display employee (king) who has no manager */

SELECT E1.last_name AS Employee,E1.employee_id AS EMP#,E2.last_name AS Manager,E2.employee_id AS MAN# FROM employees AS E1 LEFT JOIN employees AS E2 ON E1.manager_id = E2.employee_id;

/* 30. The HR department needs a report on job grades and salaries. */

SELECT last_name AS LAST_NAME,job_title AS JOB_ID,department_name AS DEPARTMENT_NAME,CAST(salary AS INT) AS SALARY,CASE job_title WHEN 'Administration Vice President' THEN 'A' WHEN 'Stock Manager' THEN 'B' WHEN 'Programmer' THEN 'C' WHEN 'Sales Representative' THEN 'D' WHEN 'Stock Clerk' THEN 'E' ELSE '0' END AS 'GRA' FROM employees,jobs,departments WHERE employees.job_id = jobs.job_id AND employees.department_id = departments.department_id;
