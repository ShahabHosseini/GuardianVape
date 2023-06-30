CREATE TABLE [dbo].[CategoryGroup] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NULL,
    CONSTRAINT [PK_CategoryGroup] PRIMARY KEY CLUSTERED ([ID] ASC)
);

