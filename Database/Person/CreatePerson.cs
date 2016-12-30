using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

//TODO add validation against schema

public partial class StoredProcedures
{
    /// <summary>
    ///     Procedure adds person to xml or overwrites existing one.
    /// </summary>
    /// <param name="familyId"></param>
    /// <param name="newPersonXml"></param>
    [SqlProcedure]
    public static void CreatePerson(SqlInt32 familyId, SqlXml newPersonXml)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            var transaction = connection.BeginTransaction();
            try
            {
                var command = new SqlCommand("SELECT Family FROM Families WHERE Id = " + familyId, connection, transaction);
                var reader = command.ExecuteReader();
                SqlXml newXml = null;

                using (reader)
                {
                    if (reader.Read())
                    {
                        var xml = reader.GetSqlXml(0);
                        var xDocument = XDocument.Parse(xml.Value);
                        var newPerson = XElement.Parse(newPersonXml.Value);
                        xDocument.Descendants().Single(node => node.Name.LocalName == "people").Add(newPerson);
                        newXml = new SqlXml(xDocument.CreateReader());
                    }
                }
                var overwriteCommand =
                    new SqlCommand("UPDATE Families SET Family = '" + newXml.Value + "' WHERE Id = " + familyId,
                        connection, transaction);
                overwriteCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
        }
    }
}