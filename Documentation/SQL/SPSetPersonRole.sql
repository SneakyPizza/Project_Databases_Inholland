USE [ProjectDatabase]
GO
/****** Object:  StoredProcedure [dbo].[UpdateActivity]    Script Date: 3/27/2020 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 27/03/20
-- Description:	Change the role of the person
-- =============================================
CREATE PROCEDURE [dbo].ChangePersonRole
	-- Add the parameters for the stored procedure here
	@id int,
	@role int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [Person] SET [Role] = @role WHERE [PersonID] = @id
END
