
        SELECT CustomerID, COUNT(*) AS OrderCount
        FROM Orders
        GROUP BY CustomerID
        HAVING OrderCount >= 5;
    