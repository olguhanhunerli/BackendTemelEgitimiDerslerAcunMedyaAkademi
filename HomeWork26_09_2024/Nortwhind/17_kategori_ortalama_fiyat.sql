
        SELECT CategoryName, AVG(UnitPrice) AS AvgPrice
        FROM Products
        JOIN Categories ON Products.CategoryID = Categories.CategoryID
        GROUP BY CategoryName;
    