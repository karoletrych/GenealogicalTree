using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

public class StoredProcedures
{
    [SqlProcedure]
    public static void Delete(SqlInt32 familyId, SqlString personId)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();
            var command = new SqlCommand("SELECT Family FROM Families WHERE Id = " + familyId, connection);
            //TODO use executeXMLReader
            var reader = command.ExecuteReader();
            SqlXml newXml = null;

            using (reader)
            {
                if (reader.Read())
                {
                    var xml = reader.GetSqlXml(0);
                    var xDocument = XDocument.Parse(xml.Value);
                    var people = xDocument.Descendants()
                        .Where(node => node.Name.LocalName.Equals("people"))
                        .ToArray();

                    var removals = people
                        .SelectMany(node => node.Elements()
                            .Where(x => x.Attribute("id").Value == personId.Value))
                        .ToArray();


                    removals.Remove();
                    newXml = new SqlXml(xDocument.CreateReader());
                }
            }

            var overwriteCommand = new SqlCommand("UPDATE Families SET Family = '" + newXml.Value + "' WHERE Id = " + familyId);
            overwriteCommand.Connection = connection;
            overwriteCommand.ExecuteNonQuery();
        }
    }
}