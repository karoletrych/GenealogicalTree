CREATE FUNCTION [dbo].[ReadMarriagesOfPerson]
(
@family_id int,
@required_id nvarchar(50)
)
RETURNS XML
AS
BEGIN
DECLARE @r XML
  SELECT @r = Family.query('<marriages>{/family/marriages/marriage[@wife=sql:variable("@required_id") or @husband=sql:variable("@required_id")]}</marriages>')
   FROM Families where id = @family_id
  RETURN @r
END