/*	This file contains all the procedures for the web application
	to use to access the data in the database						*/

/*---------------------------------------------------------------------------------
Customer Information
-- Procedure to get customer information for display and computation --
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetCustomerInformation;
GO

CREATE PROCEDURE Demo.GetCustomerInformation
	@CustomerId INT = 0
AS

SELECT C.AddressId, C.FirstName, C.LastName, C.PhoneNumber, C.Email, A.Street, A.Street2, A.City, A.Zipcode
FROM Demo.Customer C
	INNER JOIN Demo.[Address] A ON C.AddressId = A.AddressId
WHERE C.CustomerId = @CustomerId
GO

EXEC Demo.GetCustomerInformation @CustomerId = 1;
GO 

/*---------------------------------------------------------------------------------
Customer Information
-- Procedure to get car features --
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetCarFeatures;
GO

CREATE PROCEDURE Demo.GetCarFeatures
	@CarId INT = 0
AS

SELECT F.[Name]
FROM Demo.Feature F
	INNER JOIN Demo.CarFeatures CF ON F.FeatureId = CF.FeatureId
WHERE CF.CarId = @CarId
GO

EXEC Demo.GetCarFeatures @CarId = 6;
GO 

/*---------------------------------------------------------------------------------
List Employee
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.ListEmployee;
GO

CREATE PROCEDURE Demo.ListEmployee

AS

SELECT 
	E.FirstName,
	E.LastName
FROM Demo.Employee E;
GO

/*---------------------------------------------------------------------------------
Car Search 
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarSearch;
GO

CREATE PROCEDURE Demo.CarSearch
	@Make NVARCHAR(32) = N'%',
	@Model NVARCHAR(32) = N'%',
	@Color NVARCHAR(16) = N'%',
	@Milage INT = NULL,
	@OwnerCnt INT = NULL,
	@AskPrice INT = NULL
AS

SELECT *
FROM Demo.Car C
WHERE C.Make LIKE @Make
	AND C.Model LIKE @Model
	AND C.Color LIKE @Color
	AND C.Milage <= ISNULL(@Milage, C.Milage) --https://stackoverflow.com/questions/10622260/how-do-you-query-an-int-column-for-any-value
	AND C.OwnerCnt <= ISNULL(@OwnerCnt, C.OwnerCnt)
	AND C.AskPrice <= ISNULL(@AskPrice, C.AskPrice)
GO

EXEC Demo.CarSearch 
	@Make = N'Ford',
	@Color = N'Teal';
GO 

SELECT * FROM Demo.Car;

/*---------------------------------------------------------------------------------
Employee Performance
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarSearch;
GO

CREATE PROCEDURE Demo.CarSearch
   @EmployeeId INT = 0,
   --@FirstNamePattern NVARCHAR(32) = N'%',
   --@LastNamePattern NVARCHAR(32) = N'%',
   @StartDate DATETIMEOFFSET = N'2000-01-01',
   @EndDate DATETIMEOFFSET = N'2999-12-31'
AS

SELECT 
	E.EmployeeId AS EmployeeID, 
	E.FirstName AS FirstName, 
	E.LastName AS LastName,
	E.PhoneNumber AS PhoneNumber,
	SUM(S.SaleAmount) AS TotalSales
FROM Demo.Employee E
	INNER JOIN Demo.Sales S ON E.EmployeeId = S.EmployeeId
WHERE E.EmployeeId = @EmployeeId
	--AND E.FirstName LIKE @FirstNamePattern
	--AND E.LastName LIKE @LastNamePattern
	AND S.CreatedOn BETWEEN @StartDate AND @EndDate
GROUP BY E.EmployeeId;
GO

/*---------------------------------------------------------------------------------
Dealership Performance
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.DealershipPerformance;
GO

CREATE PROCEDURE Demo.DealershipPerformance
	@DealershipPattern NVARCHAR(32) = N'%',
	@StartDate DATETIMEOFFSET = '2000-01-01',
	@EndDate DATETIMEOFFSET = '2999-12-31'
AS

SELECT 
	D.DealershipId AS DealershipId,
	D.AddressId AS DealershipAddress,
	D.PhoneNumber AS DealershipPhoneNumber,
	SUM(S.SaleAmount) AS TotalSales
FROM
	Demo.Employee E
	JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	JOIN Demo.Sales S ON E.EmployeeId = S.EmployeeId
WHERE D.[Name] LIKE @DealershipPattern
GROUP BY D.DealershipId, D.AddressId, D.PhoneNumber;
GO

/*---------------------------------------------------------------------------------
Car Information
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarInformation;
GO

CREATE PROCEDURE Demo.CarInformation
	@CarId INT = 0,
	@DealershipId INT = 0 
AS 

SELECT 
	C.CarId AS CarId,
	C.[Year] AS [Year],
	C.Make AS Make,
	C.Model AS Model,
	C.Color AS Color,
	C.Milage AS Mileage,
	C.OwnerCnt AS OwnerCount,
	C.AskPrice AS AskPrice
FROM
	Demo.Car C
WHERE C.CarId = @CarId
GO

EXEC Demo.CarInformation 652

/*---------------------------------------------------------------------------------
Cars With X Features
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarWithFeature;
GO

CREATE PROCEDURE Demo.CarWithFeature
	@Feature1 INT = 0,
	@Feature2 INT = 0,
	@Feature3 INT = 0,
	@Feature4 INT = 0,
	@Feature5 INT = 0,
	@Feature6 INT = 0,
	@Feature7 INT = 0,
	@Feature8 INT = 0,
	@Feature9 INT = 0,
	@Feature10 INT = 0,
	@Feature11 INT = 0,
	@Feature12 INT = 0,
	@Feature13 INT = 0,
	@Feature14 INT = 0,
	@Feature15 INT = 0,
	@Feature16 INT = 0,
	@Feature17 INT = 0,
	@Feature18 INT = 0,
	@Feature19 INT = 0,
	@Feature20 INT = 0
AS 

SELECT C.CarId, C.Make, C.Model, C.Color, C.Milage
FROM Demo.Car C
	INNER JOIN Demo.CarFeature CF ON C.CarId = CF.CarId 
WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature2, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature3, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature4, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature5, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature6, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature7, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature8, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature9, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature10, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature11, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature12, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature13, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature14, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature15, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature16, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature17, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature18, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature19, CF.FeatureId)
	OR CF.FeatureId = ISNULL(@Feature20, CF.FeatureId)
GROUP BY C.CarId, C.Make, C.Model, C.Color, C.Milage
GO

EXEC Demo.CarWithFeature 
	@Feature1 = 1,
	@Feature2 = 2;
GO

/*---------------------------------------------------------------------------------
Get Employees - From Dealership (Duplicate of above?)
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetEmployees;
GO

CREATE PROCEDURE Demo.GetEmployees
	@DealershipId INT = 0
AS

SELECT E.EmployeeId, E.Email, E. Salary, E.Title, E.PhoneNumber, A.Street, A.Street2, A.City, A.Zipcode
FROM Demo.Employee E
	INNER JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	INNER JOIN Demo.[Address] A ON E.AddressId = A.AddressId
WHERE E.DealershipId = @DealershipId
GROUP BY E.EmployeeId, E.Email;
GO

/*---------------------------------------------------------------------------------
Get the top X performing salespeople
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetTopEmployees;
GO

CREATE PROCEDURE Demo.GetTopEmployees
	@EmployeeNumber INT = 0
AS

SELECT TOP(@EmployeeNumber) E.EmployeeId, E.FirstName, E.LastName, COUNT(DISTINCT S.SaleId) AS NumberSales, SUM(S.SaleAmount) AS SalesVolume
FROM Demo.Employee E
	INNER JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
GROUP BY E.EmployeeId, E.FirstName, E.LastName
ORDER BY SalesVolume DESC

EXEC Demo.GetTopEmployees
	@EmployeeNumber = 10
GO