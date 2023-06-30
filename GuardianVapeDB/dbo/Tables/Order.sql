CREATE TABLE [dbo].[Order] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [Name]                NVARCHAR (50) NULL,
    [Date]                DATETIME      NULL,
    [CustomerID]          INT           NULL,
    [Channel]             NVARCHAR (50) NULL,
    [Total]               DECIMAL (18)  NULL,
    [PaymentStatusID]     INT           NULL,
    [FulfillmentStatusID] INT           NULL,
    [Items]               INT           NULL,
    [DeliveryMethodID]    INT           NULL,
    [OrderProductID]      INT           NULL,
    [ShippingAddress]     INT           NULL,
    [BillingAddress]      INT           NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([ID]),
    CONSTRAINT [FK_Order_OrderProduct] FOREIGN KEY ([OrderProductID]) REFERENCES [dbo].[OrderProduct] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Order_CustomerID]
    ON [dbo].[Order]([CustomerID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Order_OrderProductID]
    ON [dbo].[Order]([OrderProductID] ASC);

