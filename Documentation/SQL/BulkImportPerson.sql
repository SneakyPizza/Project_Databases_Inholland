USE [ProjectDatabase]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 13/03/20 
-- Description:	Bulk insert Persons
-- =============================================
ALTER PROCEDURE BulkInsertPerson
AS
-- DECLARE @filepath nvarchar(2000)
-- SET @filepath = N'D:\School\Inholland\Haarlem\ProjectDatabase\Project_Databases_Inholland\Someren1920F\SomerenDAL\resources\Persons.txt'
BULK INSERT ProjectDatabase.dbo.Person 
FROM  'D:\School\Inholland\Haarlem\ProjectDatabase\Project_Databases_Inholland\Someren1920F\SomerenDAL\resources\Persons.txt' 
WITH 
(
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n'
)
GO