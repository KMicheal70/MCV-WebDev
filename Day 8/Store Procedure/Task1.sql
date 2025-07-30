
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

 SELECT * FROM Employees;

IF OBJECT_ID('Sec_Max', 'P') IS NOT NULL
BEGIN
    DROP Procedure Sec_Max;
END
GO
 GO
 CREATE PROCEDURE Sec_Max
 AS
	SELECT MAX(Salary) from Employees where Salary  < (SELECT MAX(Salary) FROM Employees);
 GO

 Exec Sec_Max;
