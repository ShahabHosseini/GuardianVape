CREATE TABLE [dbo].[Body] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [BodyText] NVARCHAR (MAX) NULL,
    [Media]    BINARY (50)    NULL,
    CONSTRAINT [PK_Body] PRIMARY KEY CLUSTERED ([ID] ASC)
);

