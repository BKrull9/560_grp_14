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
	INNER JOIN Demo.CarFeature CF ON F.FeatureId = CF.FeatureId
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
	INNER JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
WHERE E.EmployeeId = @EmployeeId
	--AND E.FirstName LIKE @FirstNamePattern
	--AND E.LastName LIKE @LastNamePattern
	AND S.SaleDate BETWEEN @StartDate AND @EndDate
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
	JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
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
	@Feature1 INT = null,
	@Feature2 INT = null,
	@Feature3 INT = null,
	@Feature4 INT = null,
	@Feature5 INT = null,
	@Feature6 INT = null,
	@Feature7 INT = null,
	@Feature8 INT = null,
	@Feature9 INT = null,
	@Feature10 INT = null,
	@Feature11 INT = null,
	@Feature12 INT = null,
	@Feature13 INT = null,
	@Feature14 INT = null,
	@Feature15 INT = null,
	@Feature16 INT = null,
	@Feature17 INT = null,
	@Feature18 INT = null,
	@Feature19 INT = null,
	@Feature20 INT = null
AS 

SELECT C.CarId, C.Make, C.Model, C.Color, C.Milage--, CF.FeatureId
FROM Demo.Car C
	INNER JOIN Demo.CarFeature CF ON C.CarId = CF.CarId 
WHERE C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId =ISNULL( @Feature1, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature2, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature3, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature4, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature5, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature6, CF.FeatureId) )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature7, CF.FeatureId) )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature8, CF.FeatureId) )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature9, CF.FeatureId) )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	--AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature20, CF.FeatureId) )
GROUP BY C.CarId, C.Make, C.Model, C.Color, C.Milage
GO

EXEC Demo.CarWithFeature 
	@Feature1 = 2,
	@Feature2 = 7,
	@Feature3 = 8;
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

/*---------------------------------------------------------------------------------
Get the total value of the in-stock cars
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetStockTotalValue;
GO

CREATE PROCEDURE Demo.GetStockTotalValue
AS

SELECT SUM(C.AskPrice)
FROM Demo.Car C
WHERE NOT EXISTS
(
	SELECT S.CarId
	FROM Demo.Sale S
	WHERE S.CarId = C.CarId
)

EXEC Demo.GetStockTotalValue
GO