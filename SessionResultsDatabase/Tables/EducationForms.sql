CREATE TABLE [dbo].[FormsOfEducation]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NULL,
	CONSTRAINT [PK_dbo.FormsOfEducation] PRIMARY KEY CLUSTERED ([Id] ASC)
)
