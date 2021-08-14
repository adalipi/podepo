CREATE TABLE [dbo].[Category]
(
	[Id] INT identity (1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL
)
