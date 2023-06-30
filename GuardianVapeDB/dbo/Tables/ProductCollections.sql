CREATE TABLE [dbo].[ProductCollections] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [ProductID]    INT NULL,
    [CollectionID] INT NULL,
    CONSTRAINT [PK_ProductCollections] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ProductCollections_Collection] FOREIGN KEY ([CollectionID]) REFERENCES [dbo].[Collection] ([ID]),
    CONSTRAINT [FK_ProductCollections_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductCollections_CollectionID]
    ON [dbo].[ProductCollections]([CollectionID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductCollections_ProductID]
    ON [dbo].[ProductCollections]([ProductID] ASC);

