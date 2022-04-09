CREATE TABLE [dbo].[OrderDetail]
(
	[OrderDetailID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderID] INT NULL, 
    [ProductNumber] VARCHAR(500) NULL, 
    [ProductID] INT NULL, 
    [ProductOrigin] VARCHAR(500) NULL
)
