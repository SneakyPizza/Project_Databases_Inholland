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
ALTER PROCEDURE GetAllEventsBetween		

	@beginDate datetime,
	@endDate datetime

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	SELECT [Event].EventID, [Event].[Date], [Event].[Description], Activity.[Name], Person.PersonID FROM [Event]
	JOIN [Activity] ON Activity.ActivityID = [Event].ActivityID
	JOIN [Person] ON [Person].PersonID = [Event].SupervisorID
	WHERE [Event].[Date] BETWEEN @beginDate AND @endDate;
END
GO
