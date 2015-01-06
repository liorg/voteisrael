CREATE TABLE [dbo].[Survey] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [surveyname] NVARCHAR (100)   NOT NULL,
    [createdon]  DATETIME         NOT NULL,
    [surveydate] DATETIME         NOT NULL,
    CONSTRAINT [PK_Survey] PRIMARY KEY CLUSTERED ([Id] ASC)
);

