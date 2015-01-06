CREATE TABLE [dbo].[Vote] (
    [SurveyCompanyId]  INT              NOT NULL,
    [PoliticalPartyId] INT              NOT NULL,
    [votes]            INT              NOT NULL,
    [id]               UNIQUEIDENTIFIER NOT NULL,
    [SurveyId]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Vote] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Vote_PoliticalParty] FOREIGN KEY ([PoliticalPartyId]) REFERENCES [dbo].[PoliticalParty] ([Id]),
    CONSTRAINT [FK_Vote_Survey] FOREIGN KEY ([SurveyId]) REFERENCES [dbo].[Survey] ([Id]),
    CONSTRAINT [FK_Vote_SurveyCompany] FOREIGN KEY ([SurveyCompanyId]) REFERENCES [dbo].[SurveyCompany] ([Id])
);

