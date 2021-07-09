
--1. ProductID int
--2. ProductName varchar(200)
--3. ProductDescription varchar(500)
--4. ProductActive bit
--5. AddedBy varchar(10)
--6. UpdatedBy varchar(10)
--7. DateAdded datetime
--8. DateUpdated datetime

use Testingdb;

CREATE TABLE [dbo].[Products]
(
	[ProductID] INT NOT NULL PRIMARY KEY,
	ProductName varchar(200),
	ProductDescription varchar(500),
	Active bit,
	Addedby varchar(10),
	Updatedby varchar(10),
	DateAdded datetime,
	DateUpdated datetime

);


