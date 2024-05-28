/* Displaying All values form Student table */

SELECT * FROM Student;

/* Displaying Registration Numbers form Student table */

SELECT FirstName FROM Student;

/* Displaying GPA greater than 3.5 form Student table */

SELECT GPA FROM Student WHERE GPA > 3.5;

/* Displaying GPA less than or equal to 3.5 form Student table */

SELECT GPA FROM Student WHERE GPA <= 3.5;

/* Displaying First & Last Names in a single column from Student table */

SELECT FirstName + ' ' + LastName AS Names FROM Student;