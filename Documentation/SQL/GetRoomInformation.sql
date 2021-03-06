USE [ProjectDatabase]
GO
/****** Object:  StoredProcedure [dbo].[GetAllRooms]    Script Date: 10/03/2020 14:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllRooms]
	-- Add the parameters for the stored procedure here
	@RoomCapacity int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Room.RoomID, Room.RoomType, Room.RoomCapacity FROM dbo.Room WHERE Room.RoomCapacity <= @RoomCapacity
END
