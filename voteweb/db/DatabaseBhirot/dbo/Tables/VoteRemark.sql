CREATE TABLE [dbo].[VoteRemark] (
    [voteremarkid] UNIQUEIDENTIFIER NOT NULL,
    [desc]         NVARCHAR (MAX)   NOT NULL,
    [voteid]       UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_VoteRemark] PRIMARY KEY CLUSTERED ([voteremarkid] ASC),
    CONSTRAINT [FK_VoteRemark_Vote] FOREIGN KEY ([voteid]) REFERENCES [dbo].[Vote] ([id])
);

