using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void DeleteMarriage(SqlInt32 familyId, SqlString marriageId)
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
                        var marriages = xDocument.Descendants()
                            .Where(node => node.Name.LocalName.Equals("marriages"))
                            .ToArray();

                        var removals = marriages
                            .SelectMany(node => node.Elements()
                                .Where(x => x.Attribute("id").Value == marriageId.Value))
                            .ToArray();

                        removals.Remove();
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
