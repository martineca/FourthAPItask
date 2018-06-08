# FourthAPItask
#The project used two SQL view to complete the specified task. I have added them bellow.
#CustomerOrders - SQL VIEW
SELECT        a.OrderID, a.CustomerID, SUM(os.Subtotal) AS Total,
SUM(ode.Quantity) AS quantity,
CASE WHEN COUNT(CASE WHEN Quantity > pro.UnitsInStock OR
                         Discontinued = 1 THEN 1 END) > 0 THEN 'Errors migh arise with this order' ELSE '' END AS Message
FROM            dbo.Orders AS a 
LEFT OUTER JOIN dbo.[Order Details Extended] AS ode ON a.OrderID = ode.OrderID 
LEFT OUTER JOIN dbo.Products AS pro ON ode.ProductID = pro.ProductID 
LEFT OUTER JOIN dbo.[Order Subtotals] AS os ON a.OrderID = os.OrderID
GROUP BY a.OrderID, a.CustomerID

#CustomersView -SQL VIEW
SELECT        a.CustomerID, a.CompanyName, a.ContactName, a.ContactTitle, a.Address, a.City, a.Region, a.PostalCode, a.Country, a.Phone, a.Fax, b.ordersNum
FROM            dbo.Customers AS a 
LEFT OUTER JOIN (SELECT        CustomerID, COUNT(OrderID) AS ordersNum
                               FROM            dbo.Orders
                               GROUP BY CustomerID) AS b ON a.CustomerID = b.CustomerID
