/*	This file contains all the procedures for the web application
	to use to access the data in the database						*/

CREATE PROCEDURE Demo.GetCustomerInformation
	@CustomerID INT = 0
AS

SELECT C.AddressID, C.FirstName, C.LastName, C.PhoneNumber, C.Email
FROM Demo.Customer C
WHERE C.CustomerID = @CustomerID