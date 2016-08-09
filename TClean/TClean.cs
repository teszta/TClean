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
            int osszeg = 0;
            int to = 0;
            int oo = 0;
            string[] Tfajlok = new string[Directory.GetFiles(TargetBox.Text, "*.torrent").Length];
            string[] Ofajlok = new string[Directory.GetFiles(TargetBox.Text, "*" + OwnextTB.Text).Length];
            if (TorrentCB.Checked)
            {
                Tfajlok = Directory.GetFiles(TargetBox.Text, "*.torrent");
                osszeg += Tfajlok.Count();
                to = Tfajlok.Count();
            }
            if (OwnextCB.Checked)
            {
                if (OwnextTB.Text == "")
                {
                    MessageBox.Show("Type an extension first. (eg.: .mp3 , .mp4 , .mkv)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    Lista.Items.Add("Extension missing.. Aborted.");
                    return;
                }
                Ofajlok = Directory.GetFiles(TargetBox.Text, "*" + OwnextTB.Text);
                osszeg += Ofajlok.Count();
                oo = Ofajlok.Count();
            }
            if (!TorrentCB.Checked && !OwnextCB.Checked)
            {
                MessageBox.Show("You must choose at least one extension!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Lista.Items.Add("Extension missing.. Aborted.");
                return;
            }
            int count = 0;
            if (osszeg == 0)
            {
                Lista.Items.Add("No matchable file found!");
            }
            else
            {
                string[] Fajlist = new string[osszeg];
                int cv = 0;
                int cvo = 0;
                for (int i = 0; i < Fajlist.Length; i++)
                {

                    if (OwnextCB.Checked && Ofajlok.Count() != 0 && cvo != -1)
                    {
                        Fajlist[i] = Ofajlok[cvo];
                        if (cvo != Ofajlok.Count() - 1)
                        {
                            cvo++;
                        }
                        else
                        {
                            cvo = -1;
                        }
                    }

                }
                if (TorrentCB.Checked)
                {
                    for (int i = osszeg - to; i < Fajlist.Length; i++)
                    {
                        if (TorrentCB.Checked && Tfajlok.Count() != 0 && cv != -1)
                        {
                            Fajlist[i] = Tfajlok[cv];
                            if (cv != Tfajlok.Count() - 1)
                            {
                                cv++;
                            }
                            else
                            {
                                cv = -1;
                            }

                        }
                    }

                }

                for (int i = 0; i < Fajlist.Length; i++)
                {
                    string s = Fajlist[i];
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
            int osszeg = 0;
            int to = 0;
            int oo = 0;
            string[] Tfajlok = new string[Directory.GetFiles(TargetBox.Text, "*.torrent").Length];
            string[] Ofajlok = new string[Directory.GetFiles(TargetBox.Text, "*" + OwnextTB.Text).Length];
            if (TorrentCB.Checked)
            {
                Tfajlok = Directory.GetFiles(TargetBox.Text, "*.torrent");
                osszeg += Tfajlok.Count();
                to = Tfajlok.Count();
            }
            if (OwnextCB.Checked)
            {
                if (OwnextTB.Text == "")
                {
                    MessageBox.Show("Type an extension first. (eg.: .mp3 , .mp4 , .mkv)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    Lista.Items.Add("Extension missing.. Aborted.");
                    return;
                }
                Ofajlok = Directory.GetFiles(TargetBox.Text, "*" + OwnextTB.Text);
                osszeg += Ofajlok.Count();
                oo = Ofajlok.Count();
            }
            if (!TorrentCB.Checked && !OwnextCB.Checked)
            {
                MessageBox.Show("You must choose at least one extension!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Lista.Items.Add("Extension missing.. Aborted.");
                return;
            }
            int count = 0;
            if (osszeg == 0)
            {
                Lista.Items.Add("No matchable file found!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?\n" + osszeg + " file(s) will be removed.", "Clean", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    Lista.Items.Add("Aborted..");
                }
                else
                {

                    string[] Fajlist = new string[osszeg];
                    int cv = 0;
                    int cvo = 0;
                    for (int i = 0; i < Fajlist.Length; i++)
                    {

                        if (OwnextCB.Checked && Ofajlok.Count() != 0 && cvo != -1)
                        {
                            Fajlist[i] = Ofajlok[cvo];
                            if (cvo != Ofajlok.Count() - 1)
                            {
                                cvo++;
                            }
                            else
                            {
                                cvo = -1;
                            }
                        }

                    }
                    if (TorrentCB.Checked)
                    {
                        for (int i = osszeg - to; i < Fajlist.Length; i++)
                        {
                            if (TorrentCB.Checked && Tfajlok.Count() != 0 && cv != -1)
                            {
                                Fajlist[i] = Tfajlok[cv];
                                if (cv != Tfajlok.Count() - 1)
                                {
                                    cv++;
                                }
                                else
                                {
                                    cv = -1;
                                }

                            }
                        }

                    }

                    for (int i = 0; i < Fajlist.Length; i++)
                    {
                        string s = Fajlist[i];
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
            if (Selector.SelectedPath != "")
            {
                TargetBox.Text = Selector.SelectedPath;
            }


        }
    }
}
