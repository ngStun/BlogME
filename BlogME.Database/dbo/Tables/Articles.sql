CREATE TABLE [dbo].[Articles] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (128) NOT NULL,
    [Body]        NTEXT          NOT NULL,
    [CreatedAt]   DATETIME       NOT NULL,
    [UpdatedAt]   DATETIME       NOT NULL,
    [UserId]      INT            NOT NULL,
    [IsPublished] BIT            NOT NULL,
    CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Articles_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);



