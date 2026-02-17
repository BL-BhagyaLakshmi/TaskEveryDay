CREATE PROCEDURE [dbo].[CreateTaskHeading]
	@TaskName varchar(30) = null
AS
BEGIN
	INSERT INTO [dbo].[TaskHeadings] (Task_Name)
	VALUES (@TaskName)
END
