CREATE TABLE [dbo].[ConditionRoleType] (
    [ID]              INT IDENTITY (1, 1) NOT NULL,
    [ConditionRoleID] INT NULL,
    [ConditionTypeID] INT NULL,
    [VendorID]        INT NULL,
    [ProductTypeID]   INT NULL,
    [CategoryID]      INT NULL,
    [TagID]           INT NULL,
    [CollectionID]    INT NULL,
    CONSTRAINT [PK_ConditionRoleType] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ConditionRoleType_Category] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Category] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_Collection] FOREIGN KEY ([CollectionID]) REFERENCES [dbo].[Collection] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_ConditionRole] FOREIGN KEY ([ConditionRoleID]) REFERENCES [dbo].[ConditionRole] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_ConditionType] FOREIGN KEY ([ConditionTypeID]) REFERENCES [dbo].[ConditionType] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_ProductType] FOREIGN KEY ([ProductTypeID]) REFERENCES [dbo].[ProductType] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_Tag] FOREIGN KEY ([TagID]) REFERENCES [dbo].[Tag] ([ID]),
    CONSTRAINT [FK_ConditionRoleType_Vendor] FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_CategoryID]
    ON [dbo].[ConditionRoleType]([CategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_CollectionID]
    ON [dbo].[ConditionRoleType]([CollectionID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_ConditionRoleID]
    ON [dbo].[ConditionRoleType]([ConditionRoleID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_ConditionTypeID]
    ON [dbo].[ConditionRoleType]([ConditionTypeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_ProductTypeID]
    ON [dbo].[ConditionRoleType]([ProductTypeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_TagID]
    ON [dbo].[ConditionRoleType]([TagID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ConditionRoleType_VendorID]
    ON [dbo].[ConditionRoleType]([VendorID] ASC);

