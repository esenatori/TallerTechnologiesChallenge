CREATE TABLE [dbo].[Customer]
(
	[PersonID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] varchar(500) NULL, 
    [LastName] varchar(500) NULL, 
    [Age] int NULL, 
    [Occupation] varchar(500) NULL, 
    [MartialStatus] bit NULL,
    
)
