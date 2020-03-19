GO
-- SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'2', N'StudentenKamer', N'4')
INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'4', N'DocentenKamer', N'6')
INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'6', N'StudentenKamer', N'8')
INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'8', N'DocentenKamer', N'12')
INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'10', N'StudentenKamer', N'16')

GO
INSERT [dbo].Room(PersonID, RoomType, RoomCapacity) VALUES (N'5', N'DocentenKamer', N'8')
-- SET IDENTITY_INSERT [dbo].[Person] OFF