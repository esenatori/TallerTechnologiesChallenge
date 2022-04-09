CREATE TABLE [dbo].[Orders]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [PersonID] INT NULL, 
    [DateCreated] DATETIME NULL, 
    [MethodofPurchase] VARCHAR(500) NULL
)
