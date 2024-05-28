/* 1. Return customers and their orders, including customers who placed no orders (CustomerID, OrderID, OrderDate) */

SELECT (SELECT CustomerID FROM Customers AS C2 WHERE C1.CustomerID = C2.CustomerID) AS CustomerID,OrderID,OrderDate FROM Customers AS C1 LEFT JOIN Orders ON C1.CustomerID = Orders.CustomerID;

/* 2. Report only those customer IDs who never placed any order. (CustomerID, OrderID, OrderDate) */

SELECT CustomerID,(SELECT OrderID FROM Orders WHERE Customers.CustomerID = Orders.CustomerID) AS OrderID,(SELECT OrderID FROM Orders WHERE Customers.CustomerID = Orders.CustomerID) AS OrderDate FROM Customers WHERE CustomerID NOT IN (SELECT CustomerID FROM Orders);

/* 3. Report those customers who placed orders on July,1997. (CustomerID, OrderID, OrderDate) */

SELECT (SELECT CustomerID FROM Customers WHERE Customers.CustomerID = Orders.CustomerID) AS CustomerID,OrderID,OrderDate FROM Orders GROUP BY OrderID,OrderDate,Orders.CustomerID HAVING YEAR(OrderDate) = '1997' AND MONTH(OrderDate) = '7';

/* 4. Report the total orders of each customer. (customerID, totalorders) */

SELECT CustomerID,(SELECT COUNT(*) FROM Orders WHERE Customers.CustomerID = Orders.CustomerID) AS totalorders FROM Customers;

/* 5. Write a query to generate a five copies of each employee. (EmployeeID, FirstName, LastName) */

SELECT (SELECT EmployeeID FROM Employees AS E3 WHERE E1.EmployeeID = E3.EmployeeID) AS EmployeeID,(SELECT FirstName FROM Employees AS E3 WHERE E1.EmployeeID = E3.EmployeeID) AS FirstName,(SELECT LastName FROM Employees AS E3 WHERE E1.EmployeeID = E3.EmployeeID) AS LastName FROM Employees AS E1,Employees AS E2 WHERE E2.EmployeeID % 2 = 0 OR E2.EmployeeID = 3 ORDER BY EmployeeID;

/* 6. List all the products whose price is more than average price. */

SELECT * FROM Products WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products);

/* 7. Find the second highest price of product. */

SELECT MAX(UnitPrice) AS Second_Highest_Price FROM Products WHERE UnitPrice <> (SELECT MAX(UnitPrice) FROM Products);

/* 8. Write a query that returns a row for each employee and day in the range 04-07-1996 through 04-08-1997. (EmployeeID, Date) */

SELECT EmployeeID,OrderDate FROM Orders WHERE OrderDate >= '1996-07-04 00:00:00.000'  AND OrderDate<= '1997-08-04 00:00:00.000' ;

/* 9. Return US customers, and for each customer return the total number of orders and total quantities. (CustomerID, Totalorders, totalquantity) */

SELECT CustomerID,(SELECT COUNT(*) FROM Orders WHERE Customers.CustomerID = Orders.CustomerID) AS Totalorders,(SELECT SUM(Quantity) FROM [Order Details] WHERE [Order Details].OrderID IN (SELECT OrderID FROM Orders WHERE Orders.CustomerID = Customers.CustomerID)) AS totalorders FROM Customers WHERE Country = 'USA';

/* 10. Write a query that returns all customers in the output, but matches them with their respective orders only if they were placed on July 04,1997. (CustomerID, CompanyName, OrderID, Orderdate) */

SELECT (SELECT CustomerID FROM Customers WHERE Customers.CustomerID = Orders.CustomerID) AS CustomerID,(SELECT CompanyName FROM Customers WHERE Customers.CustomerID = Orders.CustomerID) AS CompanyName,OrderID,OrderDate FROM Orders WHERE OrderDate = '1997-07-04 00:00:00.000';

/* 11. Are there any employees who are older than their managers? */

SELECT E1.FirstName + ' ' + E1.LastName + ' is older than his/her manager ' + (SELECT E2.FirstName + ' ' + E2.LastName + '.' FROM Employees AS E2 WHERE E1.ReportsTo = E2.EmployeeID) AS [Older Employees] FROM Employees AS E1 WHERE BirthDate < (SELECT BirthDate FROM Employees AS E2 WHERE E1.ReportsTo = E2.EmployeeID);

/* 12. List that names of those employees and their ages. (EmployeeName, Age, Manager Age) */

SELECT E1.FirstName + ' ' + E1.LastName AS EmployeeName,(SELECT 2024 - YEAR(E1.BirthDate) FROM Employees AS E2 WHERE E1.ReportsTo = E2.EmployeeID) AS Age,(SELECT 2024 - YEAR(E2.BirthDate) FROM Employees AS E2 WHERE E1.ReportsTo = E2.EmployeeID) AS [Manager Age] FROM Employees AS E1 WHERE BirthDate < (SELECT BirthDate FROM Employees AS E2 WHERE E1.ReportsTo = E2.EmployeeID);

/* 13. List the names of products which were ordered on 8th August 1997. (ProductName, OrderDate) */

SELECT (SELECT ProductName FROM Products WHERE Products.ProductID = [Order Details].ProductID) AS ProductName,(SELECT OrderDate FROM Orders WHERE [Order Details].OrderID = Orders.OrderID) AS OrderDate FROM [Order Details] WHERE [Order Details].OrderID = (SELECT OrderID FROM Orders WHERE ORDERDATE = '1997-08-08 00:00:00.000');

/* 14. List the addresses, cities, countries of all orders which were serviced by Anne and were shipped late. (Address, City, Country) */

SELECT ShipAddress,ShipCity,ShipCountry FROM Orders WHERE ShippedDate > RequiredDate AND EmployeeID = (SELECT EmployeeID FROM Employees WHERE FirstName = 'Anne');

/* 15. List all countries to which beverages have been shipped. (Country) */

SELECT DISTINCT(ShipCountry) AS Country FROM Orders WHERE OrderID IN (SELECT OrderID FROM [Order Details] WHERE ProductID IN (SELECT ProductID FROM Products WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CategoryName = 'Beverages')));