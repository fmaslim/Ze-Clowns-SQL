use Testingdb;

create table CustomerInfo (
	CustomerID int,
	CustomerFirstName  varchar(50),
	CustomerLastName   varchar(50),
	CustomerAddress1   varchar(100),
	CustomerAddress2   varchar(100),
	CustomerCity       varchar(50),
	CustomerZip        tinyint,
	CustomerCountry    varchar(50)
);


create table Products (
	Product_ID int,
	ProductName varchar(50),
	ProductDesc varchar(250),
	ProductPrice int
);

