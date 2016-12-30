using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Frontend
{
    public static class DAO
    {
        private static readonly string ConnectionString =
            @"Data Source=DESKTOP-34EOQPB\SQLEXPRESS;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static IEnumerable<KeyValuePair<int, string>> ReadFamilies()
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand("SELECT * FROM dbo.Families", connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        yield return new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(2));
                }
            }
        }

        public static void AddFamily(string familyName)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand(@"INSERT INTO dbo.Families
VALUES ('<family><people></people><marriages></marriages></family>',@familyName)", connection)
                {
                    Parameters =
                    {
                         new SqlParameter("@familyName", familyName)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteFamily(int familyId)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand("DELETE FROM dbo.Families WHERE id = @familyId", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@familyid", familyId)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static IEnumerable<string> PersonIds(int id)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand("SELECT * FROM dbo.ReadAllPersonsIds(@familyId)", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@familyId", id)
                    }
                })
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        yield return reader.GetString(0);
                }
            }
        }

        public static string Person(int familyId, string id)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString))
            {
                using (var command = new SqlCommand("SELECT dbo.ReadPerson(@family_id, @required_id)", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@required_id", id),
                        new SqlParameter("@family_id", familyId)
                    }
                })
                {
                    connection.Open();
                    var person = command.ExecuteScalar();
                    return (string) person;
                }
            }
        }

        public static string MarriagesOfAPerson(int familyId, string id)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString))
            {
                using (var command = new SqlCommand("SELECT dbo.ReadMarriagesOfPerson(@family_id, @required_id)", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@required_id", id),
                        new SqlParameter("@family_id", familyId)
                    }
                })
                {
                    connection.Open();
                    var person = command.ExecuteScalar();
                    return (string)person;
                }
            }
        }

        public static void DeletePerson(int familyId, string personId)
        {
            using (
               var connection =
                   new SqlConnection(
                       ConnectionString)
           )
            {
                using (var command = new SqlCommand("dbo.DeletePerson", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId),
                        new SqlParameter("@personId", personId)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreatePerson(int familyId, string newPersonXml)
        {
            using (
               var connection =
                   new SqlConnection(
                       ConnectionString)
           )
            {
                using (var command = new SqlCommand("dbo.CreatePerson", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId),
                        new SqlParameter("@newPersonXml", newPersonXml)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteMarriage(int familyId, string marriageId)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand("dbo.DeleteMarriage", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId),
                        new SqlParameter("@marriageId", marriageId)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateMarriage(int familyId, string marriageId,
            string husbandId, string wifeId, string marriageDate)
        {
            using (
                var connection =
                    new SqlConnection(
                        ConnectionString)
            )
            {
                using (var command = new SqlCommand("dbo.CreateMarriage", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId),
                        new SqlParameter("@marriageId", marriageId),
                        new SqlParameter("@husbandId", husbandId),
                        new SqlParameter("@wifeId", wifeId),
                        new SqlParameter("@marriageDate", marriageDate)
                    }
                })
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}