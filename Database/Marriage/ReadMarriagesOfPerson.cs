using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Xml.Linq;
using System.Linq;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(DataAccess = DataAccessKind.Read)]
    public static SqlXml ReadMarriagesOfPerson(SqlInt32 family_id, SqlString required_id)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            using (var command = new SqlCommand(@"SELECT Family.query('<marriages>{/family/marriages/marriage[@wife=sql:variable(""@required_id"") or @husband=sql:variable(""@required_id"")]}</marriages>') FROM Families WHERE id = @family_id", connection)
            {
                Parameters =
                    {
                        new SqlParameter("@required_id", required_id),
                        new SqlParameter("@family_id", family_id)
                    }
            })
            {
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;
                    var xml = reader.GetSqlXml(0);
                    return xml;
                }
            }
        }
    }
};

