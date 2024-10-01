
        SELECT ProductName, SUM(Quantity) AS TotalQuantity
        FROM OrderDetails
        JOIN Products ON OrderDetails.ProductID = Products.ProductID
        GROUP BY ProductName
        ORDER BY TotalQuantity DESC
        LIMIT 5;
    