/* 1. Return customers and their orders, including customers who placed no orders. (CustomerID, OrderID, OrderDate) */

SELECT Customers.CustomerID,Orders.OrderID,Orders.OrderDate FROM Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

/* 2. Report only those customer IDs who never placed any order. (CustomerID, OrderID, OrderDate) */

SELECT Customers.CustomerID,Orders.OrderID,Orders.OrderDate FROM Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID GROUP BY Customers.CustomerID,Orders.OrderID,Orders.OrderDate HAVING COUNT(Orders.OrderID) = '0';

/* 3. Report those customers who placed orders on July,1997. (CustomerID, OrderID, OrderDate) */

SELECT CustomerID,OrderID,OrderDate FROM Orders GROUP BY CustomerID,OrderID,OrderDate HAVING MONTH(OrderDate) = '7' AND YEAR(OrderDate) = '1997';

/* 4. Report the total orders of each customer. (customerID, totalorders) */

SELECT Customers.CustomerID,COUNT(Orders.OrderID) AS [Total Orders] FROM Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID GROUP BY Customers.CustomerID;

/* 5. Write a query to generate a five copies of each employee. (EmployeeID, FirstName, LastName) */

SELECT E1.EmployeeID,E1.FirstName,E1.LastName FROM Employees AS E1,Employees AS E2 WHERE E2.EmployeeID % 2 = 0 OR E2.EmployeeID = 3 ORDER BY EmployeeID;

/* 6. Write a query that returns a row for each employee and day in the range 04-07-1996 through 04-08-1997. (EmployeeID, Date) */

SELECT EmployeeID,OrderDate AS Date FROM ORDERS WHERE OrderDate >= '1996-07-04 00:00:00.000' AND OrderDate <= '1997-08-04 00:00:00.000';

/* 7. Return US customers, and for each customer return the total number of orders and total quantities. (CustomerID, Totalorders, totalquantity) */

SELECT Customers.CustomerID,COUNT(DISTINCT(Orders.OrderID)) AS Totalorders,SUM(Quantity) AS totalquantity FROM Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID CROSS JOIN [Order Details] WHERE Orders.OrderID = [Order Details].OrderID GROUP BY Customers.CustomerID,Orders.ShipCountry HAVING Orders.ShipCountry = 'USA';

/* 8. Write a query that returns all customers in the output, but matches them with their respective orders only if they were placed on July 04,1997. (CustomerID, CompanyName, OrderID, Orderdate) */

SELECT Customers.CustomerID,Customers.CompanyName,Orders.OrderID,Orders.OrderDate FROM CUSTOMERS LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID GROUP BY Customers.CustomerID,Customers.CompanyName,Orders.OrderID,Orders.OrderDate HAVING YEAR(Orders.OrderDate) = '1997' AND MONTH(Orders.OrderDate) = '7' AND DAY(Orders.OrderDate) = '04';

/* 9. Are there any employees who are older than their managers? */

SELECT E1.FirstName + ' ' + E1.LastName + ' is older than his manager ' + E2.FirstName + ' ' + E2.LastName AS [Older Employees] FROM Employees AS E1,Employees AS E2 GROUP BY E2.FirstName,E2.LastName,E1.FirstName,E1.LastName,E1.BirthDate,E2.BirthDate,E2.EmployeeID,E1.ReportsTo HAVING (2024 - YEAR(E1.BirthDate) > 2024 - YEAR(E2.BirthDate)) AND E2.EmployeeID = E1.ReportsTo;

/* 10. List that names of those employees and their ages. (EmployeeName, Age, Manager Age) */

SELECT E1.FirstName + ' ' + E1.LastName AS [EmployeeName],2024 - YEAR(E1.BirthDate) AS Age,2024 - YEAR(E2.BirthDate) AS [Manager Age] FROM Employees AS E1,Employees AS E2 GROUP BY E2.FirstName,E2.LastName,E1.FirstName,E1.LastName,E1.BirthDate,E2.BirthDate,E2.EmployeeID,E1.ReportsTo HAVING (2024 - YEAR(E1.BirthDate) > 2024 - YEAR(E2.BirthDate)) AND E2.EmployeeID = E1.ReportsTo;

/* 11. List the names of products which were ordered on 8th August 1997. (ProductName, OrderDate) */

SELECT Products.ProductName,Orders.OrderDate FROM Products,Orders,[Order Details] WHERE Orders.OrderID = [Order Details].OrderID AND Products.ProductID = [Order Details].ProductID GROUP BY Products.ProductName,Orders.OrderDate HAVING YEAR(Orders.OrderDate) = '1997' AND MONTH(Orders.OrderDate) = '8' AND DAY(Orders.OrderDate) = '8';

/* 12. List the addresses, cities, countries of all orders which were serviced by Anne and were shipped late. (Address, City, Country) */

SELECT Orders.ShipAddress,Orders.ShipCity,Orders.ShipCountry FROM Employees,Orders WHERE Employees.EmployeeID = Orders.EmployeeID AND Employees.FirstName = 'Anne';

/* 13. List all countries to which beverages have been shipped. (Country) */

SELECT Distinct(ShipCountry) AS Country FROM Orders,[Order Details],Products,Categories WHERE ORDERS.OrderID = [Order Details].OrderID AND [Order Details].ProductID = Products.ProductID AND Products.CategoryID = Categories.CategoryID AND CategoryName = 'Beverages';