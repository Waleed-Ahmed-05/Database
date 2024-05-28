/* Using Cross Join */

SELECT * FROM [Order Details] CROSS JOIN Orders;

/* Using Natural Join with Equi Join*/

SELECT ProductID,CustomerID FROM [Order Details] JOIN Orders ON [Order Details].OrderID = Orders.OrderID;

/* Using Inner Join with Equi Join */

SELECT ProductID,CustomerID FROM [Order Details] INNER JOIN Orders ON [Order Details].OrderID = Orders.OrderID;

/* Using Left Outer Join with Equi Join */

SELECT ProductID,CustomerID FROM [Order Details] LEFT OUTER JOIN Orders ON [Order Details].OrderID = Orders.OrderID;

/* Using Right Outer Join with Equi Join */

SELECT ProductID,CustomerID FROM [Order Details] RIGHT OUTER JOIN Orders ON [Order Details].OrderID = Orders.OrderID;

/* Using Full Outer Join with Equi Join */

SELECT ProductID,CustomerID FROM [Order Details] FULL Outer JOIN Orders ON [Order Details].OrderID = Orders.OrderID;