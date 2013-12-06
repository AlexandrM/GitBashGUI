using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ASE.Xml;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace GitBashGUI
{
    public partial class GitBashPanel : UserControl
    {
        public GitBashPanel()
        {
            InitializeComponent();
        }

        private void GitBashPanel_Load(object sender, EventArgs e)
        {
            tbCmd3.Focus();
        }

        public void Close()
        {
            try
            {
                proc.Kill();
            }
            catch
            {
            }
            
            if (Directory.Exists(tbPanelPath.Text))
            {
                XmlIni ini = new XmlIni(tbPanelPath.Text + ".bashgui.xml");
                ini.WriteInt("Main", "ConsoleWidth", splitLeft.Panel1.Width);
                ini.WriteInt("Main", "ConsoleHeight", splitLeft.Panel1.Height);

                ini.Delete("History");
                for (int i = 0; i < history.Items.Count; i++)
                {
                    int id = history.Items.Count - i - 1;
                    string item = history.Items[id].ToString();
                    
                    if ((XmlIniStatic.ReadBoolean("Main/SaveUniqueHistory", false)) && (history.Items.IndexOf(item) > id))
                        continue;
                    if (String.IsNullOrWhiteSpace(item))
                        continue;

                    ini.WriteString("History/ID" + id, item);
                }
            }
        }

        Process proc;
        public void Init(string workingDirectory)
        {
            try
            {
                tbPanelPath.Text = workingDirectory;
                if (File.Exists(tbPanelPath.Text + ".bashgui.xml"))
                {
                    XmlIni ini = new XmlIni(tbPanelPath.Text + ".bashgui.xml");
                    string[] lines = ini.GetPathes("History");
                    Array.Sort(lines, lines, StringComparer.InvariantCulture);
                    Array.Reverse(lines);
                    foreach (string item in lines)
                        history.Items.Add(ini.ReadString("History/" + item));

                    if (history.Items.Count != 0)
                        history.SelectedIndex = history.Items.Count - 1;

                    int i = XmlIniStatic.ReadInt("Main", "ConsoleWidth", 0);
                    if (i != 0)
                        splitLeft.Panel1.Width = i;
                    
                    i = XmlIniStatic.ReadInt("Main", "ConsoleHeight", 0);
                    if (i != 0)
                        splitLeft2.Panel1.Height = i;
                }

                if ((history.Items.Count - 8) > 0) tbCmd9.Text = history.Items[history.Items.Count - 9].ToString();
                if ((history.Items.Count - 7) > 0) tbCmd8.Text = history.Items[history.Items.Count - 8].ToString();
                if ((history.Items.Count - 6) > 0) tbCmd7.Text = history.Items[history.Items.Count - 7].ToString();
                if ((history.Items.Count - 5) > 0) tbCmd6.Text = history.Items[history.Items.Count - 6].ToString();
                if ((history.Items.Count - 4) > 0) tbCmd5.Text = history.Items[history.Items.Count - 5].ToString();
                if ((history.Items.Count - 3) > 0) tbCmd4.Text = history.Items[history.Items.Count - 4].ToString();
                if ((history.Items.Count - 2) > 0) tbCmd3.Text = history.Items[history.Items.Count - 3].ToString();
                if ((history.Items.Count - 1) > 0) tbCmd2.Text = history.Items[history.Items.Count - 2].ToString();
                if ((history.Items.Count - 0) > 0) tbCmd1.Text = history.Items[history.Items.Count - 1].ToString();

                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = XmlIniStatic.ReadString("Main/GitBashPath");
                proc.StartInfo.Arguments = XmlIniStatic.ReadString("Main/GitBashArguments");
                proc.StartInfo.WorkingDirectory = tbPanelPath.Text;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.CreateNoWindow = false;

                proc.Start();

                int count = 0;
                while (proc.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(50);
                    count++;
                    if (count == 50)
                        return;
                }

                DllImport.AttachConsole(proc.Id);
                uint mode;
                IntPtr cHandleO = DllImport.GetStdHandle(-10);
                DllImport.GetConsoleMode(cHandleO, out mode);
                mode |= DllImport.ENABLE_QUICK_EDIT_MODE;
                DllImport.SetConsoleMode(cHandleO, mode);
                DllImport.FreeConsole();

                DllImport.SetParent(proc.MainWindowHandle, panelConsole.Handle);
                DllImport.SendMessage(proc.MainWindowHandle, 0x0112, 0xF030, 0);
                DllImport.SetWindowPos(proc.MainWindowHandle, IntPtr.Zero, 0, 0, panelConsole.Width, panelConsole.Height, 0x0040);
                DllImport.SetWindowLong(proc.MainWindowHandle, -16, 0x10000000 | 0x00200000);

                DllImport.SetForegroundWindow(this.Handle);
            }
            catch
            {
                return;
            }
        }


        private void panelConsole_Resize(object sender, EventArgs e)
        {
            if (proc != null)
                DllImport.SetWindowPos(proc.MainWindowHandle, IntPtr.Zero, 0, 0, panelConsole.Width, panelConsole.Height, 0x0040);
        }

        public void KeyUp(KeyEventArgs e)
        {
            if (e.Control)
            {
                e.Handled = true;
                if (e.KeyCode == Keys.D1)      btCmd1.PerformClick();
                else if (e.KeyCode == Keys.D2) btCmd2.PerformClick();
                else if (e.KeyCode == Keys.D3) btCmd3.PerformClick();
                else if (e.KeyCode == Keys.D4) btCmd4.PerformClick();
                else if (e.KeyCode == Keys.D5) btCmd5.PerformClick();
                else if (e.KeyCode == Keys.D6) btCmd6.PerformClick();
                else if (e.KeyCode == Keys.D7) btCmd7.PerformClick();
                else if (e.KeyCode == Keys.D8) btCmd8.PerformClick();
                else if (e.KeyCode == Keys.D9) btCmd9.PerformClick();
                else
                    e.Handled = false;
            }
            if (e.KeyCode == Keys.F1) tbCmd1.Focus();
            if (e.KeyCode == Keys.F2) tbCmd2.Focus();
            if (e.KeyCode == Keys.F3) tbCmd3.Focus();
            if (e.KeyCode == Keys.F4) tbCmd4.Focus();
            if (e.KeyCode == Keys.F5) tbCmd5.Focus();
            if (e.KeyCode == Keys.F6) tbCmd6.Focus();
            if (e.KeyCode == Keys.F7) tbCmd7.Focus();
            if (e.KeyCode == Keys.F8) tbCmd8.Focus();
            if (e.KeyCode == Keys.F9) tbCmd9.Focus();
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            if (proc != null)
            {
                proc.Kill();
            }

            Init(tbPanelPath.Text);
        }

        private DllImport.INPUT_RECORD[] Keys_CtrlC()
        {
            DllImport.INPUT_RECORD[] rec = new DllImport.INPUT_RECORD[1];

            rec[0].EventType = 0x0001;
            rec[0].KeyEvent = new DllImport.KEY_EVENT_RECORD();
            rec[0].KeyEvent.bKeyDown = true;
            rec[0].KeyEvent.dwControlKeyState = 0x0008;
            rec[0].KeyEvent.UnicodeChar = 'C';
            rec[0].KeyEvent.wRepeatCount = 1;
            rec[0].KeyEvent.wVirtualKeyCode = 'C';
            rec[0].KeyEvent.wVirtualScanCode = (ushort)DllImport.MapVirtualKey(0x43, 0);

            return rec;
        }

        private DllImport.INPUT_RECORD[] PrepareData(string data)
        {
            DllImport.INPUT_RECORD[] rec = new DllImport.INPUT_RECORD[data.Length + 1];
            //Text
            for (int i = 0; i < data.Length; i++)
            {
                rec[i].EventType = 0x0001;
                rec[i].KeyEvent = new DllImport.KEY_EVENT_RECORD();
                rec[i].KeyEvent.bKeyDown = true;
                rec[i].KeyEvent.dwControlKeyState = 0;
                rec[i].KeyEvent.UnicodeChar = data[i];
                rec[i].KeyEvent.wRepeatCount = 1;
                rec[i].KeyEvent.wVirtualKeyCode = data[i];
                rec[i].KeyEvent.wVirtualScanCode = (ushort) DllImport.MapVirtualKey(data[i], 0);
            }
            //Return
            rec[data.Length].EventType = 0x0001;
            rec[data.Length].KeyEvent = new DllImport.KEY_EVENT_RECORD();
            rec[data.Length].KeyEvent.bKeyDown = true;
            rec[data.Length].KeyEvent.dwControlKeyState = 0;
            rec[data.Length].KeyEvent.UnicodeChar = '\n';
            rec[data.Length].KeyEvent.wRepeatCount = 1;
            rec[data.Length].KeyEvent.wVirtualKeyCode = '\n';
            rec[data.Length].KeyEvent.wVirtualScanCode = (ushort) DllImport.MapVirtualKey(0x0D, 0);

            return rec;
        }

        private void AddInHistory(string item)
        {
            if (String.IsNullOrWhiteSpace(item))
                return;

            if (!XmlIniStatic.ReadBoolean("Main/AddPasswordsInHistory", false))
            {
                int idx1 = item.IndexOf(":");
                int idx2 = item.IndexOf("@");
                if (idx2 > idx1)
                    return;
            }

            if (history.Items.Count == 0)
                history.Items.Add(item);
            else if (history.Items[history.Items.Count - 1].ToString() != item)
                history.Items.Add(item);

            if (history.Items.Count != 0)
                history.SelectedIndex = history.Items.Count - 1;            
        }

        private void RunCommand(object sender, EventArgs e)
        {
            TextBox tb = tbCmd1;
            if (sender == btCmd2) tb = tbCmd2;
            else if (sender == btCmd3) tb = tbCmd3;
            else if (sender == btCmd4) tb = tbCmd4;
            else if (sender == btCmd5) tb = tbCmd5;
            else if (sender == btCmd6) tb = tbCmd6;
            else if (sender == btCmd7) tb = tbCmd7;
            else if (sender == btCmd8) tb = tbCmd8;
            else if (sender == btCmd9) tb = tbCmd9;

            AddInHistory(tb.Text);

            //DllImport.AttachConsole(proc.Id);
            //IntPtr cHandleI = DllImport.GetStdHandle(-10);
            //DllImport.SetForegroundWindow(cHandleI);
            SendKeys.Send("^C");
            //SendKeys.Send(tb.Text + "~");
            //Thread.Sleep(200);

            uint count = 0;
            DllImport.AttachConsole(proc.Id);
            IntPtr cHandleI = DllImport.GetStdHandle(-10);

            DllImport.INPUT_RECORD[] data = PrepareData(tb.Text);
            DllImport.WriteConsoleInput(cHandleI, data, data.Length, out count);
            
            DllImport.FreeConsole();

            if (tb == tbCmd1) tb = tbCmd2;
            else if (tb == tbCmd2) tb = tbCmd3;
            else if (tb == tbCmd3) tb = tbCmd4;
            else if (tb == tbCmd4) tb = tbCmd5;
            else if (tb == tbCmd5) tb = tbCmd6;
            else if (tb == tbCmd6) tb = tbCmd7;
            else if (tb == tbCmd7) tb = tbCmd8;
            else if (tb == tbCmd8) tb = tbCmd9;
            else if (tb == tbCmd9) tb = tbCmd1;

            tb.Focus();
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void tbCmdKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;

            e.Handled = true;

            Button bt = btCmd1;
            if (sender == tbCmd2) bt = btCmd2;
            else if (sender == tbCmd3) bt = btCmd3;
            else if (sender == tbCmd4) bt = btCmd4;
            else if (sender == tbCmd5) bt = btCmd5;
            else if (sender == tbCmd6) bt = btCmd6;
            else if (sender == tbCmd7) bt = btCmd7;
            else if (sender == tbCmd8) bt = btCmd8;
            else if (sender == tbCmd9) bt = btCmd9;

            bt.PerformClick();
        }

        private void history_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!history.Focused) || (history.SelectedIndex < 0))
                return;

            int idx = history.SelectedIndex;
            tbCmd1.Text = history.Items[idx].ToString();
            tbCmd1.Focus();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            string file = tbPanelPath.Text + ".git\\config";
            rtbFile.LoadFile(file, RichTextBoxStreamType.PlainText);
            rtbFile.Tag = file;
        }

        private void btGitIgnore_Click(object sender, EventArgs e)
        {
            string file = tbPanelPath.Text + ".gitignore";
            if (!File.Exists(file))
            {
                StreamWriter sw = File.CreateText(file);
                sw.Close();
            }
            rtbFile.LoadFile(file, RichTextBoxStreamType.PlainText);
            rtbFile.Tag = file;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (rtbFile.Tag == null)
                return;

            rtbFile.SaveFile(rtbFile.Tag.ToString(), RichTextBoxStreamType.PlainText);
        }

        private void btChangePath_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbPanelPath.Text))
                folderBrowserDialog1.SelectedPath = tbPanelPath.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                tbPanelPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btCloseTab_Click(object sender, EventArgs e)
        {
            Close();
            TabPage page = (this.Parent as TabPage);
            (page.Parent as TabControl).TabPages.Remove(page);
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (history.SelectedIndex != -1)
                history.Items.RemoveAt(history.SelectedIndex);
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            if (history.SelectedIndex != -1)
                Clipboard.SetText(history.Items[history.SelectedIndex].ToString());
        }   
    }
}
