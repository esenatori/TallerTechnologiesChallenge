Insert into Customer([PersonID], [FirstName],[LastName],[Age],[Occupation],[MartialStatus]) Values(1, 'John', 'Walker', 35, 'Medic', 1);

Insert into Orders (OrderID, PersonID, DateCreated, MethodofPurchase) Values(1, 1, getdate(), 'Effective');

Insert into OrderDetail (OrderDetailID, OrderID, ProductNumber, ProductID, ProductOrigin) Values(1, 1, '1112222333', 1112222333,'Indonesia');
Insert into OrderDetail (OrderDetailID, OrderID, ProductNumber, ProductID, ProductOrigin) Values(2, 1, '1112222333', 1112222333,'Indonesia');
Insert into OrderDetail (OrderDetailID, OrderID, ProductNumber, ProductID, ProductOrigin) Values(3, 1, '1112222333', 1112222333,'Indonesia');
Insert into OrderDetail (OrderDetailID, OrderID, ProductNumber, ProductID, ProductOrigin) Values(4, 1, '1112222333', 1112222333,'Indonesia');
Insert into OrderDetail (OrderDetailID, OrderID, ProductNumber, ProductID, ProductOrigin) Values(5, 1, '1112222333', 1112222333,'Indonesia');