using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Frontend
{
    public partial class Main : Form
    {
        public int SelectedFamily;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DAO.CreateFamiliesTable();
            ReloadFamilies();
            ReloadPersons("");
        }

        private void ReloadFamilies()
        {
            lvFamilies.Items.Clear();
            lvFamilies.Columns.Clear();
            lvFamilies.View = View.Details;
            lvFamilies.FullRowSelect = true;

            lvFamilies.Columns.Add("id");
            lvFamilies.Columns.Add("nazwa");
            
            var families = DAO.ReadFamilies().ToDictionary(pair => pair.Key.ToString(), pair => pair.Value);
            foreach (var family in families)
            {
                var item =
                    new ListViewItem(new[] { family.Key, family.Value });
                lvFamilies.Items.Add(item);
            }
        }


        public void ReloadPersons(string filter)
        {
            lbPersons.Items.Clear();
            object[] ids = DAO.PersonIds(SelectedFamily).ToArray();
            if (!filter.Equals(""))
            {
                var filteredIds = ids.Cast<string>().Where(id => id.Contains(filter)).Cast<object>().ToArray();
                lbPersons.Items.AddRange(filteredIds);
            }
            else
                lbPersons.Items.AddRange(ids);
        }

        public void ReloadPersons()
        {
            ReloadPersons("");
        }

        private void lbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPersonDetails();
            DisplayPersonMarriages();
            DisplayPersonsChildren();
        }

        private void DisplayPersonsChildren()
        {
            var selectedId = (string)lbPersons.SelectedItem;
            var children = DAO.ReadPersonsDescendants(SelectedFamily, selectedId, (int)generations.Value);
            var xDocument = XDocument.Parse(children);
            tbDescendants.Text = xDocument.ToString();
        }

        public void DisplayPersonMarriages()
        {
            var selectedId = (string) lbPersons.SelectedItem;
            var marriagesXml = DAO.MarriagesOfAPerson(SelectedFamily, selectedId);
            var marriagesXDocument = XDocument.Parse(marriagesXml);
            var xElements = marriagesXDocument.Descendants("marriage").ToArray();
            var marriages =
                xElements
                    .Select(
                        x =>
                            new Marriage
                            {
                                Date = x.Attribute("date").Value,
                                Husband = x.Attribute("husband").Value,
                                Wife = x.Attribute("wife").Value,
                                Id = x.Attribute("id").Value
                            }).ToArray();
            var marriagesList = new BindingList<Marriage>(marriages);
            dgMarriages.DataSource = marriagesList;
        }

        private void DisplayPersonDetails()
        {
            var selectedId = (string) lbPersons.SelectedItem;
            var person = DAO.Person(SelectedFamily, selectedId);
            var xDocument = XDocument.Parse(person);
            tbDetails.Text = xDocument.ToString();
        }

        private void bDeletePerson_Click(object sender, EventArgs e)
        {
            var personId = (string) lbPersons.SelectedItem;
            DAO.DeletePerson(SelectedFamily, personId);
            ReloadPersons();
        }

        private void bAddPerson_Click(object sender, EventArgs e)
        {
            var addPersonForm = new AddPerson(this);
            addPersonForm.Show();
        }

        private void bSavePerson_Click(object sender, EventArgs e)
        {
            var personId = (string) lbPersons.SelectedItem;
            DAO.DeletePerson(SelectedFamily, personId);
            DAO.CreatePerson(SelectedFamily, tbDetails.Text);
            ReloadPersons();
        }

        private void bAddMarriage_Click(object sender, EventArgs e)
        {
            var addMarriageForm = new AddMarriage(this);
            addMarriageForm.Show();
        }

        private void bDeleteMarriage_Click(object sender, EventArgs e)
        {
            var row = dgMarriages.CurrentRow;
            var marriageId = (string) row.Cells[0].Value;
            DAO.DeleteMarriage(SelectedFamily, marriageId);
            DisplayPersonMarriages();
        }

        private void bAddFamily_Click(object sender, EventArgs e)
        {
            DAO.AddFamily(tbFamilyName.Text);
            ReloadFamilies();
        }

        private void bDeleteFamily_Click(object sender, EventArgs e)
        {
            DAO.DeleteFamily(SelectedFamily);
            ReloadFamilies();
            ReloadPersons();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = lvFamilies.SelectedItems;
            if (id.Count != 0)
            {
                SelectedFamily = int.Parse(id[0].Text);
                ReloadPersons();
            }
        }

        private void generations_ValueChanged(object sender, EventArgs e)
        {
            DisplayPersonsChildren();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            ReloadPersons(search.Text);
        }
    }

    public class Marriage
    {
        public string Id { get; set; }
        public string Wife { get; set; }
        public string Husband { get; set; }
        public string Date { get; set; }
    }
}