using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TClean
{
    public partial class TClean : Form
    {
        public TClean()
        {
            InitializeComponent();
            string targetdef = "C:\\Users\\" + Environment.UserName + "\\Downloads";
            TargetBox.Text = targetdef;
        }

        private void Analyze_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.GetFiles(TargetBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Target must be a valid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                TargetBox.Focus();
                return;
            }
            Lista.Items.Clear();
            object[] fajlok = Directory.GetFiles(TargetBox.Text, "*.torrent");
            int count = 0;
            if (fajlok.Count() == 0)
            {
                Lista.Items.Add("There are no torrent files!");
            }
            else
            {
                for (int i = 0; i < fajlok.Length; i++)
                {
                    string s = (string)fajlok[i];
                    string szoveg = s.Substring(s.LastIndexOf('\\') + 1);
                    Lista.Items.Add((szoveg));
                    count++;
                    Thread.Sleep(10);
                    Lista.SelectedIndex = count - 1;
                }
                Lista.Items.Add("..");
                Lista.Items.Add("Analyze completed." + count + " items were ready to clean.");
                Lista.Items.Add("");
                Lista.SelectedIndex = count + 2;
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.GetFiles(TargetBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Target must be a valid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                TargetBox.Focus();
                return;
            }
            Lista.Items.Clear();
            object[] fajlok = Directory.GetFiles(TargetBox.Text, "*.torrent");
            if (fajlok.Count() == 0)
            {
                Lista.Items.Add("There are no torrent files!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?\n" + fajlok.Count() + " file(s) will be removed.", "Clean", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    Lista.Items.Add("Aborted..");
                }
                else
                {
                    int count = 0;
                    for (int i = 0; i < fajlok.Length; i++)
                    {
                        string s = (string)fajlok[i];
                        string szoveg = s.Substring(s.LastIndexOf('\\') + 1);
                        Lista.Items.Add((szoveg));
                        File.Delete(s);
                        count++;
                        Thread.Sleep(10);
                        Lista.SelectedIndex = count - 1;
                    }
                    Lista.Items.Add("..");
                    Lista.Items.Add("Cleaning completed." + count + " items were removed.");
                    Lista.Items.Add("");
                    Lista.SelectedIndex = count + 2;
                }
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Selector.ShowDialog();
            if(Selector.SelectedPath != "")
            {
                TargetBox.Text = Selector.SelectedPath;
            }
            

        }
    }
}
