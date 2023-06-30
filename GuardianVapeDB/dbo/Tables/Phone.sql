CREATE TABLE [dbo].[Phone] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [AreaCode]    NCHAR (10)    NULL,
    [PhoneNumber] NVARCHAR (12) NULL,
    CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED ([ID] ASC)
);

