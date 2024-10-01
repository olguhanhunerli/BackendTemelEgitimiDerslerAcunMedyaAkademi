
        SELECT CategoryName, COUNT(*) AS ProductCount
        FROM Products
        JOIN Categories ON Products.CategoryID = Categories.CategoryID
        GROUP BY CategoryName;
    