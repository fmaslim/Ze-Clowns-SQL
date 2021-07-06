--Create Employee table the following columns:
--1. EmployeeID int
--2. EmployeeFirstName varchar(15) not null
--3. EmployeeLastName varchar(15) not null
--4. EmployeePhoneNumber varchar(15)
--5. EmployeeAddress1 varchar(50) not null
--6. EmployeeAddress2 varchar(50)
--7. EmployeeCity varchar(20)
--8. EmployeeState varchar(10)
--9. EmployeeZipcode varchar(10)

use Testingdb;

create table Employee (
	EmployeeID int,
	EmployeeFirstName varchar(15)  not null,
	EmployeeLastName varchar(15) not null,
	EmployeePhoneNumber varchar(15),
	EmployeeAddress1 varchar(50) not null,
	EmployeeAddress2 varchar(50),
	EmployeeCity varchar(20),
	EmployeeState varchar(10),
	EmployeeZipcode varchar(10)

);
