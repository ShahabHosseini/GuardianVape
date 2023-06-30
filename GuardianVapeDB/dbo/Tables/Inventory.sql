CREATE TABLE [dbo].[Inventory] (
    [ID]                        INT           IDENTITY (1, 1) NOT NULL,
    [SKU]                       NVARCHAR (50) NULL,
    [Barcode]                   NVARCHAR (50) NULL,
    [ShopLocationID]            INT           NULL,
    [TrackQuantity]             BIT           NULL,
    [ContinueSellingOutOfStock] BIT           NULL,
    [ProductID]                 INT           NOT NULL,
    CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Inventory_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Inventory_ProductID]
    ON [dbo].[Inventory]([ProductID] ASC);

