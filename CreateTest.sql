USE [master]
GO

DECLARE	@return_value Int
DECLARE @newPerson xml
Set @newPerson = '<person forenames="forenames5" id="id10" sex="sex5" surname="surname5">
      <born date="date5" />
      <mother id="id5" />
      <father id="id5" />
      <died date="date5" />
    </person>'

EXEC	@return_value = [dbo].[CreatePerson]
		@familyId = 3,
		@newPersonXml = @newPerson

SELECT	@return_value as 'Return Value'

GO
