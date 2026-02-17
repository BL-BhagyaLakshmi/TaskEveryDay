CREATE PROCEDURE [dbo].[UpdateTask]
	@TaskId int = null,
	@Taskdescription varchar(30) = null
AS
BEGIN
UPDATE dbo.Tasks
SET Task_Description=@Taskdescription
where Task_Id=@TaskId
END
