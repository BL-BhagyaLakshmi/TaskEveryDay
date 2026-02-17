CREATE TABLE [dbo].[Tasks]
(
	[Task_Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Task_Heading_Id] int Foreign Key REFERENCES [dbo].[TaskHeadings](Task_Heading_Id) NOT NULL,
	[Task_Description] VARCHAR(30) NOT NULL,
)
