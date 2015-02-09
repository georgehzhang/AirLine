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
    public partial class CustomerCheckIn : Form
    {
        public CustomerCheckIn()
        {
            InitializeComponent();
        }
        string[] data1 = new string[12];
        string[] data2 = new string[8];
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from customerInfo WHERE Id='" + textBox1.Text + "' ", conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    data1[0] = myReader["FirstName"].ToString();
                    data1[1] = myReader["LastName"].ToString();
                    data1[2] = myReader["Address"].ToString();
                    data1[3] = myReader["City"].ToString();
                    data1[4] = myReader["State"].ToString();
                    data1[5] = myReader["ZipCode"].ToString();
                    data1[6] = myReader["Phone"].ToString();
                    data1[7] = myReader["Country"].ToString();
                    data1[8] = myReader["Id"].ToString();
                    data1[9] = myReader["Notes"].ToString();
                    data1[10] = myReader["ReservedFlight"].ToString();
                    data1[11] = myReader["Seat"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from flightInfo WHERE Id='" + data1[10] + "' ", conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    data2[0]= myReader["Id"].ToString();
                    data2[1] = myReader["Date"].ToString();
                    data2[2] = myReader["DepartTime"].ToString();
                    data2[3] = myReader["Origin"].ToString();
                    data2[4] = myReader["ArrivalTime"].ToString();
                    data2[5] = myReader["Destination"].ToString();
                    data2[6] = myReader["Company"].ToString();
                    data2[7] = myReader["Terminal"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(
                   "User Information: \n" +
                   "First Name: " + data1[0] + "\n" +
                   "Last Name: " + data1[1] + "\n" +
                   "Address: " + data1[2] + "\n" +
                   "City: " + data1[3] + "\n" +
                   "State: " + data1[4] + "\n" +
                   "Zip Code: " + data1[5] + "\n" +
                   "Phone: " + data1[6] + "\n" +
                  "Country: " + data1[7] + "\n" +
                   "Passport ID:" + data1[8] + "\n" +
                   "Special Req: " + data1[9] + "\n" +
                  "ReservedFlight: " + data1[10]+"\n"+
                  "Seat: "+data1[11]+"\n\n"+
                  "Flight Information: \n"+
                  "Plane ID: "+ data2[0]+"\n"+
                  "Date: "+ data2[1]+"\n"+
                  "Depart Time: "+ data2[2]+"\n"+
                  "Origin: "+ data2[3]+"\n"+
                  "Arrival Time: "+data2[4] +"\n"+
                  "Destination: "+data2[5] +"\n"+
                  "Company: "+ data2[6]+"\n"+
                  "Terminal: "+ data2[7]+"\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerData_GridView f = new CustomerData_GridView();
            f.ShowDialog();
        }
    }
}
