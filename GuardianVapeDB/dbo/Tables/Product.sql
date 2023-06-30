CREATE TABLE [dbo].[Product] (
    [ID]                   INT             IDENTITY (1, 1) NOT NULL,
    [Title]                NVARCHAR (100)  NOT NULL,
    [Description]          NVARCHAR (1000) NULL,
    [Price]                DECIMAL (18)    NOT NULL,
    [CompareatPrice]       DECIMAL (18)    NULL,
    [CostPerItem]          DECIMAL (18)    NULL,
    [TrackQuantity]        BIT             NOT NULL,
    [ShopLocation]         INT             NULL,
    [UnitID]               INT             NOT NULL,
    [ProductTypeID]        INT             NULL,
    [VendorID]             INT             NOT NULL,
    [CategoryID]           INT             NOT NULL,
    [Active]               BIT             NULL,
    [SearchEnginListingID] INT             NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Category] ([ID]),
    CONSTRAINT [FK_Product_ProductType] FOREIGN KEY ([ProductTypeID]) REFERENCES [dbo].[ProductType] ([ID]),
    CONSTRAINT [FK_Product_SearchEnginListing] FOREIGN KEY ([SearchEnginListingID]) REFERENCES [dbo].[SearchEnginListing] ([ID]),
    CONSTRAINT [FK_Product_Unit] FOREIGN KEY ([UnitID]) REFERENCES [dbo].[Unit] ([ID]),
    CONSTRAINT [FK_Product_Vendor] FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Product_CategoryID]
    ON [dbo].[Product]([CategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Product_ProductTypeID]
    ON [dbo].[Product]([ProductTypeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Product_SearchEnginListingID]
    ON [dbo].[Product]([SearchEnginListingID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Product_UnitID]
    ON [dbo].[Product]([UnitID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Product_VendorID]
    ON [dbo].[Product]([VendorID] ASC);

