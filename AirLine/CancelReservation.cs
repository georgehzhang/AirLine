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
    public partial class CancelReservation : Form
    {
        public CancelReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerData_GridView f = new CustomerData_GridView();
            f.ShowDialog();
        }
        string planeid;
        string seat;
        private void button3_Click(object sender, EventArgs e)
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
                    MessageBox.Show(
                    "User Information: \n" +
                    "First Name: " + myReader["FirstName"].ToString() + "\n" +
                    "Last Name: " + myReader["LastName"].ToString() + "\n" +
                    "Address: " + myReader["Address"].ToString() + "\n" +
                    "City: " + myReader["City"].ToString() + "\n" +
                    "State: " + myReader["State"].ToString() + "\n" +
                    "Zip Code: " + myReader["ZipCode"].ToString() + "\n" +
                    "Phone: " + myReader["Phone"].ToString() + "\n" +
                   "Country: " + myReader["Country"].ToString() + "\n" +
                    "Passport ID:" + myReader["Id"].ToString() + "\n" +
                    "Special Req: " + myReader["Notes"].ToString() + "\n" +
                   "ReservedFlight: " + myReader["ReservedFlight"].ToString() + "\n" +
                   "Seat: " + myReader["Seat"].ToString());
                    planeid = myReader["ReservedFlight"].ToString();
                    seat = myReader["Seat"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string price;
        private void button2_Click(object sender, EventArgs e)
        {
            if (planeid != "None")
            {
               
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = globals.dataSource;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM flightInfo WHERE Id = '" + planeid + "'", conn);
                    SqlDataReader myReader;
                    conn.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        price = myReader["Price"].ToString();
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
                    SqlCommand cmd = new SqlCommand("UPDATE flightInfo set Seats = Seats + 1 WHERE Id = " + planeid + "", conn);
                    SqlDataReader myReader;
                    conn.Open();
                    myReader = cmd.ExecuteReader();
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
                    SqlCommand myCommand = new SqlCommand("UPDATE customerInfo set ReservedFlight = '" + "None" + "',Seat='" + "" + "' WHERE Id='" + textBox1.Text + "' ", conn);
                    SqlDataReader myReader;
                    conn.Open();
                    myReader = myCommand.ExecuteReader();
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
                    SqlCommand myCommand = new SqlCommand("UPDATE [seatInfo] SET " + seat + " = 1 WHERE Id='" + textBox1.Text + "';", conn);
                    SqlDataReader myReader;
                    conn.Open();
                    myReader = myCommand.ExecuteReader();
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
                    SqlCommand myCommand = new SqlCommand("UPDATE customerPayment set Debit += '" + (Convert.ToDouble(price) - (Convert.ToDouble(price) * 0.1)).ToString() + "' WHERE Id='" + textBox1.Text + "' ", conn);
                    SqlDataReader myReader;
                    conn.Open();
                    myReader = myCommand.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Complete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
