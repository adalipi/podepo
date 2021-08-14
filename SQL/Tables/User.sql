CREATE TABLE [dbo].[User] (
    [Id]                   NVARCHAR (128) NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NOT NULL,
    [Name]                  NVARCHAR (256) NOT NULL,
    [LastName]             NVARCHAR (256) NOT NULL,
    [LockoutEnd]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [NormalizedUserName] NVARCHAR(256) NOT NULL, 
    CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([Id] ASC),
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[User]([UserName] ASC);

