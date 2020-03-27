USE [ProjectDatabase]
GO
/** Object:  StoredProcedure [dbo].[GetAllOrders]    Script Date: 27-3-2020 13:04:34 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        Yornie Westink
-- Create date: 20/03/20
-- Description:    Get all orders
-- =============================================
CREATE PROCEDURE [dbo].[GetAllOrders] 
    -- Add the parameters for the stored procedure here

AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT
    [Order].[OrderID], [Order].Amount, [Order].PersonID, [Order].Timestamp,
    [Product].Name, [Product].Price, [Product].BTWPercentile, Product.Description 
    FROM [Order]
    JOIN Product ON [Order].ProductID = Product.ProductID
END