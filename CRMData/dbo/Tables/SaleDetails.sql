CREATE TABLE [dbo].[SaleDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [PuchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL DEFAULT 0, 
    [Quantity] INT NULL DEFAULT 1
)
