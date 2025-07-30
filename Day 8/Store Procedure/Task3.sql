
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
 ('Ahmed',2000),  
 ('Ali',570000),
 ('Robin',200000),
  ('George',35000);
IF OBJECT_ID('Salary_UPDATE', 'P') IS NOT NULL
BEGIN
    DROP Procedure Salary_UPDATE;
END
 GO
CREATE PROCEDURE Salary_UPDATE
AS
BEGIN
    UPDATE Employees
    SET Salary *= 1.2
    WHERE Salary <= 30000;

    UPDATE Employees
    SET Salary *= 1.5
    WHERE Salary > 30000 AND Salary <= 190000;

    UPDATE Employees
    SET Salary *= 2
    WHERE Salary > 190000;
END
GO

exec Salary_UPDATE;

Select * from Employees;