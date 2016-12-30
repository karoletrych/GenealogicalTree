CREATE TABLE [dbo].[Families]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Family] XML NULL, 
    [FamilyName] NVARCHAR(50) NULL, 
)
go
