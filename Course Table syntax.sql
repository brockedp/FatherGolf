CREATE TABLE Courses(
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
 Name nvarchar(150) NOT NULL,
 Par int NOT NULL,
 FrontNinePar int NOT NULL,
 BackNinePar int NOT NULL,
 Slope int NOT NULL,
 Address nvarchar(300),
 PhoneNumber nvarchar(30)
);