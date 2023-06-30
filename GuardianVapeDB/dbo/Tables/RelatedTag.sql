CREATE TABLE [dbo].[RelatedTag] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [ProductID]  INT NULL,
    [CostumerID] INT NULL,
    CONSTRAINT [PK_RelatedTag] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_RelatedTag_Customer] FOREIGN KEY ([CostumerID]) REFERENCES [dbo].[Customer] ([ID]),
    CONSTRAINT [FK_RelatedTag_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_RelatedTag_CostumerID]
    ON [dbo].[RelatedTag]([CostumerID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_RelatedTag_ProductID]
    ON [dbo].[RelatedTag]([ProductID] ASC);

