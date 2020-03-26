-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 26/03
-- Description:	Get all Supervisors
-- =============================================
CREATE PROCEDURE GetAllSupervisors 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Person.PersonID, Person.Firstname, Person.Lastname, Person.Phonenumber, Person.Email FROM Person
	JOIN EventJunction ON EventJunction.PersonID = Person.PersonID
	WHERE Person.[Role] = 1;
END
GO
