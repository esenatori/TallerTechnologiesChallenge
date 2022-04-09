CREATE TABLE [dbo].[Orders]
(
	[OrderID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonID] INT NULL, 
    [DateCreated] DATETIME NULL, 
    [MethodofPurchase] VARCHAR(500) NULL
)
