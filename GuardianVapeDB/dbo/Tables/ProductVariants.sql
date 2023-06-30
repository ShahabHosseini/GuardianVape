CREATE TABLE [dbo].[ProductVariants] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [Value]     NVARCHAR (50) NULL,
    [ProductID] INT           NOT NULL,
    [VariantID] INT           NOT NULL,
    CONSTRAINT [PK_ProductVariants] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ProductVariants_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID]),
    CONSTRAINT [FK_ProductVariants_Variant] FOREIGN KEY ([VariantID]) REFERENCES [dbo].[Variant] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductVariants_ProductID]
    ON [dbo].[ProductVariants]([ProductID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductVariants_VariantID]
    ON [dbo].[ProductVariants]([VariantID] ASC);

