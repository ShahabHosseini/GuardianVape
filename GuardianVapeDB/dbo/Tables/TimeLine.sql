CREATE TABLE [dbo].[TimeLine] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [TimelineTypeID] INT            NULL,
    [Header]         NVARCHAR (200) NULL,
    [BodyID]         INT            NULL,
    [CustomerID]     INT            NULL,
    [UserID]         INT            NULL,
    CONSTRAINT [PK_TimeLine] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TimeLine_Body] FOREIGN KEY ([BodyID]) REFERENCES [dbo].[Body] ([ID]),
    CONSTRAINT [FK_TimeLine_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([ID]),
    CONSTRAINT [FK_TimeLine_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_TimeLine_BodyID]
    ON [dbo].[TimeLine]([BodyID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TimeLine_CustomerID]
    ON [dbo].[TimeLine]([CustomerID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TimeLine_UserID]
    ON [dbo].[TimeLine]([UserID] ASC);

