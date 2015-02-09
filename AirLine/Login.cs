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
  public partial class login : Form
  {
    public login()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void loginBtn_Click(object sender, EventArgs e)
    {
      try
      {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = globals.dataSource;
        SqlCommand SelectCommand = new SqlCommand("select * from employeeInfo WHERE Username='" + this.userBox.Text + "' and Password='" + this.passBox.Text + "' and Category='" + this.catBox.Text + "' ;", conn);
        SqlDataReader myReader;
        conn.Open();
        myReader = SelectCommand.ExecuteReader();
        int count = 0;
        while (myReader.Read())
        {
          count = count + 1;
        }
        if (count == 1)
        {
          if (catBox.Text == "Administrator")
          {
            //this.Hide();
             
            admin f = new admin(userBox.Text);
            f.ShowDialog();
          }
          else if (catBox.Text == "Agent/Employee")
          {
            //this.Hide();
            agent f = new agent(userBox.Text);
            f.ShowDialog();
          }
        }
        else
          MessageBox.Show("Incorrect username/password");
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      catBox.Text = "";
      userBox.Text = "";
      passBox.Text = "";
    }
  }
}
