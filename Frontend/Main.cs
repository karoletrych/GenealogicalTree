using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Frontend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadPersons();
        }

        public void ReloadPersons()
        {
            lbPersons.Items.Clear();
            var ids = DAO.PersonIds(1).ToArray();
            lbPersons.Items.AddRange(ids);
        }

        private void lbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPersonDetails();
            DisplayPersonMarriages();
        }


        public void DisplayPersonMarriages()
        {
            var selectedId = (string) lbPersons.SelectedItem;
            var marriagesXml = DAO.MarriagesOfAPerson("1", selectedId);
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
            var person = DAO.Person(selectedId);
            var xDocument = XDocument.Parse(person);
            tbDetails.Text = xDocument.ToString();
        }

        private void bDeletePerson_Click(object sender, EventArgs e)
        {
            var personId = (string) lbPersons.SelectedItem;
            DAO.DeletePerson(1, personId);
            ReloadPersons();
        }

        private void bAddPerson_Click(object sender, EventArgs e)
        {
            var addPersonForm = new AddPerson(this);
            addPersonForm.Show();
        }

        private void bSavePerson_Click(object sender, EventArgs e)
        {
            var personId = (string)lbPersons.SelectedItem;
            DAO.DeletePerson(1, personId);
            DAO.CreatePerson(1, tbDetails.Text);
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
            var marriageId = (string)row.Cells[0].Value;
            DAO.DeleteMarriage(1, marriageId);
            var personId = (string) lbPersons.SelectedItem;
            DisplayPersonMarriages();
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