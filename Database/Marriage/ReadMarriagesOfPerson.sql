CREATE FUNCTION [dbo].[ReadMarriagesOfPerson]
(
@required_id nvarchar(50)
)
RETURNS XML
AS
BEGIN
DECLARE @r XML
  SELECT @r = Family.query('<marriages>{/family/marriages/marriage[@wife=sql:variable("@required_id") or @husband=sql:variable("@required_id")]}</marriages>') FROM Families
  RETURN @r
END