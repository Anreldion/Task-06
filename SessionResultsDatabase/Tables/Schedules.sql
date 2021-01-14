﻿CREATE TABLE [dbo].[Schedules]
(
	[Id] INT NOT NULL, 
    [Date] DATETIME NOT NULL,
    [SubjectId] INT NOT NULL,
    [SessionId] INT NOT NULL, 
    [GroupId] INT NOT NULL, 
    [TestFormId] INT NOT NULL
    CONSTRAINT [PK_dbo.Schedules] PRIMARY KEY CLUSTERED ([Id] ASC), 
    
    CONSTRAINT [FK_dbo.Schedules.SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subjects]([Id]),
    CONSTRAINT [FK_dbo.Schedules.GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups]([Id]), 
    CONSTRAINT [FK_dbo.Schedules.TestFormId] FOREIGN KEY ([TestFormId]) REFERENCES [dbo].[TestForms]([Id]), 
    CONSTRAINT [FK_dbo.Schedules.SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[TestForms]([Id]), 



)
