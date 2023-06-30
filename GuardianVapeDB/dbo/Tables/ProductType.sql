CREATE TABLE [dbo].[ProductType] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED ([ID] ASC)
);

