CREATE TABLE [dbo].[Country] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (50) NULL,
    [AreaCode] NVARCHAR (10) NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([ID] ASC)
);

