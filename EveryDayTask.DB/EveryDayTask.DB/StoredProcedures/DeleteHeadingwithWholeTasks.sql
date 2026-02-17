CREATE PROCEDURE [dbo].[DeleteHeadingwithWholeTasks]
	@taskHeadingId int = null
AS
BEGIN
	DELETE FROM [dbo].[Tasks]
	WHERE Task_Heading_Id = @taskHeadingId
	DELETE FROM [dbo].[TaskHeadings]
	WHERE Task_Heading_Id = @taskHeadingId
END
