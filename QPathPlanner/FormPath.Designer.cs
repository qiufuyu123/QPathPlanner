namespace QPathPlanner
{
  partial class FormPath
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPath));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textX = new System.Windows.Forms.TextBox();
      this.textY = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.nodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.设置连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.删除此节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.设置角度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.删除连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.修改位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.设为起点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.nodeMenu.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // pictureBox1
      // 
      resources.ApplyResources(this.pictureBox1, "pictureBox1");
      this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
      this.pictureBox1.Image = global::QPathPlanner.Properties.Resources.FieldPic;
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
      this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
      this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      // 
      // tableLayoutPanel2
      // 
      resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      // 
      // tableLayoutPanel3
      // 
      resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.textX, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.textY, 1, 1);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // textX
      // 
      resources.ApplyResources(this.textX, "textX");
      this.textX.Name = "textX";
      this.textX.ReadOnly = true;
      // 
      // textY
      // 
      resources.ApplyResources(this.textY, "textY");
      this.textY.Name = "textY";
      this.textY.ReadOnly = true;
      // 
      // tableLayoutPanel4
      // 
      resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
      this.tableLayoutPanel4.Controls.Add(this.button1, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.button2, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.button3, 0, 2);
      this.tableLayoutPanel4.Controls.Add(this.button4, 0, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      // 
      // button1
      // 
      resources.ApplyResources(this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      resources.ApplyResources(this.button2, "button2");
      this.button2.Name = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      resources.ApplyResources(this.button3, "button3");
      this.button3.Name = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      resources.ApplyResources(this.button4, "button4");
      this.button4.Name = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // nodeMenu
      // 
      resources.ApplyResources(this.nodeMenu, "nodeMenu");
      this.nodeMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.nodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置连接ToolStripMenuItem,
            this.删除此节点ToolStripMenuItem,
            this.设置角度ToolStripMenuItem,
            this.删除连接ToolStripMenuItem,
            this.修改位置ToolStripMenuItem,
            this.设为起点ToolStripMenuItem});
      this.nodeMenu.Name = "nodeMenu";
      // 
      // 设置连接ToolStripMenuItem
      // 
      resources.ApplyResources(this.设置连接ToolStripMenuItem, "设置连接ToolStripMenuItem");
      this.设置连接ToolStripMenuItem.Name = "设置连接ToolStripMenuItem";
      this.设置连接ToolStripMenuItem.Click += new System.EventHandler(this.设置连接ToolStripMenuItem_Click);
      // 
      // 删除此节点ToolStripMenuItem
      // 
      resources.ApplyResources(this.删除此节点ToolStripMenuItem, "删除此节点ToolStripMenuItem");
      this.删除此节点ToolStripMenuItem.Name = "删除此节点ToolStripMenuItem";
      this.删除此节点ToolStripMenuItem.Click += new System.EventHandler(this.删除此节点ToolStripMenuItem_Click);
      // 
      // 设置角度ToolStripMenuItem
      // 
      resources.ApplyResources(this.设置角度ToolStripMenuItem, "设置角度ToolStripMenuItem");
      this.设置角度ToolStripMenuItem.Name = "设置角度ToolStripMenuItem";
      this.设置角度ToolStripMenuItem.Click += new System.EventHandler(this.设置角度ToolStripMenuItem_Click);
      // 
      // 删除连接ToolStripMenuItem
      // 
      resources.ApplyResources(this.删除连接ToolStripMenuItem, "删除连接ToolStripMenuItem");
      this.删除连接ToolStripMenuItem.Name = "删除连接ToolStripMenuItem";
      this.删除连接ToolStripMenuItem.Click += new System.EventHandler(this.删除连接ToolStripMenuItem_Click);
      // 
      // 修改位置ToolStripMenuItem
      // 
      resources.ApplyResources(this.修改位置ToolStripMenuItem, "修改位置ToolStripMenuItem");
      this.修改位置ToolStripMenuItem.Name = "修改位置ToolStripMenuItem";
      this.修改位置ToolStripMenuItem.Click += new System.EventHandler(this.修改位置ToolStripMenuItem_Click);
      // 
      // 设为起点ToolStripMenuItem
      // 
      resources.ApplyResources(this.设为起点ToolStripMenuItem, "设为起点ToolStripMenuItem");
      this.设为起点ToolStripMenuItem.Name = "设为起点ToolStripMenuItem";
      this.设为起点ToolStripMenuItem.Click += new System.EventHandler(this.设为起点ToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      resources.ApplyResources(this.statusStrip1, "statusStrip1");
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStatus,
            this.toolStripStatusLabel2});
      this.statusStrip1.Name = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      // 
      // toolStatus
      // 
      resources.ApplyResources(this.toolStatus, "toolStatus");
      this.toolStatus.Name = "toolStatus";
      // 
      // toolStripStatusLabel2
      // 
      resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      // 
      // saveFileDialog1
      // 
      resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
      // 
      // menuStrip1
      // 
      resources.ApplyResources(this.menuStrip1, "menuStrip1");
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言ToolStripMenuItem});
      this.menuStrip1.Name = "menuStrip1";
      // 
      // 语言ToolStripMenuItem
      // 
      resources.ApplyResources(this.语言ToolStripMenuItem, "语言ToolStripMenuItem");
      this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
      // 
      // chineseToolStripMenuItem
      // 
      resources.ApplyResources(this.chineseToolStripMenuItem, "chineseToolStripMenuItem");
      this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
      this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
      // 
      // FormPath
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormPath";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPath_FormClosed);
      this.ResizeEnd += new System.EventHandler(this.FormPath_ResizeEnd);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPath_KeyDown);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.nodeMenu.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private TextBox textX;
        private TextBox textY;
        private PictureBox pictureBox1;
    private ContextMenuStrip nodeMenu;
    private ToolStripMenuItem 设置连接ToolStripMenuItem;
    private ToolStripMenuItem 删除此节点ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStatus;
        private ToolStripMenuItem 设置角度ToolStripMenuItem;
        private ToolStripMenuItem 删除连接ToolStripMenuItem;
        private ToolStripMenuItem 修改位置ToolStripMenuItem;
        private ToolStripMenuItem 设为起点ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 语言ToolStripMenuItem;
        private ToolStripMenuItem chineseToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
    }
}