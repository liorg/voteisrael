CREATE TABLE [dbo].[PoliticalParty] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_PoliticalParty] PRIMARY KEY CLUSTERED ([Id] ASC)
);

