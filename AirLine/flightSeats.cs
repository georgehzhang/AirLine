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
  public partial class flightSeats : Form
  {
    string data;
    string selectedseat;
    public flightSeats()
    {
      InitializeComponent();
    }
    
    public flightSeats(string text)
    {
        InitializeComponent();
        //text is the plane id.
        data = text;

        try
        {
          bool[] seatCheck;
          seatCheck = new bool[20];
          SqlConnection conn = new SqlConnection();
          conn.ConnectionString = globals.dataSource;
          SqlCommand SelectCommand = new SqlCommand("select * from seatInfo where Id='" + text + "' ;", conn);
          SqlDataReader myReader;
          conn.Open();
          myReader = SelectCommand.ExecuteReader();

          while (myReader.Read())
          {
            seatCheck[0] = (bool)myReader["a1"];
            seatCheck[1] = (bool)myReader["a2"];
            seatCheck[2] = (bool)myReader["a3"];
            seatCheck[3] = (bool)myReader["a4"];
            seatCheck[4] = (bool)myReader["b1"];
            seatCheck[5] = (bool)myReader["b2"];
            seatCheck[6] = (bool)myReader["b3"];
            seatCheck[7] = (bool)myReader["b4"];
            seatCheck[8] = (bool)myReader["c1"];
            seatCheck[9] = (bool)myReader["c2"];
            seatCheck[10] = (bool)myReader["c3"];
            seatCheck[11] = (bool)myReader["c4"];
            seatCheck[12] = (bool)myReader["d1"];
            seatCheck[13] = (bool)myReader["d2"];
            seatCheck[14] = (bool)myReader["d3"];
            seatCheck[15] = (bool)myReader["d4"];
            seatCheck[16] = (bool)myReader["e1"];
            seatCheck[17] = (bool)myReader["e2"];
            seatCheck[18] = (bool)myReader["e3"];
            seatCheck[19] = (bool)myReader["e4"];
          }
          conn.Close();
          PictureBox[] boxes = { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4, e1, e2, e3, e4 };
          for (int i = 0; i < boxes.Length; i++)
          {
            if (seatCheck[i] == false)
              boxes[i].Image = Image.FromFile(globals.rchair);
            else
              boxes[i].Image = Image.FromFile(globals.gchair);
          }
        }
      catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void flightSeats_Load(object sender, EventArgs e)
    {

    }


    private void pictureBox21_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    string price;
    private void reserveBut_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = globals.dataSource;
            SqlCommand cmd = new SqlCommand("UPDATE flightInfo set Seats = Seats - 1 WHERE Id ='" + data + "'", conn);
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
          
          SqlCommand cmd = new SqlCommand("UPDATE [seatInfo] SET " + selectedseat + " = 0 WHERE Id = '" + data + "';", conn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM flightInfo WHERE Id = '" + data + "'", conn);
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
            SqlCommand myCommand = new SqlCommand("UPDATE customerInfo set ReservedFlight = '" + data + "', Seat='" + selectedseat + "' WHERE Id='" + passportInput.Text + "' ", conn);
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
            SqlCommand myCommand = new SqlCommand("UPDATE customerPayment set Credit += '" + (Convert.ToDouble(price)).ToString() + "' WHERE Id='" + passportInput.Text + "' ", conn);
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
        this.Close();
    }


    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void a1_Click(object sender, EventArgs e)
    {
      a1.Image = Image.FromFile(globals.ychair);
      selectedseat = "A1";
    }

    private void a2_Click(object sender, EventArgs e)
    {
      a2.Image = Image.FromFile(globals.ychair);
      selectedseat = "A2";
    }

    private void a3_Click(object sender, EventArgs e)
    {
      a3.Image = Image.FromFile(globals.ychair);
      selectedseat = "A3";
    }

    private void a4_Click(object sender, EventArgs e)
    {
      a4.Image = Image.FromFile(globals.ychair);
      selectedseat = "A4";
    }

    private void b1_Click(object sender, EventArgs e)
    {
      b1.Image = Image.FromFile(globals.ychair);
      selectedseat = "B1";
    }

    private void b2_Click(object sender, EventArgs e)
    {
      b2.Image = Image.FromFile(globals.ychair);
      selectedseat = "B2";
    }

    private void b3_Click(object sender, EventArgs e)
    {
      b3.Image = Image.FromFile(globals.ychair);
      selectedseat = "B3";
    }

    private void b4_Click(object sender, EventArgs e)
    {
      b4.Image = Image.FromFile(globals.ychair);
      selectedseat = "B4";
    }

    private void c1_Click(object sender, EventArgs e)
    {
      c1.Image = Image.FromFile(globals.ychair);
      selectedseat = "C1";
    }

    private void c2_Click(object sender, EventArgs e)
    {
      c2.Image = Image.FromFile(globals.ychair);
      selectedseat = "C2";
    }


    private void c3_Click(object sender, EventArgs e)
    {
      c3.Image = Image.FromFile(globals.ychair);
      selectedseat = "C3";
    }

    private void c4_Click(object sender, EventArgs e)
    {
      c4.Image = Image.FromFile(globals.ychair);
      selectedseat = "C4";
    }

    private void d1_Click(object sender, EventArgs e)
    {
      d1.Image = Image.FromFile(globals.ychair);
      selectedseat = "D1";
    }

    private void d2_Click(object sender, EventArgs e)
    {
      d2.Image = Image.FromFile(globals.ychair);
      selectedseat = "D2";
    }

    private void d3_Click(object sender, EventArgs e)
    {
      d3.Image = Image.FromFile(globals.ychair);
      selectedseat = "D3";
    }

    private void d4_Click(object sender, EventArgs e)
    {
      d4.Image = Image.FromFile(globals.ychair);
      selectedseat = "D4";
    }

    private void e1_Click(object sender, EventArgs e)
    {
      e1.Image = Image.FromFile(globals.ychair);
      selectedseat = "E1";
    }

    private void e2_Click(object sender, EventArgs e)
    {
      e2.Image = Image.FromFile(globals.ychair);
      selectedseat = "E2";
    }

    private void e3_Click(object sender, EventArgs e)
    {
      e3.Image = Image.FromFile(globals.ychair);
      selectedseat = "E3";
    }

    private void e4_Click(object sender, EventArgs e)
    {
        e4.Image = Image.FromFile(globals.ychair);
        selectedseat="E4";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = globals.dataSource;
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from customerInfo WHERE Id='" + passportInput.Text + "' ", conn);
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
               "Seat: " + myReader["Seat"]);
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
        CustomerData_GridView f = new CustomerData_GridView();
        f.ShowDialog();
    }
  }
}
