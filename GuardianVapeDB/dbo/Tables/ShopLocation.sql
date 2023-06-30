CREATE TABLE [dbo].[ShopLocation] (
    [ID]          INT IDENTITY (1, 1) NOT NULL,
    [Committed]   INT NULL,
    [Available]   INT NULL,
    [OnHand]      INT NULL,
    [InventoryID] INT NULL,
    CONSTRAINT [PK_ShopLocation] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ShopLocation_Product] FOREIGN KEY ([InventoryID]) REFERENCES [dbo].[Inventory] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ShopLocation_InventoryID]
    ON [dbo].[ShopLocation]([InventoryID] ASC);

