CREATE TABLE [dbo].[Amount]
(
	[Id] INT NOT NULL identity (1,1) PRIMARY KEY, 
    [DisplayName] NVARCHAR(50) NOT NULL, 
    [OrderValue] INT NOT NULL 
)
GO
CREATE UNIQUE NONCLUSTERED INDEX [OrderValue]
    ON [dbo].[Amount]([OrderValue] ASC);