using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AirLine
{
    public partial class CustomerData_GridView : Form
    {
        public CustomerData_GridView()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void Load_Table_Click(object sender, EventArgs e)
        {
            try
            {
              SqlConnection conn = new SqlConnection();
              conn.ConnectionString = globals.dataSource;
              conn.Open();
              SqlCommand SelectCommand = new SqlCommand("SELECT * FROM customerInfo ", conn);
              //SqlCommand SelectCommand = new SqlCommand("SELECT * FROM customerInfo WHERE FirstName = '" + this.FirstName_Search_TextBox + "';", conn);
              SqlDataAdapter DataAdapter = new SqlDataAdapter(SelectCommand);
              dataTable = new DataTable();
              DataAdapter.Fill(dataTable);
              BindingSource bSource = new BindingSource();

              bSource.DataSource = dataTable;
              dataGridView1.DataSource = bSource;
              DataAdapter.Update(dataTable);
              conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Destination_Search_TextBox_TextChanged(object sender, EventArgs e)
        {
          DataView DV = new DataView(dataTable);
          DV.RowFilter = string.Format("FirstName LIKE '{0}%'", this.FirstName_Search_TextBox.Text);
          dataGridView1.DataSource = DV;
        }
    }
}
