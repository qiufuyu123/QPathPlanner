using System.ComponentModel;
using System.Globalization;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace QPathPlanner
{
  public partial class FormPath : Form
  {
    public FormPath()
    {
      InitializeComponent();
      if(!File.Exists("config.txt"))
      {
        File.WriteAllText("config.txt",global::QPathPlanner.Properties.Resources.config);
      }
      codeConfig = JsonSerializer.Deserialize<PathConfig>(File.ReadAllText("config.txt"));
      
    }
    private string savedPath = "";
    private PathConfig codeConfig;
    static public string destCodes = "";
    private bool isChangePos = false;
    private bool isSetConnet = false;
    private bool mMouseEntered = false;
    private int selectedIdx = -1;
    private double mCursorX = 0;
    private double mCursorY = 0;
    private double mScaleK = 4032 / 144;
    private Random r = new Random();
    private List<PathNode> mPathNodes = new List<PathNode>();
    private Graphics mTopGraph;

    private double coordRevX(double x)
    {
      return (x + 72) * mScaleK * (double)pictureBox1.Width / (double)pictureBox1.Image.Width;
    }
    private double coordRevY(double y)
    {
      return (-y + 72) * mScaleK * (double)pictureBox1.Height / (double)pictureBox1.Image.Height;
    }

    private void updateNodes(Graphics g)
    {
      for(int i = 0;i<mPathNodes.Count;i++)
      {
        PathNode node = mPathNodes[i];
        int realx = (int)coordRevX(node.PosX);
        int realy = (int)coordRevY(node.PosY);
        Color color = Color.FromArgb(node.color[0], node.color[1], node.color[2]);
        if(node.StartPoint)
        {
          g.FillRectangle(new SolidBrush(color), (int)realx - 18, (int)realy - 18, 36, 36);
        }
        else g.FillEllipse(new SolidBrush(color), (int)realx - 10, (int)realy - 10, 20, 20);
        if(node.NextNode != -1)
        {
          PathNode subnode = mPathNodes[node.NextNode];
          g.DrawLine(new Pen(color,10), (int)realx, (int)realy, (int)coordRevX(subnode.PosX), (int)coordRevY(subnode.PosY));
        }
        double rad = (double)(node.Heading-90) * (Math.PI) / 180;
        int dx = (int)(realx + (double)40 * Math.Cos(rad));
        int dy = (int)(realy + (double)40 * Math.Sin(rad));
        if(node.Heading!=-1)
          g.DrawLine(new Pen(Color.Yellow, 5), realx, realy,dx ,dy );
        if (i==selectedIdx)
          g.DrawRectangle(new Pen(Color.Red, 2), realx - 20, realy - 20, 40, 40);
        else
          g.DrawRectangle(new Pen(Color.Yellow, 2), realx - 20, realy - 20, 40, 40);
      }
    }

    private int isNodeExist(int x,int y)
    {
      for(int i =0;i<mPathNodes.Count;i++)
      {
        if (mPathNodes[i].PosX == x && mPathNodes[i].PosY == y)
          return i;
      }
      return -1;
    }
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      double k = 4032 / 144;
      mCursorX =Math.Round((double)pictureBox1.Image.Width / (double)pictureBox1.Width * e.X / mScaleK -72);
      mCursorY =-Math.Round((double)pictureBox1.Image.Height / (double)pictureBox1.Height * e.Y / mScaleK - 72);
      textX.Text = mCursorX.ToString("f1");
      textY.Text = mCursorY.ToString("f1");
      //mTopGraph.Clear(Color.FromArgb(0, 0, 0, 0));
      /*mTopGraph.Dispose();
      pictureBox1.Invalidate();
      mTopGraph = pictureBox1.CreateGraphics();
      mTopGraph.DrawRectangle(new Pen(Color.Green, 2), (int)coordRevX(mCursorX) - 20, (int)coordRevY(mCursorY) - 20, 40, 40);*/
    }

    private void pictureBox1_MouseEnter(object sender, EventArgs e)
    {
      mMouseEntered = true;
    }

    private void pictureBox1_MouseLeave(object sender, EventArgs e)
    {
        mMouseEntered=false;
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
      for(int i =-72;i<72;i+=12)
      {
        e.Graphics.DrawLine(new Pen(Color.LightSkyBlue, 2), (int)coordRevX(i), 0, (int)coordRevX(i), pictureBox1.Height);
        e.Graphics.DrawLine(new Pen(Color.LightSkyBlue, 2), 0,(int)coordRevY(i),pictureBox1.Width,(int)coordRevY(i));
      }
      updateNodes(e.Graphics);
    }

    private void cancelConnet()
    {
      toolStatus.BackColor = Color.White;
      toolStatus.Text = "wait...";
      isSetConnet = false;
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      int realx = (int)coordRevX(mCursorX);
      int realy = (int)coordRevY(mCursorY);
      int idx = isNodeExist((int)mCursorX, (int)mCursorY);
      if (idx != -1)
      {
        if(isChangePos)
        {
          MessageBox.Show("Please choose another point!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        if(isSetConnet && selectedIdx !=-1)
        {
          if(idx == selectedIdx)
          {
            MessageBox.Show("Cannot connect to the node itself£¡", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cancelConnet();
            return;
          }
          else
          {
            mPathNodes[selectedIdx].NextNode = idx;
            cancelConnet();
            pictureBox1.Invalidate();
            selectedIdx = idx;
            return;
          }
        }
        selectedIdx = idx;
        pictureBox1.Invalidate();
        if (e.Button == MouseButtons.Left)
          return;
      }
      if (e.Button == MouseButtons.Left)
      {
        if (isChangePos && selectedIdx != -1)
        {
          mPathNodes[selectedIdx].PosX = (int)mCursorX;
          mPathNodes[selectedIdx].PosY = (int)mCursorY;
          cancelConnet();
          pictureBox1.Invalidate();
          isChangePos= false; 
          return;
        }
        selectedIdx = -1;
        pictureBox1.Invalidate();
        Graphics mGraph = pictureBox1.CreateGraphics();
        int[] c = new int[3];
        c[0] = r.Next(1, 255);
        c[1] = r.Next(1, 255);
        c[2] = r.Next(1, 255);
        Color cc = Color.FromArgb(c[0], c[1], c[2]);
        mGraph.FillEllipse(new SolidBrush(cc), (int)realx - 10, (int)realy - 10, 20, 20);
        mGraph.Dispose();
        mPathNodes.Add(new PathNode((int)mCursorX, (int)mCursorY, c));
        //mGraph.Dispose();
      }
      else if(selectedIdx!=-1)
      {
        nodeMenu.Show(pictureBox1, new Point(realx, realy));
      }
    }

    private void cleanRelativeNode()
    {
      foreach(PathNode node in mPathNodes)
      {
        if(node.NextNode == selectedIdx)
        {
          node.NextNode = -1;
        }
      }
    }

    private void DelNodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cleanRelativeNode();
      mPathNodes.RemoveAt(selectedIdx);
      selectedIdx = -1;
      pictureBox1.Invalidate();
    }

    private void ConnetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if(mPathNodes.Count<=1)
      {
        MessageBox.Show("A path requires at least 2 nodes!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
      if(isSetConnet)
      {
        MessageBox.Show("Already to connect a path!\nPress ESC to cancel", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      isSetConnet = true;
      toolStatus.Text = "Please choose the second point(Press ESC to cancel)";
      toolStatus.BackColor = Color.Yellow;
    }

    private void AngleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string str = Microsoft.VisualBasic.Interaction.InputBox("Please input an integer!\n(input -1 means NO angle required!)", "Set the final status angle", mPathNodes[selectedIdx].Heading.ToString());
      int v = -1;
      if(!int.TryParse(str,out v))
      {
        MessageBox.Show("Bad Format£¡", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        mPathNodes[selectedIdx].Heading = v;
        pictureBox1.Invalidate();
      }

    }

    private void FormPath_ResizeEnd(object sender, EventArgs e)
    {
     
    }

    private void FormPath_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Escape)
      {
        if(isSetConnet)
        {
          cancelConnet();
          pictureBox1.Invalidate();
        }
        if(isChangePos)
        {
          cancelConnet();
        }
      }
    }

    private void DeleteConnectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mPathNodes[selectedIdx].NextNode = -1;
      pictureBox1.Invalidate();
    }

    private void ChangePosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if(isChangePos)
      {
        MessageBox.Show("Already prepared to change position!\nPress ESC to cancel it!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }else
      {
        toolStatus.Text = "Choose a new point(Press ESC to cancel)";
        toolStatus.BackColor = Color.Yellow;
        isChangePos = true;
      }
    }

    private void AsStartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach(PathNode node in mPathNodes)
      {
        if(node.StartPoint)
        {
          node.StartPoint = false;
        }
      }
      mPathNodes[selectedIdx].StartPoint = true;
      pictureBox1.Invalidate();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string fname = "";
      if (savedPath != "")
      {
        fname = savedPath;
      }
      else
      {
        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
          return;
        fname = saveFileDialog1.FileName.ToString();
        savedPath = fname;
      }
      File.WriteAllText(fname, JsonSerializer.Serialize(mPathNodes));
      MessageBox.Show("File Saved!");
     
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      string fname = openFileDialog1.FileName.ToString();
      List<PathNode>?tmp = null;
      try
      {
        tmp= JsonSerializer.Deserialize<List<PathNode>>(File.ReadAllText(fname));
      }
      catch
      {
        tmp = null;
      }
      if(tmp == null)
      {
        MessageBox.Show("Bad Format£¡", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        mPathNodes = tmp;
        pictureBox1.Invalidate();
        savedPath = fname;
      }
    }

    private string genTurn(double angle,double speed)
    {
      return codeConfig.delta.turn.Replace("$angle",angle.ToString("f1")).Replace("$speed",speed.ToString("f1"))+";\n";
    }

    private string genFwd(double angle,double distance,double speed)
    {
      return codeConfig.delta.fwd.Replace("$angle", angle.ToString("f1")).Replace("$speed", speed.ToString("f1")).Replace("$distance",distance.ToString("f1")) + ";\n";
    }

    
    private void genCode()
    {
      destCodes = "";
      PathNode ?headNode=null;
      foreach(PathNode node in mPathNodes)
      {
        if (node.StartPoint)
          headNode = node;
      }
      if(headNode==null)
      {
        MessageBox.Show("Please set START node£¡");
        return;
      }
      if(headNode.NextNode==-1)
      {
        MessageBox.Show("Code Generation requires at least ONE path!");
        return;
      }
      while(true)
      {
        if (headNode.Heading != -1)
        {
          destCodes += genTurn(headNode.Heading, 100);
        }

        if (headNode.NextNode != -1)
        {
          PathNode next = mPathNodes[headNode.NextNode];
          double dx = next.PosX - headNode.PosX;
          double dy = next.PosY - headNode.PosY;
          dx *= 2.54; // inch > cm
          dy *= 2.54;
          double distance = Math.Sqrt(dx * dx + dy * dy);
          double angle = Math.Atan2(-dy,dx) / Math.PI * 180 + 90;
          if (angle > 180)
            angle = -(360 - angle);
          destCodes += genTurn(angle, 100);
          destCodes += genFwd(angle, distance, 100);
          headNode = next;
          //destCodes += "\n//" + dx.ToString() + "," + dy.ToString() + "\n";

        }else
        {
          break;
        }
      }
     
    }
    private void button3_Click(object sender, EventArgs e)
    {
      genCode();
      if (destCodes != "")
      {
        CodeDisplay codeDisplay = new CodeDisplay();
        codeDisplay.ShowDialog();
        destCodes = "";
      }
    }

    private void FormPath_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      MessageBox.Show("This program is desined by qiufuyu\nFrom 123A SFLS(high school)\nContact Me: qiufuyutony@outlook.com\nGithub: qiufuyu123", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }
  }
}