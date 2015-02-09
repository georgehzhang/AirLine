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
    public partial class Choose_Flight : Form
    {
        public Choose_Flight()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }
        bool a = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from flightInfo WHERE Id='"+textBox1.Text+"' ",conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    label1.Text = myReader["Id"].ToString();
                    label2.Text = myReader["Date"].ToString();
                    label3.Text = myReader["DepartTime"].ToString();
                    label4.Text = myReader["Origin"].ToString();
                    label5.Text = myReader["ArrivalTime"].ToString();
                    label6.Text = myReader["Destination"].ToString();
                    label7.Text = myReader["Company"].ToString();
                    label8.Text = myReader["Terminal"].ToString();
                    label9.Text = myReader["Seats"].ToString();
                    label10.Text = myReader["Price"].ToString();
                    a = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                a = false;
            }
            if (a == true)
            {
                flightSeats f = new flightSeats(label1.Text);
                f.ShowDialog();
            }
          
        }

        private void Choose_Flight_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlightData_GridView f = new FlightData_GridView();
            f.ShowDialog();
        }

      

      
    }
}
