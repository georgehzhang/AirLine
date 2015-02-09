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
  public partial class admin : Form
  {
    public admin()
    {
      InitializeComponent();
    }

    public admin(string text)
    {
      InitializeComponent();
      adminNameLabel.Text = text;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Choose_Flight f = new Choose_Flight();
        f.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        FlightInfo f = new FlightInfo();
        f.ShowDialog();
    }

    private void admin_Load(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
        CustomerInfo f = new CustomerInfo();
        f.ShowDialog();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        CancelReservation f = new CancelReservation();
        f.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        CustomerCheckIn f = new CustomerCheckIn();
        f.ShowDialog();
    }

 
  }
}
