CREATE TABLE [dbo].[SearchEnginListing] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [PageTitle]       NVARCHAR (70)  NULL,
    [MetaDescription] NVARCHAR (320) NULL,
    [URLHandle]       NVARCHAR (100) NULL,
    CONSTRAINT [PK_SearchEnginListing] PRIMARY KEY CLUSTERED ([ID] ASC)
);

