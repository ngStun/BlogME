CREATE TABLE [dbo].[ArticlesTags] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ArticleId] INT NOT NULL,
    CONSTRAINT [PK_ArticlesTags] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ArticlesTags_Articles] FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Articles] ([Id])
);

