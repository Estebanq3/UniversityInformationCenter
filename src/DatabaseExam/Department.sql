CREATE TABLE [dbo].[Department]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(200) NOT NULL, 
    [UniversityId] INT NOT NULL
)
