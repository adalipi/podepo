CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DateTime] DATETIME NOT NULL, 
    [Table_Id] INT NOT NULL FOREIGN KEY REFERENCES [Table](Id), 
    [User_Id] nvarchar(128) NOT NULL FOREIGN KEY REFERENCES [User](Id), 
    [Payment] BIT NOT NULL DEFAULT ((0)), 
    [Served] BIT NOT NULL DEFAULT ((0))
)
