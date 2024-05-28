/* 1. Displaying orders which were delayed shipping. */

SELECT * FROM Orders WHERE RequiredDate < ShippedDate;

/* 2. Displaying name of countries from where employees are from. */

SELECT DISTINCT Country FROM Employees;

/* 3. Displaying employees who are not accountable. */

SELECT * FROM Employees WHERE ReportsTo IS NULL;

/* 4. Displaying product names that have been discontinued. */

SELECT ProductName FROM Products WHERE Discontinued = 1;

/* 5. Displaying order ID's on which discount was not provided. */

SELECT OrderID FROM [Order Details] WHERE Discount = 0;

/* 6. Displaying name of customers who haven't specified their region. */

SELECT ContactName FROM Customers WHERE Region IS NULL;

/* 7. Dislaying name & contact of customers who either belong from UK or USA. */

SELECT CompanyName,ContactName FROM Customers WHERE Country = 'UK' OR Country = 'USA';

/* 8. Displaying the name of companies who have provided their web page. */

SELECT CompanyName FROM Suppliers WHERE HomePage IS NOT NULL;

/* 9. Displaying the name of countries that sold products in 1997. */

SELECT DISTINCT ShipCountry FROM Orders WHERE OrderDate >= '1997-01-01 00:00:00.000' AND OrderDate <= '1997-12-31 00:00:00.000';

/* 10. Displaying the ID's of customers whose orders were never shipped. */

SELECT CustomerID FROM Orders WHERE ShippedDate IS NULL;

/* 11. Displaying ID's,company names & city of suppliers. */

SELECT SupplierID,CompanyName,City FROM Suppliers;

/* 12. Displaying the number of countries & name of employees who used to live in London. */

SELECT COUNT(Distinct Country) AS [No of Countries] FROM Employees;

SELECT * FROM Employees WHERE City = 'London';

/* 13. Displaying the names of products which haven't been discontinued. */

SELECT ProductName FROM Products WHERE Discontinued = 0;

/* 14. Displaying the order ID's on which discount was 0.1 or less. */

SELECT OrderID FROM [Order Details] WHERE Discount <= 0.1;

/* 15. Displaying the ID's,names & contact number of employees who have not specified their region. */

SELECT EmployeeID,FirstName + ' ' + LastName AS Names,HomePhone FROM Employees WHERE Region IS NULL;