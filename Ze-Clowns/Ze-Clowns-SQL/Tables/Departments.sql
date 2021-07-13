
--1. DepartmentID smallint PK
--2. Name varchar(50) not null
--3. GroupName varchar(50) not null
--4. DateAdded datetime not null
--5. DateUpdated datetime



create table Departments (
	DepartmentID smallint primary key,
	[Name] varchar(50),
	groupName varchar(50) not null,
	DateAdded datetime not null,
	DateUpdated datetime
);

