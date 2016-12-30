using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class AddMarriage : Form
    {
        private readonly Main _main;

        public AddMarriage(Main main)
        {
            _main = main;
            InitializeComponent();
        }

        private void AddMarriage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO.CreateMarriage(1, marriageId.Text, husband.Text, wife.Text, marriageDate.Text);
            _main.DisplayPersonMarriages();
            this.Close();
        }
    }
}
