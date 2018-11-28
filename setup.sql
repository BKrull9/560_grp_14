--CREATE SCHEMA Demo
--GO

DROP TABLE IF EXISTS Demo.Sales;
DROP TABLE IF EXISTS Demo.Employee;
DROP TABLE IF EXISTS Demo.CarFeatures;
DROP TABLE IF EXISTS Demo.Car;
DROP TABLE IF EXISTS Demo.Dealership;
DROP TABLE IF EXISTS Demo.Customer;
DROP TABLE IF EXISTS Demo.[Address];
DROP TABLE IF EXISTS Demo.Feature;
GO

CREATE TABLE Demo.Feature
(
   FeatureId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   [Name] NVARCHAR(32) NOT NULL,
);

CREATE TABLE Demo.[Address]
(
	AddressId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	City NVARCHAR(32) NOT NULL,
	Street NVARCHAR(32) NOT NULL,
	Street2 NVARCHAR(32) NULL,
	Zipcode INT NOT NULL,
);

CREATE TABLE Demo.Dealership
(
	DealershipId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	AddressId INT NOT NULL REFERENCES Demo.[Address](AddressId),
	PhoneNumber NVARCHAR(16) NOT NULL,
);

CREATE TABLE Demo.Car
(
	CarId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	DealershipId INT NOT NULL REFERENCES Demo.Dealership(DealershipId),
	[Year] INT NOT NULL,
	Make NVARCHAR(16) NOT NULL,
	Model NVARCHAR(32) NOT NULL,
	Color NVARCHAR(16) NOT NULL,
	Milage INT NOT NULL,
	OwnerCnt INT NOT NULL,
	AskPrice INT NOT NULL,
);

CREATE TABLE Demo.CarFeatures
(
	CarId INT NOT NULL REFERENCES Demo.Car(CarId),
	FeatureId INT NOT NULL REFERENCES Demo.Feature(FeatureId) UNIQUE,

	PRIMARY KEY(CarId, FeatureId)
);

CREATE TABLE Demo.Employee
(
	EmployeeId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	AddressId INT NOT NULL REFERENCES Demo.[Address](AddressId),
	DealershipId INT NOT NULL REFERENCES Demo.Dealership(DealershipId),
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL,
	Email NVARCHAR(128) NOT NULL UNIQUE,
	Salary INT NOT NULL,
	Title NVARCHAR(128) NOT NULL,
	PhoneNumber NVARCHAR(32) NOT NULL,
);

CREATE TABLE Demo.Customer
(
	CustomerId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	AddressId INT NOT NULL REFERENCES Demo.[Address](AddressId),
	FirstName NVARCHAR(16) NOT NULL,
	LastName NVARCHAR(16) NOT NULL,
	PhoneNumber NVARCHAR(16) NOT NULL,
	Email NVARCHAR(128) NOT NULL UNIQUE,
);

CREATE TABLE Demo.Sales
(
	SaleId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	EmployeeId INT NOT NULL REFERENCES Demo.Employee(EmployeeId),
	CustomerId INT NOT NULL REFERENCES Demo.Customer(CustomerId),
	CarId INT NOT NULL REFERENCES Demo.Car(CarId),
	SaleAmount INT NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL
      CONSTRAINT [DF_Demo_Sale_CreatedOn] DEFAULT(SYSDATETIMEOFFSET()),
);

--TODO: Name FK References and Unique keys