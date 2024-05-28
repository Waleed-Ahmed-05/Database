/* Calculating average price of products */

SELECT AVG(UnitPrice) AS Average FROM Products;

/* Displaying the minimum price of product from all products */

SELECT MIN(UnitPrice) AS Minimum FROM Products;

/* Displaying the maximum price of product from all products */

SELECT MAX(UnitPrice) AS Maximum FROM Products;

/* Adding the price of all products */

SELECT SUM(UnitPrice) AS [Total Price] FROM Products;

/* Counting all the products being sold */

SELECT COUNT(*) AS [Total Products] FROM Products;

/* Calculating standard deviation for the price of all products */

SELECT STDEV(UnitPrice) AS [Standard Deviation] FROM Products;

/* Calculating standard deviation population for the price of all products */

SELECT STDEVP(UnitPrice) AS [Standard Deviation Population] FROM Products;

/* Calculating varience via the price of all products */

SELECT VAR(UnitPrice) AS Varience FROM Products;

/* Calculating varience of the population via the price of all products */

SELECT VARP(UnitPrice) AS [Varience of the Population] FROM Products;