CREATE TABLE [dbo].[Variant] (
    [ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Title]   NVARCHAR (50) NULL,
    [ColorID] INT           NULL,
    [Image]   BINARY (50)   NULL,
    [Price]   MONEY         NULL,
    CONSTRAINT [PK_Variant] PRIMARY KEY CLUSTERED ([ID] ASC)
);

