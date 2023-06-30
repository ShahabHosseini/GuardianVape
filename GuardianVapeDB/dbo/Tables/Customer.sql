CREATE TABLE [dbo].[Customer] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [FristName]   NVARCHAR (50)  NULL,
    [LastName]    NVARCHAR (50)  NULL,
    [Language]    NCHAR (10)     NULL,
    [Email]       NVARCHAR (50)  NULL,
    [PhoneID]     INT            NULL,
    [AgreedEmail] BIT            NULL,
    [AgreedSMS]   BIT            NULL,
    [AddressID]   INT            NULL,
    [Note]        NVARCHAR (500) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Customer_Address] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Address] ([ID]),
    CONSTRAINT [FK_Customer_Customer] FOREIGN KEY ([PhoneID]) REFERENCES [dbo].[Phone] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Customer_AddressID]
    ON [dbo].[Customer]([AddressID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Customer_PhoneID]
    ON [dbo].[Customer]([PhoneID] ASC);

