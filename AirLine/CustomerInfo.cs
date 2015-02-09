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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from customerInfo WHERE Id='" + NameSearch.Text + "' ", conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    textBox1.Text = myReader["FirstName"].ToString();
                    textBox12.Text = myReader["LastName"].ToString();
                    textBox2.Text = myReader["Address"].ToString();
                    textBox3.Text = myReader["City"].ToString();
                    textBox4.Text = myReader["State"].ToString();
                    textBox5.Text = myReader["ZipCode"].ToString();
                    textBox6.Text = myReader["Phone"].ToString();
                    textBox7.Text = myReader["Country"].ToString();
                    textBox9.Text = myReader["Notes"].ToString();
                    textBox10.Text = myReader["ReservedFlight"].ToString();
                    textBox14.Text = myReader["Id"].ToString();
                    textBox15.Text = myReader["Seat"].ToString();
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
                SqlCommand myCommand = new SqlCommand("SELECT * FROM customerPayment WHERE Id='" + NameSearch.Text + "' ", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while(myReader.Read())
                {
                    textBox8.Text = myReader["CardNumber"].ToString();
                    textBox11.Text = myReader["Debit"].ToString();
                    textBox13.Text = myReader["Credit"].ToString();
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
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlCommand cmd = new SqlCommand("UPDATE customerInfo set FirstName='"
                                                        + textBox1.Text + "',LastName = '"
                                                        + textBox12.Text + "', Address ='"
                                                        + textBox2.Text + "', City ='"
                                                        + textBox3.Text + "', State='"
                                                        + textBox4.Text + "', ZipCode='"
                                                        + textBox5.Text + "', Phone ='"
                                                        + textBox6.Text + "', Country='"
                                                        + textBox7.Text + "', Notes='"
                                                        + textBox9.Text + "', ReservedFlight='"
                                                        + textBox10.Text + "', Seat='"
                                                        + textBox15.Text + "'WHERE Id='" + NameSearch.Text + "'", conn);
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
                SqlCommand cmd = new SqlCommand("UPDATE customerPayment set CardNumber='"
                                                        + textBox8.Text + "',Debit = '"
                                                        + textBox11.Text + "', Credit ='"
                                                        + textBox13.Text + "' WHERE Id='" + NameSearch.Text + "'", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add new
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlCommand cmd = new SqlCommand("INSERT INTO customerInfo (FirstName,LastName, Address, City, State, ZipCode, Phone,Country,Notes,ReservedFlight,Id,Seat) VALUES ('"
                                                        + textBox1.Text + "', '"
                                                        + textBox12.Text + "', '"
                                                        + textBox2.Text + "', '"
                                                        + textBox3.Text + "', '"
                                                        + textBox4.Text + "', '"
                                                        + textBox5.Text + "', '"
                                                        + textBox6.Text + "', '"
                                                        + textBox7.Text + "', '"
                                                        + textBox9.Text + "', '"
                                                        + textBox10.Text + "', '"
                                                        + textBox14.Text + "','"
                                                        + textBox15.Text + "');", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlCommand cmd = new SqlCommand("INSERT INTO customerPayment (CardNumber,Debit,Credit,Id) VALUES ('"
                                                        + textBox8.Text + "', '"
                                                        + textBox11.Text + "', '"
                                                        + textBox13.Text +"', '"
                                                        + textBox14.Text + "');", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlCommand cmd = new SqlCommand("DELETE FROM customerInfo WHERE Id='" + NameSearch.Text + "'", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlCommand cmd = new SqlCommand("DELETE FROM customerPayment WHERE Id='" + NameSearch.Text + "'", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //clear
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox8.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            NameSearch.Text = "";
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CustomerData_GridView f = new CustomerData_GridView();
            f.ShowDialog();
        }
    }
}
