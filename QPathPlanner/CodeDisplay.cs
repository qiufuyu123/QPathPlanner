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
  public partial class CodeDisplay : Form
  {
    public CodeDisplay()
    {
      InitializeComponent();
    }

        private void CodeDisplay_Load(object sender, EventArgs e)
        {
      richTextBox1.Text = FormPath.destCodes;
        }
    }
}
