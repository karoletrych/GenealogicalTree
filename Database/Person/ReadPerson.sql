
CREATE FUNCTION [dbo].[ReadPerson]
(
@family_id int,
@required_id nvarchar(50)
)
RETURNS XML
AS
BEGIN
DECLARE @r XML;
  SELECT @r = Family.query('/family/people/person[@id=sql:variable("@required_id")]')
   FROM Families WHERE id = @family_id
  RETURN @r;
END