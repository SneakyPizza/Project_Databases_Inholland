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
-- Description:	Insert new Event
-- =============================================
CREATE PROCEDURE InsertNewEvent 

	@EventDate datetime,
	@EventName nvarchar,
	@SupervisorId int,
	@ActivityId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

	SET NOCOUNT ON;
	ALTER TABLE [Event] NOCHECK CONSTRAINT ALL;
	ALTER TABLE [EventJunction] NOCHECK CONSTRAINT ALL;
    -- Insert statements for procedure here
	INSERT INTO [Event] (Date, Description, SupervisorID,ActivityID) 
	VALUES (@EventDate, @EventName, @SupervisorId,@ActivityId);

	ALTER TABLE [Event] CHECK CONSTRAINT ALL;
	ALTER TABLE [EventJunction] CHECK CONSTRAINT ALL;
END
GO
