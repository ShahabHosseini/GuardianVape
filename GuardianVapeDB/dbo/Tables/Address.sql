CREATE TABLE [dbo].[Address] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [CountryID] INT            NULL,
    [FristName] NVARCHAR (50)  NULL,
    [LastName]  NVARCHAR (50)  NULL,
    [Company]   NVARCHAR (50)  NULL,
    [Address]   NVARCHAR (200) NULL,
    [House]     NVARCHAR (50)  NULL,
    [City]      NVARCHAR (50)  NULL,
    [Postcode]  NVARCHAR (10)  NULL,
    [PhoneID]   INT            NULL,
    CONSTRAINT [PK_Address1] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Address1_Address1] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Country] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Address_CountryID]
    ON [dbo].[Address]([CountryID] ASC);

