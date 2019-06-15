CREATE TABLE [dbo].[BuisnessOwner] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (70)  NOT NULL,
    [LastName]  NVARCHAR (70)  NOT NULL,
    [Dni]       NVARCHAR (50)  NOT NULL,
    [Email]     NVARCHAR (200) NOT NULL,
    [Movil]     NVARCHAR (50)  NOT NULL,
    [Password]  NVARCHAR (50)  NOT NULL,
    [City]      NVARCHAR (70)  NOT NULL,
    [Country]   NVARCHAR (70)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

