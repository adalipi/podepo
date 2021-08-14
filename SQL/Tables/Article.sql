CREATE TABLE [dbo].[Article]
(
	[Id] INT  NOT NULL IDENTITY (1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ImagePath] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Category_Id] INT NOT NULL FOREIGN KEY REFERENCES Category(Id), 
    [OrderPriority] INT NOT NULL DEFAULT 1 
)
