/*	This file contains all the procedures for the web application
	to use to access the data in the database						*/

/*---------------------------------------------------------------------------------
Customer Information
-- Procedure to get customer information for display and computation --
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetCustomerInformation;
GO

CREATE PROCEDURE Demo.GetCustomerInformation
	@CustomerId INT = null,
	@FirstName NVARCHAR(32) = N'%',
	@LastName NVARCHAR(32) = N'%'

AS

SELECT C.CustomerId, C.FirstName, C.LastName, C.PhoneNumber, C.Email, A.Street, A.Street2, A.City, A.Zipcode
FROM Demo.Customer C
	INNER JOIN Demo.[Address] A ON C.AddressId = A.AddressId
WHERE C.CustomerId = ISNULL(@CustomerId, C.CustomerId)
	AND C.FirstName LIKE @FirstName
	AND C.LastName LIKE @LastName
GO


/*---------------------------------------------------------------------------------
Customer Purchases
-- Procedure to get customer information for display and computation --
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetCustomerPurchase;
GO

CREATE PROCEDURE Demo.GetCustomerPurchase
	@CustomerId INT = 0
AS

SELECT COUNT(DISTINCT S.SaleId) AS PurchaseCount, SUM(S.SaleAmount) AS PurchaseAmount
FROM Demo.Customer C
	INNER JOIN Demo.Sale S ON C.CustomerId = S.CustomerId
WHERE C.CustomerId = @CustomerId
GROUP BY C.CustomerId
GO


/*---------------------------------------------------------------------------------
GetCarFeatures
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


/*---------------------------------------------------------------------------------
List Employee
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.ListEmployee;
GO

CREATE PROCEDURE Demo.ListEmployee
	@EmployeeId INT = 0,
	@FirstName NVARCHAR(32) = N'%',
	@LastName NVARCHAR(32) = N'%'
AS

SELECT
	E.EmployeeId,
	E.FirstName,
	E.LastName,
	E.PhoneNumber,
	E.Email,
	D.[Name] AS DealershipName,
	A.Street,
	A.Street2,
	A.City,
	A.Zipcode,
	Count(S.SaleId) AS NumberOfSales,
	Sum(S.SaleAmount) AS TotalSales,
	E.DealershipId 	
FROM Demo.Employee E
	JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	JOIN Demo.[Address] A ON A.AddressId = E.AddressId
	JOIN Demo.Sale S ON S.EmployeeId = E.EmployeeId
WHERE E.EmployeeId = ISNULL(@EmployeeId, E.EmployeeId)
	AND E.FirstName Like @FirstName 
	AND E.LastName LIKE @LastName

GROUP BY E.FirstName, E.LastName, E.EmployeeId, E.PhoneNumber, E.Email, D.[Name], 
	A.Street, A.Street2, A.City, A.Zipcode, E.DealershipId; 
GO

/*---------------------------------------------------------------------------------
Car Search 
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarSearch;
GO

CREATE PROCEDURE Demo.CarSearch
	@Make NVARCHAR(32) = N'%',
	@Model NVARCHAR(32) = N'%',
	@Year int = 0,
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
	AND C.[Year] <= ISNULL(@Year, C.[Year])
	and c.IsSold = 0
GO

/*---------------------------------------------------------------------------------
Employee Performance
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.EmployeePerformance;
GO

CREATE PROCEDURE Demo.EmployeePerformance
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
GROUP BY E.EmployeeId, E.FirstName, E.LastName, E.PhoneNumber;
GO


/*---------------------------------------------------------------------------------
Dealership Performance
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.DealershipPerformance;
GO

CREATE PROCEDURE Demo.DealershipPerformance
	@DealershipId INT = 0,
	@StartDate DATETIMEOFFSET = '2000-01-01',
	@EndDate DATETIMEOFFSET = '2999-12-31'
AS

SELECT 
	Year(S.SaleDate),
	SUM(S.SaleAmount) AS TotalSales,
	count(distinct S.SaleId) as SaleCount,
	SUM(s.SaleAmount-c.AskPrice) as HaggleLoss
FROM
	Demo.Employee E
	JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
	inner join Demo.Car c on s.CarId = c.CarId
WHERE D.DealershipId = @DealershipId and s.SaleDate > @StartDate and s.SaleDate < @EndDate
GROUP BY D.DealershipId, D.[Name], D.AddressId, D.PhoneNumber, Year(S.SaleDate)
order by Year(S.SaleDate) desc
GO

/*---------------------------------------------------------------------------------
Dealership Performance
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.DealershipPerformance2;
GO

CREATE PROCEDURE Demo.DealershipPerformance2
	@DealershipId INT = 0,
	@StartDate DATETIMEOFFSET = '2000-01-01',
	@EndDate DATETIMEOFFSET = '2999-12-31'
AS

SELECT 
	Year(S.SaleDate),
	Month(S.SaleDate),
	SUM(S.SaleAmount) AS TotalSales,
	count(distinct S.SaleId) as SaleCount,
	SUM(s.SaleAmount-c.AskPrice) as HaggleLoss
FROM
	Demo.Employee E
	JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
	inner join Demo.Car c on s.CarId = c.CarId
WHERE D.DealershipId = @DealershipId and s.SaleDate > @StartDate and s.SaleDate < @EndDate
GROUP BY D.DealershipId, D.[Name], D.AddressId, D.PhoneNumber, Year(S.SaleDate), Month(S.SaleDate)
order by Year(S.SaleDate) desc, Month(S.SaleDate) desc
GO


/*---------------------------------------------------------------------------------
Car Information
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarInformation;
GO

CREATE PROCEDURE Demo.CarInformation
	@CarId INT = 0
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

SELECT C.CarId, C.Make, C.Model, C.[Year], C.AskPrice, C.Color, C.Milage, C.DealershipId, C.OwnerCnt, C.DealershipId
FROM Demo.Car C
	INNER JOIN Demo.CarFeature CF ON C.CarId = CF.CarId 
WHERE C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId =ISNULL(@Feature1, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature2, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature3, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature4, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature5, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature6, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature7, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature8, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature9, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature10, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature11, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature12, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature13, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature14, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature15, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature16, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature17, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature18, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature19, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature20, CF.FeatureId) )
	AND C.IsSold = 0
GROUP BY C.CarId, C.Make, C.Model, C.[Year], C.AskPrice, C.Color, C.Milage, C.DealershipId, C.OwnerCnt;
GO

/*---------------------------------------------------------------------------------
Get all features
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.ListFeature;
GO

CREATE PROCEDURE Demo.ListFeature
AS
SELECT F.[Name], F.FeatureId
FROM Demo.Feature F;


GO
/*---------------------------------------------------------------------------------
Get Employees - From Dealership (Duplicate of above?)
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetEmployees;
GO

CREATE PROCEDURE Demo.GetEmployees
	@DealershipId INT = 0
AS

SELECT E.EmployeeId, E.Email, E.Salary, E.Title, E.PhoneNumber, A.Street, A.Street2, A.City, A.Zipcode
FROM Demo.Employee E
	INNER JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
	INNER JOIN Demo.[Address] A ON E.AddressId = A.AddressId
WHERE E.DealershipId = @DealershipId;
GO


/*---------------------------------------------------------------------------------
Get the top X performing salespeople
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetTopEmployees;
GO

CREATE PROCEDURE Demo.GetTopEmployees
	@EmployeeNumber INT = 0,
	@DealershipId INT = 0
AS

SELECT TOP(@EmployeeNumber) Rank() over(order by SUM(S.SaleAmount) desc),  E.FirstName, E.LastName, E.EmployeeId, E.Email, a.City, COUNT(DISTINCT S.SaleId) AS NumberSales, SUM(S.SaleAmount) AS SalesVolume
FROM Demo.Employee E
	INNER JOIN Demo.Sale S ON E.EmployeeId = S.EmployeeId
	Inner Join Demo.[Address] a ON a.AddressId = e.AddressId
where E.DealershipId = @DealershipID
GROUP BY E.EmployeeId, E.FirstName, E.LastName, E.Email, a.City
ORDER BY SalesVolume DESC
GO

/*---------------------------------------------------------------------------------
Get the top X performing customers
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetTopCustomers;
GO

CREATE PROCEDURE Demo.GetTopCustomers
	@NumberOfCustomers INT = 0,
	@DealershipId INT = 0
AS

SELECT TOP(@NumberOfCustomers) Rank() over(order by SUM(S.SaleAmount) desc) AS [Rank],  
	C.FirstName, C.LastName, C.CustomerId, C.Email, 
	A.City, COUNT(DISTINCT S.SaleId) AS NumberPurchases, SUM(S.SaleAmount) AS PurchaseVolume
FROM Demo.Customer C
	INNER JOIN Demo.Sale S ON C.CustomerId = S.CustomerId
	Inner Join Demo.[Address] a ON a.AddressId = C.AddressId
	INNER JOIN Demo.Employee E ON E.EmployeeId = S.EmployeeId
where E.DealershipId = @DealershipID
GROUP BY C.CustomerId, C.FirstName, C.LastName, C.Email, a.City
ORDER BY PurchaseVolume DESC
GO

/*---------------------------------------------------------------------------------
Get all make types
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetMakeTypes;
GO

CREATE PROCEDURE Demo.GetMakeTypes

AS

SELECT DISTINCT C.Make
FROM Demo.Car C
GO

/*---------------------------------------------------------------------------------
Get the total value of the in-stock cars
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetStockTotalValue;
GO

CREATE PROCEDURE Demo.GetStockTotalValue
AS

SELECT SUM(C.AskPrice) AS TotalStockValue
FROM Demo.Car C
WHERE NOT EXISTS
(
	SELECT S.CarId
	FROM Demo.Sale S
	WHERE S.CarId = C.CarId
);

GO

/*---------------------------------------------------------------------------------
Update the Sale and Car tables for a purchase
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.MakePurchase;
GO

CREATE PROCEDURE Demo.MakePurchase
	@EmployeeEmail NVARCHAR(128),
	@CustomerEmail NVARCHAR(128),
	@SalePrice int,
	@CarId int
AS
insert into Demo.Sale(EmployeeId, CustomerId, CarId, SaleAmount)

Select e.EmployeeId, c.CustomerId, @CarID, @SalePrice
From Demo.Employee e
	cross join Demo.Customer c
where e.Email = @EmployeeEmail and c.Email = @CustomerEmail and e.DealershipId =
(
	select c.DealershipId 
	from Demo.Car c
	where c.CarId = @CarId
)

update Demo.Car 
set IsSold = 1
where CarId = @CarID and exists (
	select s.CarId
	from Demo.Sale s
	where s.CarId = @CarId
)

select CarId
from Demo.Sale 
where CarId = @CarId

go


/*---------------------------------------------------------------------------------
Get a certain employee's yearly performance 
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetYearlyPerformance;
GO

CREATE PROCEDURE Demo.GetYearlyPerformance
	@EmployeeId INT = 0,
	@StartDate DATETIMEOFFSET = '2000-01-01',
	@EndDate DATETIMEOFFSET = '2999-12-31'
AS

SELECT
	E.FirstName,
	E.LastName,
	E.EmployeeId,
	YEAR(S.SaleDate) AS [Year],
	Sum(S.SaleAmount) AS TotalSales,
	Count(DISTINCT S.SaleId) AS NumberOfSales,
	SUM(C.AskPrice)-SUM(S.SaleAmount) AS HaggleLoss	
FROM Demo.Employee E
	INNER JOIN Demo.Sale S ON S.EmployeeId = E.EmployeeId
	INNER JOIN Demo.Car C ON S.SaleId = C.CarId
WHERE E.EmployeeId = @EmployeeId AND S.SaleDate BETWEEN @StartDate AND @EndDate
GROUP BY E.FirstName,E.LastName, E.EmployeeId, YEAR(S.SaleDate)
ORDER BY YEAR(S.SaleDate) DESC
GO

/*---------------------------------------------------------------------------------
Get a certain employee's monthly performance 
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetMonthlyPerformance;
GO

CREATE PROCEDURE Demo.GetMonthlyPerformance
	@EmployeeId INT = 0,
	@StartDate DATETIMEOFFSET = '2000-01-01',
	@EndDate DATETIMEOFFSET = '2999-12-31'
AS

SELECT
	E.FirstName,
	E.LastName,
	E.EmployeeId,
	YEAR(S.SaleDate) AS Year,
	(SELECT DATENAME(month, DateAdd(month, MONTH(S.SaleDate), 0)-1)) AS [Month],
	Sum(S.SaleAmount) AS TotalSales,
	Count(DISTINCT S.SaleId) AS NumberOfSales,
	SUM(C.AskPrice)-SUM(S.SaleAmount) AS HaggleLoss	
FROM Demo.Employee E
	INNER JOIN Demo.Sale S ON S.EmployeeId = E.EmployeeId
	INNER JOIN Demo.Car C ON S.SaleId = C.CarId
WHERE E.EmployeeId = @EmployeeId AND S.SaleDate BETWEEN @StartDate AND @EndDate
GROUP BY E.FirstName,E.LastName, E.EmployeeId, MONTH(S.SaleDate), YEAR(S.SaleDate)
ORDER BY YEAR(S.SaleDate) DESC , MONTH(S.SaleDate) DESC
GO

/*---------------------------------------------------------------------------------
Get all dealership information for a given DealershipId
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetDealershipInformation;
GO

CREATE PROCEDURE Demo.GetDealershipInformation
	@DealershipId INT = 0
AS

SELECT *
FROM Demo.Dealership D
WHERE D.DealershipId = @DealershipId
GO

/*---------------------------------------------------------------------------------
Get all employee information for a given email
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.GetEmployeeFromEmail;
GO

CREATE PROCEDURE Demo.GetEmployeeFromEmail
	@email NVARCHAR(64) = ''
AS

SELECT *
FROM Demo.Employee E
WHERE E.Email = @email
GO