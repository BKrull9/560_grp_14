/*	This file contains all the procedures for the web application
	to use to access the data in the database						*/

/*---------------------------------------------------------------------------------
Customer Information
-- Procedure to get customer information for display and computation --
---------------------------------------------------------------------------------*/
CREATE PROCEDURE Demo.GetCustomerInformation
	@CustomerId INT = 0
AS

SELECT C.AddressId, C.FirstName, C.LastName, C.PhoneNumber, C.Email
FROM Demo.Customer C
WHERE C.CustomerId = @CustomerId
GO

/*---------------------------------------------------------------------------------
Customer Information
-- Procedure to get car features --
---------------------------------------------------------------------------------*/
CREATE PROCEDURE Demo.GetCarFeatures
	@CarId INT = 0
AS

SELECT F.[Name]
FROM Demo.Feature F
	INNER JOIN Demo.CarFeatures CF ON F.FeatureId = CF.FeatureId
WHERE CF.CarId = @CarId
GO

/*---------------------------------------------------------------------------------
List Employee
---------------------------------------------------------------------------------*/
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

/*---------------------------------------------------------------------------------
Employee Performance
---------------------------------------------------------------------------------*/
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
CREATE PROCEDURE Demo.CarInformationCars
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
GROUP BY C.CarId, C.[Year], C.Make, C.Model, C.Color, C.Milage, C.OwnerCnt, C.AskPrice;
GO
/*---------------------------------------------------------------------------------
Get Employees - From Dealership (Duplicate of above?)
---------------------------------------------------------------------------------*/
CREATE PROCEDURE Demo.GetEmployees
	@DealershipId INT = 0
AS

SELECT E.EmployeeId, E.[Address], E.Email, E. Salary, E.Title, E.PhoneNumber
FROM Demo.Employee E
	JOIN Demo.Dealership D ON E.DealershipId = D.DealershipId
WHERE E.DealershipId = @DealershipId
GROUP BY E.EmployeeId, E.[Address], E.Email, E. Salary, E.Title, E.PhoneNumber;
GO