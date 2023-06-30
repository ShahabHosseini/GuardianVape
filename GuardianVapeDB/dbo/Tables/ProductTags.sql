CREATE TABLE [dbo].[ProductTags] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [ProductID] INT NULL,
    [TagID]     INT NULL,
    CONSTRAINT [PK_ProductTags] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ProductTags_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID]),
    CONSTRAINT [FK_ProductTags_Tag] FOREIGN KEY ([TagID]) REFERENCES [dbo].[Tag] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductTags_ProductID]
    ON [dbo].[ProductTags]([ProductID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductTags_TagID]
    ON [dbo].[ProductTags]([TagID] ASC);

