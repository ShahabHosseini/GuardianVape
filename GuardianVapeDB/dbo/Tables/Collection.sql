CREATE TABLE [dbo].[Collection] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (50)   NOT NULL,
    [Description]     NVARCHAR (500)  NULL,
    [ParentID]        INT             NULL,
    [PageTitle]       NVARCHAR (50)   NULL,
    [MetaDescription] NVARCHAR (500)  NULL,
    [Media]           VARBINARY (MAX) NULL,
    CONSTRAINT [PK_Collection] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Collection_Collection1] FOREIGN KEY ([ParentID]) REFERENCES [dbo].[Collection] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Collection_ParentID]
    ON [dbo].[Collection]([ParentID] ASC);

