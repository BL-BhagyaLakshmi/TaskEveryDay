CREATE PROCEDURE [dbo].[CreateTask]
	@Taskdescription varchar(30) = null,
	@TaskHeadingId int = null
AS
BEGIN
IF  EXISTS (SELECT 1 FROM [dbo].[Tasks] WHERE Task_Description = @Taskdescription)
BEGIN
	RAISERROR('Task with the same description already exists.', 16, 1)
END
ELSE
BEGIN
	INSERT INTO [dbo].[Tasks] 
	(Task_Description
	,Task_Heading_Id)
	values (@Taskdescription,@TaskHeadingId)
END

END
