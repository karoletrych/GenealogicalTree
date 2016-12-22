 DECLARE @myDoc xml
    SET @myDoc = (SELECT TOP 1 Family from Families)

SELECT T.C.value('.', 'varchar(100)') as person_id
FROM @mydoc.nodes('(/family/people/person/@id)') as T(C)