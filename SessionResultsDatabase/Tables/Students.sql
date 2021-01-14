CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Surname] NVARCHAR(MAX) NOT NULL,
    [MiddleName] NVARCHAR(MAX) NOT NULL,
    [GenderId] INT NOT NULL,
    [DateofBirth] DATETIME NOT NULL, 
    [GroupId] INT NOT NULL,
    [EducationFormId] INT NOT NULL
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([Id] ASC),

    CONSTRAINT [FK_dbo.Students.GenderId] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders]([Id]), 
    CONSTRAINT [FK_dbo.Students.GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups]([Id]), 
    CONSTRAINT [FK_dbo.Students.FormOfEducationId] FOREIGN KEY ([EducationFormId]) REFERENCES [dbo].[FormsOfEducation]([Id])
)
