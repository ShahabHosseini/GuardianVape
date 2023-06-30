CREATE TABLE [dbo].[Media] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [URL]          NVARCHAR (50) NULL,
    [Value]        BINARY (50)   NULL,
    [ProductID]    INT           NULL,
    [CollectionID] INT           NULL,
    CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Media_Collection] FOREIGN KEY ([CollectionID]) REFERENCES [dbo].[Collection] ([ID]),
    CONSTRAINT [FK_Media_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Media_CollectionID]
    ON [dbo].[Media]([CollectionID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Media_ProductID]
    ON [dbo].[Media]([ProductID] ASC);

