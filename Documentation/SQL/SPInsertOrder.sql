USE [ProjectDatabase]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 27/03/20
-- Description:	Insert Order
-- =============================================
CREATE PROCEDURE InsertOrder
	-- Add the parameters for the stored procedure here
	@personId int,
	@timeStamp datetime,
	@amount int,
	@productId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [Order] (PersonID, Amount, [Order].[Timestamp], ProductID) VALUES ( @personId, @amount, @timeStamp, @productId)


END
GO
