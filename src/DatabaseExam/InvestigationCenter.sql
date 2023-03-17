CREATE TABLE [dbo].[InvestigationCenter]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Link] VARCHAR(200) NOT NULL, 
    [UniversityId] INT NOT NULL, 
    [DepartmentId] INT NOT NULL
)
