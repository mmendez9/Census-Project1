using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Census_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myTownDBDataSet.Homeless' table. You can move, or remove it, as needed.
            this.homelessTableAdapter.Fill(this.myTownDBDataSet.Homeless);
            // TODO: This line of code loads data into the 'myTownDBDataSet.PersonInfo' table. You can move, or remove it, as needed.
            this.personInfoTableAdapter.PersonAddress(this.myTownDBDataSet.PersonInfo);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTownDBDataSet.Person.AddPersonRow(tbxFirst.Text, tbxLast.Text, dtDOB.Value, null);
        }

        private void personInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);
        }
    }
}
