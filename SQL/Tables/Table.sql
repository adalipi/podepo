CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] nvarchar(50) not null, 
    [Description] NVARCHAR(50) NULL,

)

GO
CREATE UNIQUE NONCLUSTERED INDEX [UniqueName]
    ON [dbo].[Table]([Name] ASC);

