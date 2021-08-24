CREATE TABLE [dbo].[Infopages]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] nvarchar(50) not null, 
    [ContentText] TEXT NOT NULL,
    [Background] NVARCHAR(50) NULL,
    [DateModified] DATETIME NOT NULL, 
    [UserId] NVARCHAR(128) NOT NULL FOREIGN KEY REFERENCES [User](Id), 
    [QRImage] NVARCHAR(50) NULL
)

GO
CREATE UNIQUE NONCLUSTERED INDEX [UniqueName]
    ON [dbo].[Infopages]([Name],[UserId]);

