CREATE TABLE [dbo].[OrderProduct] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [OrderID]   INT NULL,
    [ProductID] INT NULL,
    CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([ID]),
    CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_OrderProduct_OrderID]
    ON [dbo].[OrderProduct]([OrderID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_OrderProduct_ProductID]
    ON [dbo].[OrderProduct]([ProductID] ASC);

