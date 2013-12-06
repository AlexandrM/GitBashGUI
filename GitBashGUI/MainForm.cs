using ASE.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitBashGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tbGitBashPath.Text = XmlIniStatic.ReadString("Main/GitBashPath");
            tbGitBashArguments.Text = XmlIniStatic.ReadString("Main/GitBashArguments", "--login -i");
            cbAddPasswordsInHistory.Checked = XmlIniStatic.ReadBoolean("Main/AddPasswordsInHistory", false);
            cbSaveUniqueHistory.Checked = XmlIniStatic.ReadBoolean("Main/SaveUniqueHistory", false);
        }

        private void btSaveSettings_Click(object sender, EventArgs e)
        {
            XmlIniStatic.WriteString("Main/GitBashPath", tbGitBashPath.Text);
            XmlIniStatic.WriteString("Main/GitBashArguments", tbGitBashArguments.Text);
            XmlIniStatic.WriteBoolean("Main/AddPasswordsInHistory", cbAddPasswordsInHistory.Checked);
            XmlIniStatic.WriteBoolean("Main/SaveUniqueHistory", cbSaveUniqueHistory.Checked);
        }

        private void btGitBashPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbGitBashPath.Text = openFileDialog1.FileName;
            }
        }

        private void InitTab(string path)
        {
            if (path.Length == 0)
                return;
            if (path[path.Length - 1] != '\\')
                path = path + @"\";
            if (!Directory.Exists(path))
                return;

            this.SuspendLayout();

            GitBashPanel panel = new GitBashPanel();
            panel.Dock = DockStyle.Fill;

            TabPage page = new TabPage();
            page.SuspendLayout();

            int idxL = path.LastIndexOf('\\');
            string text = path.Substring(0, idxL);
            idxL = text.LastIndexOf('\\');
            text = text.Substring(idxL + 1);

            page.Text = text;

            tabControl.TabPages.Insert(tabControl.TabPages.Count - 2, page);

            panel.Init(path);

            tabControl.SelectedTab = page;

            page.Controls.Add(panel);

            this.ResumeLayout(true);
            page.ResumeLayout(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tabs from arg
            if (Program.Args != null)
                if (Program.Args.Length != 0)
                {
                    InitTab(Program.Args[0]);
                    return;
                }

            //Previous from arg
            string[] list = XmlIniStatic.GetPathes("Main/Previous");
            foreach (string item in list)
            {
                InitTab(XmlIniStatic.ReadString("Main/Previous/" + item));
            }

            if (tabControl.SelectedTab.Controls.Count != 0)
                if (tabControl.SelectedTab.Controls[0] is GitBashPanel)
                {
                    (tabControl.SelectedTab.Controls[0] as GitBashPanel).tbCmd1.Focus();
                    (tabControl.SelectedTab.Controls[0] as GitBashPanel).Invalidate();
                }

            if (tabControl.TabCount == 2)
                tabControl.SelectedTab = tabPageSettings;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlIniStatic.Delete("Main/Previous");

            for (int i = 0; i < tabControl.TabPages.Count - 2; i++)
            {
                TabPage page = tabControl.TabPages[i];
                if (page.Controls.Count != 0)
                    if (page.Controls[0] is GitBashPanel)
                    {
                        (page.Controls[0] as GitBashPanel).Close();
                        XmlIniStatic.WriteString("Main/Previous/ID" + i, (page.Controls[0] as GitBashPanel).tbPanelPath.Text);
                    }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl.SelectedTab.Controls.Count != 0)
                if (!(tabControl.SelectedTab.Controls[0] is GitBashPanel))
                    return;

          (tabControl.SelectedTab.Controls[0] as GitBashPanel).KeyUp(e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageAdd)
            {
                DialogResult dr = folderBrowserDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    InitTab(folderBrowserDialog1.SelectedPath);
                }
                else
                {
                    if (tabControl.TabPages.Count == 2)
                        tabControl.SelectedTab = tabPageSettings;
                    else
                        tabControl.SelectedTab = tabControl.TabPages[0];
                }
            }
        }
    }
}
