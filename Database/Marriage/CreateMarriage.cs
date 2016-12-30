using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [SqlProcedure]
    public static void CreateMarriage(SqlInt32 familyId, SqlString marriageId, SqlString husbandId, SqlString wifeId, SqlDateTime marriageDate)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            var transaction = connection.BeginTransaction();
            try
            {
                var command = new SqlCommand("SELECT Family FROM Families WHERE Id = " + familyId, connection,
                    transaction);
                var reader = command.ExecuteReader();
                SqlXml newXml = null;

                using (reader)
                {
                    if (reader.Read())
                    {
                        var xml = reader.GetSqlXml(0);
                        var xDocument = XDocument.Parse(xml.Value);
                        var marriageElementString =
                            string.Format(@"<marriage id = ""{0}"" date = ""{1}"" husband = ""{2}"" wife = ""{3}"" />", marriageId, marriageDate,
                                husbandId, wifeId);
                        var newMarriage = XElement.Parse(marriageElementString);
                        xDocument.Descendants().Single(node => node.Name.LocalName == "marriages").Add(newMarriage);
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