

CREATE PROCEDURE [dbo].[AddNewUser] (@FirstName nvarchar(50) , @LastName nvarchar(50), @Email nvarchar(50), @Password nvarchar(50))
AS
BEGIN
	INSERT INTO UserInformation(FirstName, LastName, Email, Password)
	VALUES(@FirstName, @LastName, @Email, @Password)
END
