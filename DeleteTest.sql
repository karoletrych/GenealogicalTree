USE [master]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[Delete]
		@familyId = 1,
		@personId = 'id1'

SELECT	@return_value as 'Return Value'

GO
