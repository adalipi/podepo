CREATE TABLE [dbo].[ArticleAmount]
(
	[Article_Id] INT NOT NULL FOREIGN KEY REFERENCES Article(Id), 
    [Amount_Id] int NOT NULL FOREIGN KEY REFERENCES Amount(Id),

	PRIMARY KEY ([Article_Id], [Amount_Id])
)
