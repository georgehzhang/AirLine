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
    public partial class FlightInfo : Form
    {
        public FlightInfo()
        {
            InitializeComponent();
        }

        private void Flight_Data_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from flightInfo WHERE Id='" + PlaneIDText_Search.Text + "' ", conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    PlaneIDText.Text = myReader["Id"].ToString();
                    DateText.Text = myReader["Date"].ToString();
                    DepartTimeText.Text = myReader["DepartTime"].ToString();
                    OriginText.Text = myReader["Origin"].ToString();
                    ArrivalTimeText.Text = myReader["ArrivalTime"].ToString();
                    DestinationText.Text = myReader["Destination"].ToString();
                    CompanyText.Text = myReader["Company"].ToString();
                    TerminalText.Text = myReader["Terminal"].ToString();
                    SeatsText.Text = myReader["Seats"].ToString();
                    PriceText.Text = myReader["Price"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
             try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource;
                 SqlCommand cmd = new SqlCommand("UPDATE customersInfo set Id='"
                                                        + PlaneIDText.Text + "', Date ='"
                                                        + DateText.Text + "', DepartTime ='"
                                                        + DepartTimeText.Text + "', Origin='"
                                                        + OriginText.Text + "', ArrivalTime='"
                                                        + ArrivalTimeText.Text + "', Destination ='"
                                                        + DestinationText.Text + "', Company='"
                                                        + CompanyText.Text + "', Terminal='"
                                                        + TerminalText.Text + "', Seats='"
                                                        + SeatsText.Text + "', Price='"
                                                        + PriceText.Text + "' WHERE Id='" + PlaneIDText_Search.Text + "'", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PlaneIDText.Text = "";
            DateText.Text = "";
            DepartTimeText.Text = "";
            OriginText.Text = "";
            ArrivalTimeText.Text = "";
            DestinationText.Text = "";
            CompanyText.Text = "";
            TerminalText.Text = "";
            SeatsText.Text = "";
            PriceText.Text = "";
            PlaneIDText_Search.Text = "";
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource; 
                SqlCommand cmd = new SqlCommand("INSERT INTO flightInfo (Id,Date,DepartTime,Origin,ArrivalTime,Destination,Company,Terminal,Seats,Price) VALUES ('"
                                                        + PlaneIDText.Text + "', '"
                                                        + DateText.Text + "', '"
                                                        + DepartTimeText.Text + "', '"
                                                        + OriginText.Text + "', '"
                                                        + ArrivalTimeText.Text + "', '"
                                                        + DestinationText.Text + "', '"
                                                        + CompanyText.Text + "', '"
                                                        + TerminalText.Text + "', '"
                                                        + SeatsText.Text + "', '"
                                                        + PriceText.Text + "');", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = globals.dataSource; 
                SqlCommand cmd = new SqlCommand("DELETE FROM flightInfo WHERE Id='" + PlaneIDText_Search.Text + "'", conn);
                SqlDataReader myReader;
                conn.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightData_GridView f = new FlightData_GridView();
            f.ShowDialog();
        }
    }
}
