namespace GitBashGUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tbGitBashArguments = new System.Windows.Forms.TextBox();
            this.tbGitBashPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveSettings = new System.Windows.Forms.Button();
            this.btGitBashPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbAddPasswordsInHistory = new System.Windows.Forms.CheckBox();
            this.cbSaveUniqueHistory = new System.Windows.Forms.CheckBox();
            this.tabPageSettings.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.cbSaveUniqueHistory);
            this.tabPageSettings.Controls.Add(this.cbAddPasswordsInHistory);
            this.tabPageSettings.Controls.Add(this.tbGitBashArguments);
            this.tabPageSettings.Controls.Add(this.tbGitBashPath);
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Controls.Add(this.btSaveSettings);
            this.tabPageSettings.Controls.Add(this.btGitBashPath);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1070, 599);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tbGitBashArguments
            // 
            this.tbGitBashArguments.Location = new System.Drawing.Point(125, 31);
            this.tbGitBashArguments.Name = "tbGitBashArguments";
            this.tbGitBashArguments.Size = new System.Drawing.Size(176, 22);
            this.tbGitBashArguments.TabIndex = 3;
            // 
            // tbGitBashPath
            // 
            this.tbGitBashPath.Location = new System.Drawing.Point(125, 6);
            this.tbGitBashPath.Name = "tbGitBashPath";
            this.tbGitBashPath.Size = new System.Drawing.Size(435, 22);
            this.tbGitBashPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Git Bash arguments:";
            // 
            // btSaveSettings
            // 
            this.btSaveSettings.Location = new System.Drawing.Point(462, 99);
            this.btSaveSettings.Name = "btSaveSettings";
            this.btSaveSettings.Size = new System.Drawing.Size(139, 23);
            this.btSaveSettings.TabIndex = 15;
            this.btSaveSettings.Text = "Save settings";
            this.btSaveSettings.UseVisualStyleBackColor = true;
            this.btSaveSettings.Click += new System.EventHandler(this.btSaveSettings_Click);
            // 
            // btGitBashPath
            // 
            this.btGitBashPath.Location = new System.Drawing.Point(566, 6);
            this.btGitBashPath.Name = "btGitBashPath";
            this.btGitBashPath.Size = new System.Drawing.Size(35, 22);
            this.btGitBashPath.TabIndex = 2;
            this.btGitBashPath.Text = "...";
            this.btGitBashPath.UseVisualStyleBackColor = true;
            this.btGitBashPath.Click += new System.EventHandler(this.btGitBashPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git Bash path:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAdd);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1078, 625);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1070, 599);
            this.tabPageAdd.TabIndex = 2;
            this.tabPageAdd.Text = "Add console";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "sh.exe";
            this.openFileDialog1.Filter = "Exe files|*.exe";
            // 
            // cbAddPasswordsInHistory
            // 
            this.cbAddPasswordsInHistory.AutoSize = true;
            this.cbAddPasswordsInHistory.Location = new System.Drawing.Point(11, 59);
            this.cbAddPasswordsInHistory.Name = "cbAddPasswordsInHistory";
            this.cbAddPasswordsInHistory.Size = new System.Drawing.Size(156, 17);
            this.cbAddPasswordsInHistory.TabIndex = 16;
            this.cbAddPasswordsInHistory.Text = "Add passwords in history";
            this.cbAddPasswordsInHistory.UseVisualStyleBackColor = true;
            // 
            // cbSaveUniqueHistory
            // 
            this.cbSaveUniqueHistory.AutoSize = true;
            this.cbSaveUniqueHistory.Location = new System.Drawing.Point(173, 59);
            this.cbSaveUniqueHistory.Name = "cbSaveUniqueHistory";
            this.cbSaveUniqueHistory.Size = new System.Drawing.Size(182, 17);
            this.cbSaveUniqueHistory.TabIndex = 17;
            this.cbSaveUniqueHistory.Text = "Save only unique history items";
            this.cbSaveUniqueHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 625);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Git Bash GUI by Alexandr Sulimov 2012";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TextBox tbGitBashArguments;
        private System.Windows.Forms.TextBox tbGitBashPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSaveSettings;
        private System.Windows.Forms.Button btGitBashPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox cbAddPasswordsInHistory;
        private System.Windows.Forms.CheckBox cbSaveUniqueHistory;
    }
}

