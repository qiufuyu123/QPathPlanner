using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPathPlanner
{
  public partial class Welcome : Form
  {
    public Welcome()
    {
      InitializeComponent();
    }
    private int timepassed = 0;
    FormPath formMain = new FormPath();
        private void Welcome_Load(object sender, EventArgs e)
        {
      timer1.Enabled = true;
        }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timepassed++;
      if(timepassed>=2)
      {
        timer1.Enabled = false;
        formMain.Show();
        this.Hide();
      }
    }
  }
}
