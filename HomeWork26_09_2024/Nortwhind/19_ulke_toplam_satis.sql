
        SELECT ShipCountry, SUM(UnitPrice * Quantity) AS TotalSales
        FROM Orders
        JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
        GROUP BY ShipCountry;
    