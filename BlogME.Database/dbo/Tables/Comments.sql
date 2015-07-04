CREATE TABLE [dbo].[Comments] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [ArticleId] INT      NOT NULL,
    [UserId]    INT      NOT NULL,
    [Body]      NTEXT    NOT NULL,
    [CreatedAt] DATETIME NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Articles] FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Articles] ([Id]),
    CONSTRAINT [FK_Comments_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

