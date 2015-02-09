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
    public partial class FlightData_GridView : Form
    {
        public FlightData_GridView()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = globals.dataSource;
            conn.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT * FROM flightInfo ", conn);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(SelectCommand);
            dataTable = new DataTable();
            DataAdapter.Fill(dataTable);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dataTable;
            dataGridView1.DataSource = bSource;
            DataAdapter.Update(dataTable);
            conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Destination_Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("Destination LIKE '%{0}%'", Destination_Search_TextBox.Text);
            dataGridView1.DataSource = DV;
        }
    }
}
