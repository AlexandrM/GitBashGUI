namespace GitBashGUI
{
    partial class GitBashPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.splitLeft2 = new System.Windows.Forms.SplitContainer();
            this.panelConsole = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPanelPath = new System.Windows.Forms.TextBox();
            this.btChangePath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btCloseTab = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbCmd9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btCmd9 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbCmd8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btCmd8 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbCmd7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btCmd7 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbCmd6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCmd6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbCmd5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCmd5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCmd4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCmd4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCmd3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCmd3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCmd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCmd2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCmd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCmd1 = new System.Windows.Forms.Button();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btGitIgnore = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmenuHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft2)).BeginInit();
            this.splitLeft2.Panel1.SuspendLayout();
            this.splitLeft2.Panel2.SuspendLayout();
            this.splitLeft2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmenuHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.splitLeft2);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.rtbFile);
            this.splitLeft.Panel2.Controls.Add(this.btSave);
            this.splitLeft.Panel2.Controls.Add(this.btGitIgnore);
            this.splitLeft.Panel2.Controls.Add(this.btConfig);
            this.splitLeft.Panel2.Controls.Add(this.history);
            this.splitLeft.Size = new System.Drawing.Size(893, 617);
            this.splitLeft.SplitterDistance = 577;
            this.splitLeft.TabIndex = 0;
            // 
            // splitLeft2
            // 
            this.splitLeft2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft2.Location = new System.Drawing.Point(0, 0);
            this.splitLeft2.Name = "splitLeft2";
            this.splitLeft2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft2.Panel1
            // 
            this.splitLeft2.Panel1.Controls.Add(this.panelConsole);
            this.splitLeft2.Panel1.Controls.Add(this.panel6);
            // 
            // splitLeft2.Panel2
            // 
            this.splitLeft2.Panel2.Controls.Add(this.panel10);
            this.splitLeft2.Panel2.Controls.Add(this.panel9);
            this.splitLeft2.Panel2.Controls.Add(this.panel8);
            this.splitLeft2.Panel2.Controls.Add(this.panel7);
            this.splitLeft2.Panel2.Controls.Add(this.panel5);
            this.splitLeft2.Panel2.Controls.Add(this.panel4);
            this.splitLeft2.Panel2.Controls.Add(this.panel3);
            this.splitLeft2.Panel2.Controls.Add(this.panel2);
            this.splitLeft2.Panel2.Controls.Add(this.panel1);
            this.splitLeft2.Size = new System.Drawing.Size(577, 617);
            this.splitLeft2.SplitterDistance = 343;
            this.splitLeft2.TabIndex = 0;
            // 
            // panelConsole
            // 
            this.panelConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsole.Location = new System.Drawing.Point(0, 22);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(577, 321);
            this.panelConsole.TabIndex = 6;
            this.panelConsole.Resize += new System.EventHandler(this.panelConsole_Resize);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPanelPath);
            this.panel6.Controls.Add(this.btChangePath);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.btCloseTab);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(577, 22);
            this.panel6.TabIndex = 5;
            // 
            // tbPanelPath
            // 
            this.tbPanelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanelPath.Location = new System.Drawing.Point(175, 0);
            this.tbPanelPath.Name = "tbPanelPath";
            this.tbPanelPath.Size = new System.Drawing.Size(365, 20);
            this.tbPanelPath.TabIndex = 1;
            // 
            // btChangePath
            // 
            this.btChangePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.btChangePath.Location = new System.Drawing.Point(540, 0);
            this.btChangePath.Name = "btChangePath";
            this.btChangePath.Size = new System.Drawing.Size(37, 22);
            this.btChangePath.TabIndex = 2;
            this.btChangePath.Text = "...";
            this.btChangePath.UseVisualStyleBackColor = true;
            this.btChangePath.Click += new System.EventHandler(this.btChangePath_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(75, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current path:";
            // 
            // btCloseTab
            // 
            this.btCloseTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCloseTab.Location = new System.Drawing.Point(0, 0);
            this.btCloseTab.Name = "btCloseTab";
            this.btCloseTab.Size = new System.Drawing.Size(75, 22);
            this.btCloseTab.TabIndex = 3;
            this.btCloseTab.Text = "Close tab";
            this.btCloseTab.UseVisualStyleBackColor = true;
            this.btCloseTab.Click += new System.EventHandler(this.btCloseTab_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbCmd9);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.btCmd9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 232);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(577, 29);
            this.panel10.TabIndex = 8;
            // 
            // tbCmd9
            // 
            this.tbCmd9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd9.Location = new System.Drawing.Point(133, 0);
            this.tbCmd9.Name = "tbCmd9";
            this.tbCmd9.Size = new System.Drawing.Size(321, 29);
            this.tbCmd9.TabIndex = 5;
            this.tbCmd9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Command 9 (F9)";
            // 
            // btCmd9
            // 
            this.btCmd9.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd9.Location = new System.Drawing.Point(454, 0);
            this.btCmd9.Name = "btCmd9";
            this.btCmd9.Size = new System.Drawing.Size(123, 29);
            this.btCmd9.TabIndex = 3;
            this.btCmd9.TabStop = false;
            this.btCmd9.Text = "Run (Ctrl + 9)";
            this.btCmd9.UseVisualStyleBackColor = true;
            this.btCmd9.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbCmd8);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.btCmd8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 203);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(577, 29);
            this.panel9.TabIndex = 7;
            // 
            // tbCmd8
            // 
            this.tbCmd8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd8.Location = new System.Drawing.Point(133, 0);
            this.tbCmd8.Name = "tbCmd8";
            this.tbCmd8.Size = new System.Drawing.Size(321, 29);
            this.tbCmd8.TabIndex = 5;
            this.tbCmd8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Command 8 (F8)";
            // 
            // btCmd8
            // 
            this.btCmd8.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd8.Location = new System.Drawing.Point(454, 0);
            this.btCmd8.Name = "btCmd8";
            this.btCmd8.Size = new System.Drawing.Size(123, 29);
            this.btCmd8.TabIndex = 3;
            this.btCmd8.TabStop = false;
            this.btCmd8.Text = "Run (Ctrl + 8)";
            this.btCmd8.UseVisualStyleBackColor = true;
            this.btCmd8.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbCmd7);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.btCmd7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 174);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(577, 29);
            this.panel8.TabIndex = 6;
            // 
            // tbCmd7
            // 
            this.tbCmd7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd7.Location = new System.Drawing.Point(133, 0);
            this.tbCmd7.Name = "tbCmd7";
            this.tbCmd7.Size = new System.Drawing.Size(321, 29);
            this.tbCmd7.TabIndex = 5;
            this.tbCmd7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Command 7 (F7)";
            // 
            // btCmd7
            // 
            this.btCmd7.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd7.Location = new System.Drawing.Point(454, 0);
            this.btCmd7.Name = "btCmd7";
            this.btCmd7.Size = new System.Drawing.Size(123, 29);
            this.btCmd7.TabIndex = 3;
            this.btCmd7.TabStop = false;
            this.btCmd7.Text = "Run (Ctrl + 7)";
            this.btCmd7.UseVisualStyleBackColor = true;
            this.btCmd7.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbCmd6);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btCmd6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(577, 29);
            this.panel7.TabIndex = 5;
            // 
            // tbCmd6
            // 
            this.tbCmd6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd6.Location = new System.Drawing.Point(133, 0);
            this.tbCmd6.Name = "tbCmd6";
            this.tbCmd6.Size = new System.Drawing.Size(321, 29);
            this.tbCmd6.TabIndex = 5;
            this.tbCmd6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Command 6 (F6)";
            // 
            // btCmd6
            // 
            this.btCmd6.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd6.Location = new System.Drawing.Point(454, 0);
            this.btCmd6.Name = "btCmd6";
            this.btCmd6.Size = new System.Drawing.Size(123, 29);
            this.btCmd6.TabIndex = 3;
            this.btCmd6.TabStop = false;
            this.btCmd6.Text = "Run (Ctrl + 6)";
            this.btCmd6.UseVisualStyleBackColor = true;
            this.btCmd6.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbCmd5);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btCmd5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 29);
            this.panel5.TabIndex = 4;
            // 
            // tbCmd5
            // 
            this.tbCmd5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd5.Location = new System.Drawing.Point(133, 0);
            this.tbCmd5.Name = "tbCmd5";
            this.tbCmd5.Size = new System.Drawing.Size(321, 29);
            this.tbCmd5.TabIndex = 5;
            this.tbCmd5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Command 5 (F5)";
            // 
            // btCmd5
            // 
            this.btCmd5.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd5.Location = new System.Drawing.Point(454, 0);
            this.btCmd5.Name = "btCmd5";
            this.btCmd5.Size = new System.Drawing.Size(123, 29);
            this.btCmd5.TabIndex = 3;
            this.btCmd5.TabStop = false;
            this.btCmd5.Text = "Run (Ctrl + 5)";
            this.btCmd5.UseVisualStyleBackColor = true;
            this.btCmd5.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCmd4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btCmd4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 29);
            this.panel4.TabIndex = 3;
            // 
            // tbCmd4
            // 
            this.tbCmd4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd4.Location = new System.Drawing.Point(133, 0);
            this.tbCmd4.Name = "tbCmd4";
            this.tbCmd4.Size = new System.Drawing.Size(321, 29);
            this.tbCmd4.TabIndex = 4;
            this.tbCmd4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Command 4 (F4)";
            // 
            // btCmd4
            // 
            this.btCmd4.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd4.Location = new System.Drawing.Point(454, 0);
            this.btCmd4.Name = "btCmd4";
            this.btCmd4.Size = new System.Drawing.Size(123, 29);
            this.btCmd4.TabIndex = 3;
            this.btCmd4.TabStop = false;
            this.btCmd4.Text = "Run (Ctrl + 4)";
            this.btCmd4.UseVisualStyleBackColor = true;
            this.btCmd4.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbCmd3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btCmd3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 29);
            this.panel3.TabIndex = 2;
            // 
            // tbCmd3
            // 
            this.tbCmd3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd3.Location = new System.Drawing.Point(133, 0);
            this.tbCmd3.Name = "tbCmd3";
            this.tbCmd3.Size = new System.Drawing.Size(321, 29);
            this.tbCmd3.TabIndex = 3;
            this.tbCmd3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Command 3 (F3)";
            // 
            // btCmd3
            // 
            this.btCmd3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd3.Location = new System.Drawing.Point(454, 0);
            this.btCmd3.Name = "btCmd3";
            this.btCmd3.Size = new System.Drawing.Size(123, 29);
            this.btCmd3.TabIndex = 3;
            this.btCmd3.TabStop = false;
            this.btCmd3.Text = "Run (Ctrl + 3)";
            this.btCmd3.UseVisualStyleBackColor = true;
            this.btCmd3.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbCmd2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btCmd2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 29);
            this.panel2.TabIndex = 1;
            // 
            // tbCmd2
            // 
            this.tbCmd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd2.Location = new System.Drawing.Point(133, 0);
            this.tbCmd2.Name = "tbCmd2";
            this.tbCmd2.Size = new System.Drawing.Size(321, 29);
            this.tbCmd2.TabIndex = 2;
            this.tbCmd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Command 2 (F2)";
            // 
            // btCmd2
            // 
            this.btCmd2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd2.Location = new System.Drawing.Point(454, 0);
            this.btCmd2.Name = "btCmd2";
            this.btCmd2.Size = new System.Drawing.Size(123, 29);
            this.btCmd2.TabIndex = 3;
            this.btCmd2.TabStop = false;
            this.btCmd2.Text = "Run (Ctrl + 2)";
            this.btCmd2.UseVisualStyleBackColor = true;
            this.btCmd2.Click += new System.EventHandler(this.RunCommand);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCmd1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btCmd1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 29);
            this.panel1.TabIndex = 0;
            // 
            // tbCmd1
            // 
            this.tbCmd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCmd1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCmd1.Location = new System.Drawing.Point(133, 0);
            this.tbCmd1.Name = "tbCmd1";
            this.tbCmd1.Size = new System.Drawing.Size(321, 29);
            this.tbCmd1.TabIndex = 1;
            this.tbCmd1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCmdKeyUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command 1 (F1)";
            // 
            // btCmd1
            // 
            this.btCmd1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCmd1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCmd1.Location = new System.Drawing.Point(454, 0);
            this.btCmd1.Name = "btCmd1";
            this.btCmd1.Size = new System.Drawing.Size(123, 29);
            this.btCmd1.TabIndex = 3;
            this.btCmd1.TabStop = false;
            this.btCmd1.Text = "Run (Ctrl + 1)";
            this.btCmd1.UseVisualStyleBackColor = true;
            this.btCmd1.Click += new System.EventHandler(this.RunCommand);
            // 
            // rtbFile
            // 
            this.rtbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFile.Location = new System.Drawing.Point(0, 349);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(312, 245);
            this.rtbFile.TabIndex = 3;
            this.rtbFile.Text = "";
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSave.Location = new System.Drawing.Point(0, 594);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(312, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btGitIgnore
            // 
            this.btGitIgnore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGitIgnore.Location = new System.Drawing.Point(0, 326);
            this.btGitIgnore.Name = "btGitIgnore";
            this.btGitIgnore.Size = new System.Drawing.Size(312, 23);
            this.btGitIgnore.TabIndex = 2;
            this.btGitIgnore.Text = ".gitignore";
            this.btGitIgnore.UseVisualStyleBackColor = true;
            this.btGitIgnore.Click += new System.EventHandler(this.btGitIgnore_Click);
            // 
            // btConfig
            // 
            this.btConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConfig.Location = new System.Drawing.Point(0, 303);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(312, 23);
            this.btConfig.TabIndex = 1;
            this.btConfig.Text = "config";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // history
            // 
            this.history.Dock = System.Windows.Forms.DockStyle.Top;
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(312, 303);
            this.history.TabIndex = 0;
            this.history.SelectedIndexChanged += new System.EventHandler(this.history_SelectedIndexChanged);
            // 
            // cmenuHistory
            // 
            this.cmenuHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDelete,
            this.miCopy});
            this.cmenuHistory.Name = "cmenuHistory";
            this.cmenuHistory.Size = new System.Drawing.Size(108, 48);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(107, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(107, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // GitBashPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLeft);
            this.Name = "GitBashPanel";
            this.Size = new System.Drawing.Size(893, 617);
            this.Load += new System.EventHandler(this.GitBashPanel_Load);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.splitLeft2.Panel1.ResumeLayout(false);
            this.splitLeft2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft2)).EndInit();
            this.splitLeft2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmenuHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.SplitContainer splitLeft2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCmd5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCmd4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCmd3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCmd2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCmd1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btChangePath;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbCmd5;
        public System.Windows.Forms.TextBox tbCmd4;
        public System.Windows.Forms.TextBox tbCmd3;
        public System.Windows.Forms.TextBox tbCmd2;
        public System.Windows.Forms.TextBox tbCmd1;
        private System.Windows.Forms.ListBox history;
        public System.Windows.Forms.TextBox tbPanelPath;
        private System.Windows.Forms.Button btGitIgnore;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panelConsole;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btCloseTab;
        private System.Windows.Forms.ContextMenuStrip cmenuHistory;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.TextBox tbCmd9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btCmd9;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox tbCmd8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCmd8;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbCmd7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCmd7;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox tbCmd6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCmd6;
    }
}
