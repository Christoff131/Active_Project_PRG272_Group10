CREATE TABLE Module
(
ModuleCode int NOT NULL,
ModuleName varchar(50) NOT NULL,
ModuleDescription varchar(200) NULL,
OnlineResources varchar(200) NULL

);

Insert INTO Module(ModuleCode, ModuleName, ModuleDescription, OnlineResources)
Values 
(1,'Programming 271', 'Intermediate course teaching C# programming', 'stuff'),
(2,'Programming 272', 'Intermediate course teaching C# programming', 'more stuff'),
(3,'Web Programming 271', 'Intermediate course teaching Web programming & javascript', 'youtube'),
(4,'Statistics 271', 'Intermediate course teaching how to use Statistics', 'Excel'),
(5,'Project Management 271', 'Intermediate course teaching Project Management Skills to Students', 'Research'),
(6,'Linear Programming 171', 'Beginner course teaching Linear Programming', 'youtube'),
(7,'Ethics 271', 'Intermediate course teaching ethics and philosophy to students', 'contemplation'),
(8,'Database Development 271', 'Intermediate course teaching Database Development & MySQL', 'Microsoft SQL Server Management Studio'),
(9,'INF271', 'Intermediate course teaching Information Systems', 'Youtube'),
(10,'SWT271', '', 'more stuff'),
(11,'Cloud Native Applications 271', 'Introductory course teaching cloud native applications', 'lots of research & youtube');
