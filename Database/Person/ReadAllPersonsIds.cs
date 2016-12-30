using System.Collections;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

public class UserDefinedFunctions
{
    [SqlFunction(DataAccess = DataAccessKind.Read,
            TableDefinition = "PersonsIds nvarchar(200)",
            FillRowMethodName = "FillRows")
    ]
    public static IEnumerable ReadAllPersonsIds(SqlInt32 familyId)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            var command = new SqlCommand("SELECT Family FROM Families WHERE Id = " + familyId, connection);
            var reader = command.ExecuteReader();
            var resultCollection = new ArrayList();

            using (reader)
            {
                if (!reader.Read())
                    return null;
                var xml = reader.GetSqlXml(0);
                var xDocument = XDocument.Parse(xml.Value);
                var personsIds =
                    xDocument.Descendants()
                        .Where(x => x.Name.LocalName.Equals("person"))
                        .Select(x => x.Attribute("id").Value);
                foreach (var id in personsIds)
                    resultCollection.Add(id);
                return resultCollection;
            }
        }
    }

    public static void FillRows(
        object idObjects,
        out SqlString id)
    {
        id = new SqlString((string)idObjects);
    }
}