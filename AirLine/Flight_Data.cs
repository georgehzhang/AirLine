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
    public partial class Flight_Data : Form
    {
        public Flight_Data()
        {
            InitializeComponent();
        }

   
        private void Choose_Flight_As_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDatabaseDataSet.flightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.flightDatabaseDataSet.flightInfo);

        }
        
        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flightInfoTableAdapter.Search(this.flightDatabaseDataSet.flightInfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(planeIDToolStripTextBox.Text, typeof(int))))));
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightDatabaseDataSet);
        }

    }
}
