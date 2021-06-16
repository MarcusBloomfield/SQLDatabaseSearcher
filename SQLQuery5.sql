CREATE PROCEDURE [dbo].[SearchForUser]
	@Search nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	select *
	from dbo.UserInformation
	where FirstName LIKE '%'+@Search+'%' or LastName LIKE '%'+@Search+'%' or Email LIKE '%'+@Search+'%';

END
