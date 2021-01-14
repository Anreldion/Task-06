CREATE TABLE [dbo].[Results]
(
	[Id] INT NOT NULL, 
    [SessionId] INT NOT NULL, 
    [SubjectId] INT NOT NULL, 
    [StudentId] INT NOT NULL, 
    [Mark] INT NULL
    CONSTRAINT [PK_dbo.Results] PRIMARY KEY CLUSTERED ([Id] ASC)

    CONSTRAINT [FK_dbo.Results.SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[Subjects]([Id]),
    CONSTRAINT [FK_dbo.Results.SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subjects]([Id]),
    CONSTRAINT [FK_dbo.Results.StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students]([Id]),
)
