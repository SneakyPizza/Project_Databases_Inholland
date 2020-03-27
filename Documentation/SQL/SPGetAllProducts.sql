USE [ProjectDatabase]
GO
/** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 19/03/2020 20:30:00 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllProducts]

AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT Product.ProductID, Product.Name, Product.Price, Product.BTWPercentile, Product.Amount, Product.Description  FROM dbo.Product WHERE Product.Amount > 1 AND Product.Price > 1 ORDER BY Product.Amount, Product.Price
END