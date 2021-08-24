CREATE TABLE [dbo].[Wifis]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] nvarchar(50) not null, 
    [SSID] NVARCHAR(MAX) NOT NULL,
    [Password] NVARCHAR(MAX) NOT NULL,
    [DateModified] DATETIME NOT NULL, 
    [UserId] NVARCHAR(128) NOT NULL FOREIGN KEY REFERENCES [User](Id), 
    [QRImage] VARBINARY(MAX) NULL
)

GO
CREATE UNIQUE NONCLUSTERED INDEX [UniqueName]
    ON [dbo].[Wifis]([Name],[UserId]);

