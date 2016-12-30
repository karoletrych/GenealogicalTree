using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Frontend
{
    public partial class AddPerson : Form
    {
        private readonly Main _main;

        public AddPerson()
        {
            InitializeComponent();
        }

        public AddPerson(Main main) : this()
        {
            _main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xml = new XDocument(
                new XElement("person", new XAttribute("id", id.Text), new XAttribute("forenames", forenames.Text),
                    new XAttribute("sex", sex.Text), new XAttribute("surname", surname.Text), new XElement("born", new XAttribute("date", born.Text)), new XElement("died", new XAttribute("date", died.Text)),
                    new XElement("mother", mother.Text), new XElement("father", father.Text))).ToString();

            DAO.CreatePerson(1, xml);
            _main.ReloadPersons();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}