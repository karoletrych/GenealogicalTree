﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
            ReloadFamilies();
            ReloadPersons();
        }

        private void ReloadFamilies()
        {
            lbFamilies.Items.Clear();
            var families = DAO.ReadFamilies().ToDictionary(pair => pair.Key.ToString(), pair => pair.Value);
            lbFamilies.Items.AddRange(families.Select(x => x.Key + "/" + x.Value).ToArray());
        }

        public void ReloadPersons()
        {
            lbPersons.Items.Clear();
            object[] ids = DAO.PersonIds(SelectedFamily).ToArray();
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

        private void lbFamilies_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = lbFamilies.SelectedItem.ToString();
            var l = s.IndexOf("/");
            var id = s.Substring(0, l);
            SelectedFamily = int.Parse(id);

            ReloadPersons();
        }

        private void bDeleteFamily_Click(object sender, EventArgs e)
        {
            DAO.DeleteFamily(SelectedFamily);
            ReloadFamilies();
            ReloadPersons();
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