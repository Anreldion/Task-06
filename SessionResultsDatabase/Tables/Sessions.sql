CREATE TABLE [dbo].[Sessions]
(
	[Id] INT NOT NULL,
	[SessionPeriodId] INT NOT NULL

	CONSTRAINT [PK_dbo.Sessions] PRIMARY KEY CLUSTERED ([Id] ASC), 
    [From] DATETIME NULL, 
    [To] DATETIME NULL
)
