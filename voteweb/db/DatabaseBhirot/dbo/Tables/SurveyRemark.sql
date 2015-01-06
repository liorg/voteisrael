CREATE TABLE [dbo].[SurveyRemark] (
    [id]       UNIQUEIDENTIFIER NOT NULL,
    [desc]     NVARCHAR (MAX)   NOT NULL,
    [surveyid] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_SurveyRemark] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_SurveyRemark_Survey] FOREIGN KEY ([surveyid]) REFERENCES [dbo].[Survey] ([Id])
);

