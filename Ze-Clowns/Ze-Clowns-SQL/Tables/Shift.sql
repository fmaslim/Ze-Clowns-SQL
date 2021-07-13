--1. ShiftID tinyint PK
--2. Name varchar(50) not null
--3. StartTime time(7) not null
--4. EndTime time(7) not null
--5. DateAdded datetime not null
--6. DateUpdated datetime


CREATE TABLE [dbo].[Shift]
(
	[ShiftID] tinyint NOT NULL PRIMARY KEY,
	[Name] varchar(50) not null,
	StartTime time(7) not null,
	EndTime time(7) not null,
	DateAdded datetime not null,
	DateUpdated datetime not null
)
