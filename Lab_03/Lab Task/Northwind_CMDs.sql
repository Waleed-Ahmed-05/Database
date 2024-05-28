/* Displaying all the tables in Northwind Database using "SELECT" */

SELECT * FROM Categories

SELECT * FROM Products;

SELECT * FROM Region;

SELECT * FROM Suppliers;

SELECT * FROM Suppliers;

SELECT * FROM Territories;

SELECT * FROM Employees;

SELECT * FROM EmployeeTerritories;

SELECT * FROM Customers;

SELECT * FROM CustomerCustomerDemo;

SELECT * FROM CustomerDemographics;

SELECT * FROM Orders;

SELECT * FROM [Order Details];

/* Displaying Territory ID's from Territories table */

SELECT TerritoryID FROM Territories;

/* Dislaying Product Names whose Unit Price < 50.50 from Product Table */

SELECT ProductName FROM Products WHERE UnitPrice < 50.50;

/* Dislaying Product Names whose Unit Price > 50.50 from Product Table */

SELECT ProductName FROM Products WHERE UnitPrice > 50.50;

/* Displaying names of Employees using "Concatination Operator (|| or +)" & "AS" */

SELECT FirstName + ' ' + LastName AS Names FROM Employees;