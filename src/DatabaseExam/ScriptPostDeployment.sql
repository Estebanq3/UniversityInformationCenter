MERGE INTO [dbo].[University] AS TARGET
USING 
(VALUES 
(N'North Carolina State University', N'https://www.ncsu.edu/',N'EEUU'),
(N'Universidad Politécnica de Valencia', 'http://www.upv.es/en','España'),
(N'Universidade Federal do Rio de Janeiro', N'https://ufrj.br/es/',N'Brasil'),
(N'Instituto Tecnológico de Costa Rica ', N'https://www.tec.ac.cr/',N'Costa Rica'),
(N'Universidad Nacional de Costa Rica', N'https://www.una.ac.cr/',N'Costa Rica'),
(N'Universidad Estatal a Distancia de Costa Rica', N'https://www.uned.ac.cr/ec',N'Costa Rica'),
(N'Universidad de Costa Rica', N'https://www.ucr.ac.cr/',N'Costa Rica')
)
AS SOURCE ([Name],[Link],[Country]) ON TARGET.[Name] = SOURCE.[Name]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Name],[Link],[Country]) VALUES ([Name],[Link],[Country]);


MERGE INTO [dbo].[Department] AS TARGET
USING 
(VALUES 
(N'Department of Computer Science', 1),
(N'Escuela Técnica Superior de Ingeniería Informática', 2),
(N'COPPE - Programa de Engenharia de Sistemas e Computação', 3),
(N'Unidad de Ingeniería en Computación', 4),
(N'Escuela de Computación e informática', 5),
(N'Escuela de Ciencias Exactas y Naturales', 6),
(N'Escuela de Computacion e Informatica', 7)
)
AS SOURCE ([Name],[UniversityId]) ON TARGET.[Name] = SOURCE.[Name]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Name],[UniversityId]) VALUES ([Name],[UniversityId]);



MERGE INTO [dbo].[InvestigationCenter] AS TARGET
USING 
(VALUES 
(N'Center North Carolina', N'https://www.unc.edu/research-innovation/', 1,1),
(N'Center Carolina 2', N'https://www.unc.edu/research-innovation/', 1,1),
(N'Center Valencia', N'https://www.upv.es/organizacion/departamentos/index-es.html',2,2),
(N'Center Rio', N'https://ufrj.br/es/',3,3),
(N'Center TEC', N'https://www.tec.ac.cr/centros-investigaci%C3%B3n',4,4),
(N'Center UNA', N'https://www.investigacion.una.ac.cr/',5,5),
(N'Center UNED', N'https://www.uned.ac.cr/ecen/comiex-ecen',6,6),
(N'CITIC', N'https://citic.ucr.ac.cr/',7,7)
)
AS SOURCE ([Name],[Link],[UniversityId],[DepartmentId]) ON TARGET.[Name] = SOURCE.[Name]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Name],[Link],[UniversityId],[DepartmentId]) VALUES ([Name],[Link],[UniversityId],[DepartmentId]);



MERGE INTO [dbo].[InvestigationGroup] AS TARGET
USING 
(VALUES 
(N'Grupo de investigación en ingeniería de software empírica ', N'+506 2511-0000', N'https://citic.ucr.ac.cr/esegroup', 8,7,7),
(N'Realsearch group', N'+506 2511-111', N'https://realsearchgroup.github/', 1,1,1),
(N'Real-world Artificial Intelligence for Software Engineering', N'+506 2511-2222', N'http://menzies.us/', 1,1,1),
(N'Computer Science', N'+506 2511-3737', N'http://menzies.us/', 2,1,1),
(N'Centro de Investigación en Métodos de Producción de Software (PROS)', N'+506 2511-3333', N'http://www.pros.upv.es/', 3,2,2),
(N'Experimental Software Engineering Group', N'+506 2511-4444', N'http://lens-ese.cos.ufrj.br/ese/', 4,3,3),
(N'Protec', N'+506 2511-4444', N'https://www.tec.ac.cr/', 5,4,4),
(N'Programa de Bachillerato y Maestría ', N'+506 2511-5555', N'https://www.una.ac.cr/', 6,5,5),
(N'Programa de Licenciaturas', N'+506 2511-66665', N'https://www.uned.ac.cr/ecen', 7,6,6),
(N'Interaccion Humano Computador', N'+506 2525-0000', N'https://citic.ucr.ac.cr/esegroup', 8,7,7)
)
AS SOURCE ([Name],[Number],[Link],[InvestigationCenterId],[UniversityId],[DepartmentId]) ON TARGET.[Name] = SOURCE.[Name]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Name],[Number],[Link],[InvestigationCenterId],[UniversityId],[DepartmentId]) VALUES ([Name],[Number],[Link],[InvestigationCenterId],[UniversityId],[DepartmentId]);



MERGE INTO [dbo].[UniversityCollaborations] AS TARGET
USING 
(VALUES 
	(7,1,1,2),
	(7,2,1,3),
	(7,3,1,4),
	(7,4,1,5),
	(7,5,1,6),
	(7,6,1,7),
	(7,3,10,7)
)
AS SOURCE ([Id],[CollaboratorUniversity],[UniversityGroup],[CollaboratorGroupUniversity]) ON TARGET.[Id] = SOURCE.[Id]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Id],[CollaboratorUniversity],[UniversityGroup],[CollaboratorGroupUniversity]) VALUES ([Id],[CollaboratorUniversity],[UniversityGroup],[CollaboratorGroupUniversity]);
