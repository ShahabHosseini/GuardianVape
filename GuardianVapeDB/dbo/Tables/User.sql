CREATE TABLE [dbo].[User] (
    [ID]                     INT            IDENTITY (1, 1) NOT NULL,
    [Email]                  NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [FristName]              NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [LastName]               NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [Password]               NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [UserName]               NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [Role]                   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [RefreshToken]           NVARCHAR (MAX) NULL,
    [RefreshTokenExpiryTime] DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    [Token]                  NVARCHAR (MAX) NULL,
    [ResetPasswordExpiry]    DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    [ResetPasswordToken]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

