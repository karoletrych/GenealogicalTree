CREATE TABLE [dbo].[Families]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Family] XML NULL, 
    [FamilyName] NVARCHAR(50) NULL, 
)
go
