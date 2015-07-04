CREATE TABLE [dbo].[Users] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Password]       NVARCHAR (128) NOT NULL,
    [PasswordFormat] INT            NOT NULL,
    [PasswordSalt]   NVARCHAR (128) NOT NULL,
    [UserName]       NVARCHAR (64)  NOT NULL,
    [Email]          NVARCHAR (256) NOT NULL,
    [CreateDate]     DATETIME       NOT NULL,
    [LastLoginDate]  DATETIME       NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

