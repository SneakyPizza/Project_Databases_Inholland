USE [ProjectDatabase]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 27/03/20
-- Description:	Insert Activity
-- =============================================
CREATE PROCEDURE InsertActivity
	-- Add the parameters for the stored procedure here
	@name nvarchar(20),
	@dateTime datetime,
	@desc nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [Activity] (Name, Date, Description) VALUES (@name, @dateTime, @desc); 
END
GO
