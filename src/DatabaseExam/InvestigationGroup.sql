CREATE TABLE [dbo].[InvestigationGroup]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(100) NOT NULL, 
    [Number] VARCHAR(30) NOT NULL, 
    [Link] VARCHAR(200) NOT NULL, 
    [InvestigationCenterId] INT NOT NULL, 
    [UniversityId] INT NOT NULL, 
    [DepartmentId] INT NOT NULL
)
