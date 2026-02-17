CREATE PROCEDURE [dbo].[UpdateTaskHeading]
	@TaskName varchar(30) = null,
	@TaskHeadingId int = null
AS
BEGIN
	UPDATE [dbo].[TaskHeadings]
	SET Task_Name = @TaskName
	WHERE Task_Heading_Id = @TaskHeadingId
END

