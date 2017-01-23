using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(DataAccess=DataAccessKind.Read)]
    public static SqlXml ReadPerson(SqlInt32 family_id, SqlString required_id)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();

            using (var command = new SqlCommand(@"SELECT Family.query('/family/people/person[@id=sql:variable(""@required_id"")]') FROM Families WHERE id = @family_id", connection)
            {
                Parameters =
                    {
                        new SqlParameter("@required_id", required_id),
                        new SqlParameter("@family_id", family_id)
                    }
            })
            {
                var reader = command.ExecuteReader();

                using (reader)
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

