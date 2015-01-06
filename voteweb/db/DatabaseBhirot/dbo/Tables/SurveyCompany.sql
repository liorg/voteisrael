CREATE TABLE [dbo].[SurveyCompany] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_SurveyCompany] PRIMARY KEY CLUSTERED ([Id] ASC)
);

