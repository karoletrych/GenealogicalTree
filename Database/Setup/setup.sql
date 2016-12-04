
--DROP TABLE Families
--CREATE TABLE Families(Family xml);
--go
--INSERT INTO Families(Family)
--SELECT * FROM OPENROWSET(  
--   BULK 'c:\family.xml',
--   SINGLE_BLOB) AS x
   

--SELECT * FROM Families


SELECT Family.query('/family/people/person[@id="id1"]') FROM Families;
--EXEC [Delete] @familyId = 1, @personId = 'id1' 


--SELECT [dbo].ReadPerson('id1')
--DECLARE @ret xml
--EXEC @ret = dbo.ReadPerson  @required_id = 'id1'
--SELECT @ret; 
