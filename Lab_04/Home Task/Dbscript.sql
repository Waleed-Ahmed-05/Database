/* List name of all the products whose price is above average. (Product Name) */

SELECT ProductName FROM Products WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products); 

/* Write a query to generate report showing date wise orders shipped. (ShippedDate, numberoforders) */

SELECT ShippedDate,COUNT(*) as numberoforders FROM Orders WHERE ShippedDate IS NOT NULL GROUP BY ShippedDate ORDER BY ShippedDate;

/* List name of all countries from where two or more suppliers belong to. (Country) */

SELECT Country FROM Suppliers GROUP BY Country HAVING Count(*) >= 2;

/* Write a query to generate report showing month wise orders delayed shipped. Your output should look like this (Month Number, Orders Delayed) */

SELECT MONTH(ShippedDate) as [Month Number],COUNT(*) as [Orders Delayed]FROM Orders WHERE ShippedDate > RequiredDate GROUP BY  MONTH(ShippedDate);

/* Report all the orders which have been discounted. Your result should show the total discount against each order. Output should look like this (Order ID, Discount) */

SELECT OrderID, SUM(Discount) as Discount FROM [Order Details] GROUP BY OrderID,Discount HAVING AVG(Discount) > 0 ORDER BY OrderID;

/* Write a query to list the number of orders which were shipped in the cities of USA in 1997. Show the number of order against each city. (Ship City, Number of orders) */

SELECT ShipCity, COUNT(*) AS [Number of orders] FROM Orders WHERE YEAR(ShippedDate) = '1997' AND ShipCountry = 'USA'  GROUP BY ShipCity;

/* Write a query to generate report showing country wise orders delayed shipped. Your output should look like this: (Country, Orders Delayed) */

SELECT ShipCountry, COUNT(*) AS [Orders Delayes] FROM Orders WHERE ShippedDate > RequiredDate GROUP BY ShipCountry;

/* Report all the orders which have been discounted with total price of order. Your result should show the total discount against each order. Output should look like this: (Order ID, Discount, Total Price) */

SELECT OrderID, SUM(Discount) as Discount, SUM(UnitPrice) as TotalPrice FROM [Order Details] GROUP BY OrderID,Discount HAVING AVG(Discount) > 0 ORDER BY OrderID;

/* Write a query to list the number of orders which were shipped in the cities of each region in 1997. Show the number of order against each city. Your results should look like this: (ShipRegion, ShipCity,Numberoforders) */

SELECT ShipRegion,ShipCity,COUNT(*) as Orders FROM Orders WHERE ShipRegion IS NOT NULL GROUP BY ShipRegion,ShipCity ORDER BY ShipRegion;