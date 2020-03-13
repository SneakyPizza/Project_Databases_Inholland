
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 10/03/2020
-- Description: Get all Student information
-- =============================================
USE [ProjectSomeren]
GO
CREATE PROCEDURE dbo.GetAllPersonInfo
	-- Add the parameters for the stored procedure here
	@RoleId bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.Person WHERE Person.Role = @RoleId
END
GO
