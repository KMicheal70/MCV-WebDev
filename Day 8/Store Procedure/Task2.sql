
USE x;
IF OBJECT_ID('Employees', 'U') IS NOT NULL
BEGIN
    DROP TABLE Employees;
END
GO
CREATE TABLE Employees(
	ID int IDENTITY(1,1) PRIMARY KEY,
	FName varchar(255) NOT NULL,
	Salary Float(25)
);
Insert INTO Employees ( FName, Salary)
VALUES ('Karim',20000), 
 ('Ahmed',30000),  
 ('Ali',25000),
 ('Robin',200000);
IF OBJECT_ID('Salary_All', 'P') IS NOT NULL
BEGIN
    DROP Procedure  Salary_All;
END
 GO
 GO
 CREATE PROCEDURE Salary_All
 AS
	UPDATE Employees
	SET Salary *= 1.2
 GO

 Exec Salary_All;

 Select * FROM Employees;