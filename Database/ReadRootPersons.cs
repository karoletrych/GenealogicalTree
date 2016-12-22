using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

public class UserDefinedFunctions
{
    [SqlFunction(DataAccess = DataAccessKind.Read)]
    public static SqlXml ReadRootPersons(SqlInt32 familyId)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            var command = new SqlCommand("SELECT Family FROM Families WHERE Id = " + familyId, connection);
            //TODO use executeXMLReader
            var reader = command.ExecuteReader();

            using (reader)
            {
                if (reader.Read())
                {
                    var xml = reader.GetSqlXml(0);
                    var xDocument = XDocument.Parse(xml.Value);
                    var persons =
                        xDocument.Descendants().Where(descendant => descendant.Name.LocalName.Equals("person"));
                    var parentlessPersonsElements =
                        persons.Where(
                            person =>
                                person.Elements()
                                    .All(element => (element.Name != "mother") && (element.Name != "father")));

                    var peopleDocument = new XDocument(new XElement("people", ""));

                        foreach (var parentlessPersonsElement in parentlessPersonsElements)
                            peopleDocument.Root.Add(parentlessPersonsElement);
                        return new SqlXml(peopleDocument.CreateReader());
                }
            }
        }
        return new SqlXml();
    }
}