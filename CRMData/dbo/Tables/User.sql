CREATE TABLE [dbo].[User]
(
    [Id] NVARCHAR(128) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [EmaiAdress] NVARCHAR(200) NOT NULL, 
    [CreateDate] DATETIME2 NULL DEFAULT getutcdate()
)
