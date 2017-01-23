using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Xml.Linq;
using System.Linq;
using System.Xml;
using System.Text;
using System.IO;

public partial class UserDefinedFunctions
{
    [SqlFunction(DataAccess = DataAccessKind.Read)]
    public static SqlXml ReadPersonsDescendants(SqlInt32 family_id, SqlString person_id, SqlInt32 generations)
    {
        using (var connection = new SqlConnection("context connection=true"))
        {
            connection.Open();
            SqlXml personXml;
            using (
                var command =
                    new SqlCommand(@"SELECT Family.query('/family/people') FROM Families WHERE id = @family_id",
                        connection)
                    {
                        Parameters =
                        {
                            new SqlParameter("@family_id", family_id)
                        }
                    })
            {
                var reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.Read())
                        return null;
                    //return reader.GetSqlXml(0);
                    personXml = reader.GetSqlXml(0);
                }
            }
            var personId = person_id.Value;
            var xDocument = XDocument.Parse(personXml.Value);
            var persons = xDocument.Descendants().Where(node => node.Name == "person").ToArray();
            var descendants = GetChildrenRec(persons, new[] { personId }, generations.Value).Single();
            //var newDocument = new XElement("descendants", descendants);
            var xmlString = descendants.ToString();
            using (var reader = XmlReader.Create(new StringReader(xmlString)))
            {
                return new SqlXml(reader);
            }
        }
    }

    private static XElement[] GetChildrenRec(XElement[] persons, string[] personId, int generations)
    {
        var personsWithChildrens = personId.Select(id => GetPersonWithItsChildren(persons, id, generations))
            .ToArray();
        return personsWithChildrens;
    }

    private static XElement GetPersonWithItsChildren(XElement[] persons, string id, int generations)
    {
        var person = GetPerson(persons, id);
        var personnen = persons.Where(p => IsChildOf(p, id));
        var personnenIds = personnen.Select(x => x.Attribute("id").Value.ToString()).ToArray();
        if (generations > 0)
        {
            var children = GetChildrenRec(persons, personnenIds, generations - 1);
            person.Add(children);
        }
        return person;
    }

    private static XElement GetPerson(XElement[] persons, string id)
    {
        var person = persons.First(x =>
        {
            var idAttribute = x.Attribute("id");
            return idAttribute != null && idAttribute.Value == id;
        });
        person.Elements().Remove();
        ;
        return person;
    }

    private static bool IsChildOf(XElement person, string personId)
    {
        var mother = person.Element("mother");
        var father = person.Element("father");
        return mother != null && father != null && (father.Value == personId ||
                                                        mother.Value == personId);
    }
};

