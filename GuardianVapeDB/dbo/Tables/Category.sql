CREATE TABLE [dbo].[Category] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (50) NULL,
    [CategoryGroupID] INT           NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Category_CategoryGroup] FOREIGN KEY ([CategoryGroupID]) REFERENCES [dbo].[CategoryGroup] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Category_CategoryGroupID]
    ON [dbo].[Category]([CategoryGroupID] ASC);

