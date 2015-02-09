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
  public partial class agent : Form
  {
    public agent()
    {
      InitializeComponent();
    }

    public agent(string text)
    {
      InitializeComponent();
      agentNameLabel.Text = text;
    }

    private void label1_Click(object sender, EventArgs e)
    {
     
    }

    private void agent_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Choose_Flight f = new Choose_Flight();
        f.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        CustomerInfo a = new CustomerInfo();
        a.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
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
