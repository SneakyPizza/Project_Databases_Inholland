-- =============================================
-- Author:		<Koen vc>
-- Create date: <26-03-2020>
-- Description:	<Get All Events>
-- =============================================
CREATE PROCEDURE GetAllEvents

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [Event]
END