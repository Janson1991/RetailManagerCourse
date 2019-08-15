CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PruductName] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [CreateDate] DATETIME2 NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NULL DEFAULT getutcdate(), 
    [RetailPrice] MONEY NOT NULL
)
