CREATE TABLE [dbo].[Schedules]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Subject] NCHAR(10) NULL,
    [Date] DATETIME NULL,
    [Session] INT NULL, 
    [Group] INT NULL, 
    [KnowledgeTestForm] INT NULL
    CONSTRAINT [PK_dbo.Schedules] PRIMARY KEY CLUSTERED ([Id] ASC)
)
