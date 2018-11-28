/*	This file contains all the procedures for the web application
	to use to access the data in the database						*/

-- Procedure to get customer information for display and computation --
CREATE PROCEDURE Demo.GetCustomerInformation
	@CustomerId INT = 0
AS

SELECT C.AddressId, C.FirstName, C.LastName, C.PhoneNumber, C.Email
FROM Demo.Customer C
WHERE C.CustomerId = @CustomerId

-- Procedure to get car features --
CREATE PROCEDURE Demo.GetCarFeatures
	@CarId INT = 0
AS

SELECT F.Name
FROM Demo.Features F
	INNER JOIN Demo.CarFeatures CF ON F.FeatureId = CF.FeatureId
WHERE CF.CarId = @CarId