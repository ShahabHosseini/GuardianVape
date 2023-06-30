CREATE TABLE [dbo].[Vendor] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED ([ID] ASC)
);

