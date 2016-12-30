using System.Collections.Generic;
using System.Data.SqlClient;

namespace Application
{
    public static class PersonIdsRetriever
    {
        public static IEnumerable<string> Retrieve()
        {
            using (
                var connection =
                    new SqlConnection(
                        @"Data Source=DESKTOP-34EOQPB\SQLEXPRESS;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            )
            {
                var familyId = 1;
                using (var command = new SqlCommand("SELECT * FROM dbo.ReadAllPersonsMetadata(@familyId)", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId)
                    }
                })
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return reader.GetString(1);
                    }
                }
            }
        }
    }
}