using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine
{
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        private void flightInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);

        }

        private void Flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDatabaseDataSet.flightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.flightDatabaseDataSet.flightInfo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.flightInfoBindingSource.AddNew();
        }

        private void flightInfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);

        }

        private void flightInfoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);

        }

        private void Flight_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDatabaseDataSet.flightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.flightDatabaseDataSet.flightInfo);
      
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.flightInfoBindingSource.AddNew();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = flightInfoBindingSource.Count;
            label1.Text = "There are " + count.ToString() + " Airplanes";
        }

        private void flightInfoBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);

        }
    }
}
