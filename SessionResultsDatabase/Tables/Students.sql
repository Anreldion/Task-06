CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Surname] NVARCHAR(MAX) NULL, 
    [DateofBirth] DATETIME NULL, 
    [Group] INT NULL
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([Id] ASC)
)
