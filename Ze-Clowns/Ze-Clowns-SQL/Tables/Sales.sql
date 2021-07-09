--1. SalesID      int Primary Key
--2. ProductID int ForeignKey(Products.ProductID)
--3. Count         int
--4. Total            money
--5. EmployeeID int ForeignKey(Employees.EmployeeID)
--6. SalesFinal     bit
--7. DateAdded    datetime
--8. DateUpdated datetime




CREATE TABLE [dbo].[Sales]
(
	[SalesID] INT NOT NULL PRIMARY KEY,
	ProductID int NOT NULL foreign key references Products(ProductID),
	[Count] int NOT NULL,
	Total money NOT NULL,
	EmployeeID  int NOT NULL foreign key references Employee(EmployeeID),
    SalesFinal bit,
	DateAdded datetime NOT NULL,
	DateUpdated datetime

)
