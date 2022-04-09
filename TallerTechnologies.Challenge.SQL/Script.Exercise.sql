Select concat(c.FirstName, ', ', LastName) as FullName, c.Age, o.OrderID, o.DateCreated, o.MethodofPurchase, od.ProductNumber, od.ProductOrigin
from Orders o 
left join OrderDetail od on o.OrderID = od.OrderID
inner join Customer c on c.PersonID = o.PersonID
Where od.ProductID = 1112222333
Group by concat(c.FirstName, ', ', LastName), c.Age, o.OrderID, o.DateCreated, o.MethodofPurchase, od.ProductNumber, od.ProductOrigin