SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE [ProjectDatabase]
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 19/03
-- Description:	Get amount of customers/sales
-- =============================================
CREATE PROCEDURE FinancialRapport 
	-- Add the parameters for the stored procedure here
	@StartDate Datetime,
	@EndDate Datetime

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Order].Amount, ((Product.Price / 100) * Product.BTWPercentile) as includedprice, ([Order].Amount * [Product].Price)
	FROM [Order] 
	JOIN [Product] ON [Order].ProductID = [Product].ProductID
	WHERE [Order].[Timestamp] BETWEEN @StartDate AND @EndDate
	GROUP BY [Order].OrderID;
END
GO
