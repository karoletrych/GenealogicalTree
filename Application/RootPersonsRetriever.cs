using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Application
{
    public static class RootPersonsRetriever
    {
        public static familyPerson[] Retrieve()
        {
            using (
                var connection =
                    new SqlConnection(
                        @"Data Source=DESKTOP-34EOQPB\SQLEXPRESS;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            )
            {
                var familyId = 13;
                using (var command = new SqlCommand("SELECT dbo.ReadRootPersons(@familyId)", connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@familyId", familyId)
                    }
                })
                {
                    connection.Open();
                    var reader = command.ExecuteScalar();
                    var xml = reader.ToString();
                    var parser = new XmlSerializer(typeof(familyPerson[]));

                    using (var xmlReader = XmlReader.Create(new StringReader(xml),
                            new XmlReaderSettings {CheckCharacters = false}))
                    {
                        var people = (familyPerson[]) parser.Deserialize(xmlReader);
                        return people;
                    }
                }
            }
        }
    }
}