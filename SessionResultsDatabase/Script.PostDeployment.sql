INSERT INTO [dbo].[Genders] ([Name]) VALUES  ('Man') 
GO

INSERT INTO [dbo].[Genders] ([Name]) VALUES  ('Woman') 
GO

INSERT INTO [dbo].FormsOfEducation ([Name]) VALUES  ('Дневная') 
GO
INSERT INTO [dbo].FormsOfEducation ([Name]) VALUES  ('Заочная') 
GO

INSERT INTO [dbo].[Groups] ([Name]) VALUES  ('ПЭ') 
GO
INSERT INTO [dbo].[Groups] ([Name]) VALUES  ('Э') 
GO
INSERT INTO [dbo].[Groups] ([Name]) VALUES  ('ПГС') 
GO

INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Математика') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Физика') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Экономика') 
GO

INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Компьютерные сети') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Информационные технологии') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Базы данных') 
GO

INSERT INTO [dbo].[TestForms] ([Name]) VALUES  ('Экзамен')
GO
INSERT INTO [dbo].[TestForms] ([Name]) VALUES  ('Зачет') 
GO

INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Летний период') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Зимний период') 
GO

INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[From],[To]) VALUES  (2, '2020-1-12', '2020-28-12') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[From],[To]) VALUES  (1, '2021-1-5', '2021-1-6') 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 1, 2, 1, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 2, 2, 1, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 3, 2, 1, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-1-12', 4, 1, 1, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-5-12', 5, 1, 1, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-10-12', 6, 1, 1, 2) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 1, 2, 2, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 2, 2, 2, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 3, 2, 2, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-1-12', 4, 1, 2, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-5-12', 5, 1, 2, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-10-12', 6, 1, 2, 2) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 1, 2, 3, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 2, 2, 3, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2020-10-12', 3, 2, 3, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-1-12', 4, 1, 3, 2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-5-12', 5, 1, 3, 1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId]) VALUES  ('2021-10-12', 6, 1, 3, 2) 
GO

INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Юрий', 'Белозёров','Александрович', 1,'2000-1-1', 1, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Тимофей', 'Николаев','Витальевич', 1,'2000-1-7', 1, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Савелий', 'Никитин','Давидович', 1,'2000-1-4', 1, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Егор', 'Емельянов','Федотович', 1,'2000-1-6', 1, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Ермолай', 'Белозёров','Ростиславович', 1,'2000-1-10', 1, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Владлен', 'Лукин','Ростиславович', 1,'2000-2-12', 1, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Розалина', 'Карпова','Протасьевна', 2,'2001-1-1', 1, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Харитина', 'Горбунова','Федоровна', 2,'2001-1-4', 1, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Женевьева', 'Романова','Пётровна', 2,'2001-1-7', 1, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Фия', 'Носкова','Сергеевна', 2,'2001-1-10', 1, 2) 
GO

INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Герасим', 'Мухин','Арсеньевич', 1,'2000-1-2', 2, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Алексей', 'Максимов','Иосифович', 1,'2000-1-5', 2, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Геннадий', 'Мамонтов','Робертович', 1,'2000-1-8', 2, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Василий', 'Панов','Рудольфович', 1,'2000-1-11', 2, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Валерий', 'Шестаков','Натанович', 1,'2000-3-12', 2, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Милена', 'Комиссарова','Ростиславовна', 2,'2001-1-2', 2, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Верона', 'Ларионова','Васильевна', 2,'2001-1-5', 2, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Юнона', 'Владимирова','Якуновна', 2,'2001-1-8', 2, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Лика', 'Хохлова','Донатовна', 2,'2001-1-11', 2, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Белла', 'Лихачёва','Яковлевна', 2,'2001-4-12', 2, 2) 
GO

INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Олег', 'Кононов','Ильяович', 1,'2000-1-3', 3, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Виталий', 'Рябов','Богданович', 1,'2000-1-9', 3, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Ростислав', 'Потапов','Константинович', 1,'2000-1-12', 3, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Рудольф', 'Пестов','Евгеньевич', 1,'2000-1-12', 3, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Соломон', 'Беспалов','Семенович', 1,'2000-1-12', 3, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Глория', 'Кулагина','Сергеевна', 2,'2001-1-3', 3, 2) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Лариса', 'Евдокимова','Геннадьевна', 2,'2001-1-6', 3, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Августа', 'Шубина','Святославовна', 2,'2001-1-9', 3, 2)
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Джульетта', 'Блохина','Мартыновна', 2,'2001-1-12', 3, 1) 
GO
INSERT INTO [dbo].[Students] ([Name],[Surname],[MiddleName],[GenderId],[DateofBirth],[GroupId],[FormOfEducationId]) VALUES  ('Харитина', 'Королёва','Геласьевна', 2,'2001-3-12', 3, 2)
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,6,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,6,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,7) 
GO

