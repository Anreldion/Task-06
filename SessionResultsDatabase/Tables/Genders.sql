﻿CREATE TABLE [dbo].[Genders]
(
	[Id] [int] IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Genders] PRIMARY KEY ([Id]),
);