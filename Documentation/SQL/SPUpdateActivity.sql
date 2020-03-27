USE [ProjectDatabase]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 27/03/20
-- Description:	Update Activity
-- =============================================
CREATE PROCEDURE UpdateActivity
	-- Add the parameters for the stored procedure here
	@name nvarchar(20),
	@dateTime datetime,
	@desc nvarchar(20),
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	UPDATE [Activity] SET Name = @name, Date = @dateTime, Description = @desc WHERE ActivityID = @id; 
END
GO
