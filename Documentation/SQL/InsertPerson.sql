SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 11/03/2020
-- Description:	Insert into students
-- =============================================
CREATE PROCEDURE dbo.InsertPerson
	-- Add the parameters for the stored procedure here
	@Firstname nvarchar(20),
	@Lastname nvarchar(20),
	@Email nvarchar(40),
	@Phonenumber nvarchar(13),
	@RoleId bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Person VALUES (@Firstname, @Lastname, @Email, @Phonenumber, @RoleId)
END