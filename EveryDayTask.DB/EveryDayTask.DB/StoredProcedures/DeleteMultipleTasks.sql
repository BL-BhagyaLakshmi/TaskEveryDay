CREATE PROCEDURE [dbo].[DeleteMultipleTasks]
	@taskIds dbo.integerList READONLY
AS
BEGIN
DELETE from dbo.tasks where Task_Id in (select Id from @taskIds)
END
