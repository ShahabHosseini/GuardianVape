CREATE TABLE [dbo].[Tag] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [ParentID] INT           NULL,
    [Title]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Tag_Tag] FOREIGN KEY ([ParentID]) REFERENCES [dbo].[Tag] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Tag_ParentID]
    ON [dbo].[Tag]([ParentID] ASC);

