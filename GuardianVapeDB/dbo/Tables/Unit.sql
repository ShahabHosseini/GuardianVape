CREATE TABLE [dbo].[Unit] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED ([ID] ASC)
);

