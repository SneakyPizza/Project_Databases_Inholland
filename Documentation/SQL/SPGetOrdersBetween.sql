USE [ProjectDatabase]
GO
/** Object:  StoredProcedure [dbo].[GetOrders]    Script Date: 27-3-2020 13:09:10 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        Yornie Westink
-- Create date: 20/03/20
-- Description:    Get all orders between 2 dates
-- =============================================
CREATE PROCEDURE [dbo].[GetOrdersBetween] 
    -- Add the parameters for the stored procedure here

-- Add the parameters for the stored procedure here
    @StartDate datetime,
    @EndDate datetime
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT
    [Order].Amount, [Order].PersonID, [Order].Timestamp,
    [Product].Name, [Product].Price, [Product].BTWPercentile, Product.Description 
    FROM [Order]
    JOIN Product ON [Order].ProductID = Product.ProductID
    WHERE [Order].Timestamp BETWEEN @StartDate AND @EndDate;
END