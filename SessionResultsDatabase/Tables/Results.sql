CREATE TABLE [dbo].[Results]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Session] NCHAR(10) NULL, 
    [Subject] NCHAR(10) NULL, 
    [Student] NCHAR(10) NULL, 
    [Mark] NCHAR(10) NULL
    CONSTRAINT [PK_dbo.Results] PRIMARY KEY CLUSTERED ([Id] ASC)
)
