
CREATE FUNCTION [dbo].[ReadPerson]
(
@required_id nvarchar(50)
)
RETURNS XML
AS
BEGIN
DECLARE @r XML;
  SELECT @r = Family.query('/family/people/person[@id=sql:variable("@required_id")]') FROM Families
  RETURN @r;
END