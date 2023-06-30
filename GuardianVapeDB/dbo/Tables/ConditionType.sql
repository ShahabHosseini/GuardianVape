CREATE TABLE [dbo].[ConditionType] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ConditionType] PRIMARY KEY CLUSTERED ([ID] ASC)
);

