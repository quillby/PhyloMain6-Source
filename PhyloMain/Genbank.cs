using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Genbank : Form
    {
        string perl = PhyloMain.perl;
        string bioedit = PhyloMain.bioedit;
        string progsdir = PhyloMain.progsdir;
        bool param = PhyloMain.param;

        SynchronizationContext originalContext = SynchronizationContext.Current;
        List<ProcessStartInfo> processes = new List<ProcessStartInfo>();

        public Genbank()
        {
            InitializeComponent();
        }

        private void Genbank_Load(object sender, EventArgs e)
        {
            BtnReset_Click(sender, e);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtACCN.Clear();
            txtMaxLength.Clear();
            txtMinLength.Clear();
            txtOrganism.Clear();
            txtOutput.Clear();
            txtWarning.Visible = false;
            btnACCN.Enabled = false;
            btnSearch.Enabled = false;
            cboProduct.Text = "";
            chkOpenOutput.Checked = false;
            rdbNucleotide.Checked = true;
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void PicFileSave_MouseHover(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileSave_MouseLeave(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.None;
        }

        private void PicACCNOpen_MouseHover(object sender, EventArgs e)
        {
            picACCNOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicACCNOpen_MouseLeave(object sender, EventArgs e)
        {
            picACCNOpen.BorderStyle = BorderStyle.None;
        }

        private void TxtACCN_TextChanged_1(object sender, EventArgs e)
        {
            btnACCN.Enabled = txtACCN.Text != "" ? true : false;
            btnSearch.Enabled = txtACCN.Text != "" ? false : true;
        }

        private void PicFileSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog output = new SaveFileDialog
            {
                Filter = "Fasta files (*.fas)|*.fas|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = rdbNucleotide.Checked ? "gb_export.fas" : "pubmed.txt"
            };
            if (output.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = output.FileName;
            }
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            string length = "";
            string output = PhyloMain.IfRequired(txtOutput.Text);
            string perlfile = progsdir + "\\ncbi_search.pl";
            string query;
            string maxitems = txtMaxItems.Text;
            if (rdbNucleotide.Checked)
            {
                if (txtMinLength.Text == "" && txtMaxLength.Text == "")
                {
                    length = "0";
                }
                if (txtMinLength.Text != "" & txtMaxLength.Text == "")
                {
                    length = txtMinLength.Text + ":" + "99999999";
                }
                if (txtMaxLength.Text != "" && txtMinLength.Text == "")
                {
                    length = "0" + ":" + txtMaxLength.Text;
                }
                if (txtMinLength.Text != "" && txtMaxLength.Text != "")
                {
                    length = txtMinLength.Text + ":" + txtMaxLength.Text;
                }
                if (length == "0")
                {
                    query = "\"" + txtOrganism.Text + "[ORGN] AND " + cboProduct.Text + "\"";
                }
                else
                {
                    query = "\"" + txtOrganism.Text + "[ORGN] AND " + length + "[SLEN] AND " + cboProduct.Text + "\"";
                }
                query += " -d nucleotide -r fasta -o " + output;
            }
            else
            {
                query = "\"" + txtOrganism.Text + "\" -d pubmed -r abstract -o " + output;                           
            }

            if (maxitems != "")
            {
                query += " -m " + Convert.ToInt16(maxitems);
            }
            query = perlfile + " -q " + query;
            if (!param)
            {
                MessageBox.Show(query, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (File.Exists(output))
            {
                File.Delete(output);
            }

            ProcessStartInfo process1 = new ProcessStartInfo();
            process1.UseShellExecute = false;
            process1.RedirectStandardOutput = false;
            process1.WindowStyle = ProcessWindowStyle.Hidden;
            process1.UseShellExecute = true;
            process1.RedirectStandardOutput = false;
            process1.CreateNoWindow = true;            
            process1.FileName = "cmd.exe ";
            process1.Arguments = "/C " + perl + " " + query;
            processes.Add(process1);

            if (chkOpenOutput.Checked)
            {
                if (rdbNucleotide.Checked)
                {
                    ProcessStartInfo showresult = new ProcessStartInfo();
                    showresult.FileName = bioedit;
                    showresult.Arguments = output;
                    showresult.UseShellExecute = false;
                    showresult.RedirectStandardOutput = false;
                    processes.Add(showresult);
                }
                else
                {
                    ProcessStartInfo showresult = new ProcessStartInfo();
                    showresult.FileName = "notepad.exe";
                    showresult.Arguments = output;
                    showresult.UseShellExecute = false;
                    showresult.RedirectStandardOutput = false;
                    processes.Add(showresult);
                }
            }
            
            Thread th = new Thread(() =>
            {
                ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { txtWarning.Visible = true; }, null); });
                ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnSearch.Enabled = false; }, null); });
                for (int i = 0; i < processes.Count; i++)
                {
                    try
                    {
                        using (Process exeProcess = Process.Start(processes[i]))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "End of execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { txtWarning.Visible = false; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnSearch.Enabled = true; }, null); });
                }
            });
            th.Start();                    
        }

        private void TxtOutput_TextChanged_1(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtOutput.Text != "" ? true : false;
            btnACCN.Enabled = txtOutput.Text != "" ? false : true;
        }

        private void BtnACCN_Click(object sender, EventArgs e)
        {
            //search Genbank by list with accession numbers
            Environment.CurrentDirectory = progsdir;
            string perlfile = "readfile.pl";
            string template = "readfile-template.pl";
            string tempdir = progsdir.Replace("\\", "/");
            StreamReader sBuf = new StreamReader(template);
            var content = sBuf.ReadToEnd();
            sBuf.Close();
            content = content.Replace("mypath", tempdir + "/");
            StreamWriter sb = new StreamWriter(perlfile);
            sb.Write(content);
            sb.Close();

            string inputdir = Path.GetDirectoryName(txtACCN.Text);
            string infile = Path.GetFileName(txtACCN.Text);
            if (File.Exists("accn.txt"))
            {
                File.Delete("accn.txt");
                File.Copy(txtACCN.Text, "accn.txt");
            }
            else
            {
                File.Copy(txtACCN.Text, "accn.txt");
            }

            ProcessStartInfo process1 = new ProcessStartInfo();
            process1.UseShellExecute = false;
            process1.RedirectStandardOutput = false;
            process1.WindowStyle = ProcessWindowStyle.Hidden;
            process1.UseShellExecute = true;
            process1.RedirectStandardOutput = false;
            process1.CreateNoWindow = true;
            process1.FileName = "cmd.exe ";
            process1.Arguments = "/C " + perl + " " + perlfile;
            processes.Add(process1);

            if (chkOpenOutput.Checked)
            {
                if (rdbNucleotide.Checked)
                {
                    if (File.Exists("results.fas"))
                    {
                        File.Copy("results.fas", inputdir + "\\results.fas", true);
                        File.Delete("results.fas");
                    }
                    ProcessStartInfo showresult = new ProcessStartInfo();
                    showresult.FileName = bioedit;
                    showresult.Arguments = inputdir + "\\results.fas";
                    showresult.UseShellExecute = false;
                    showresult.RedirectStandardOutput = false;
                    processes.Add(showresult);                    
                }
            }
            Thread th = new Thread(() =>
            {
                ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { txtWarning.Visible = true; }, null); });
                ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnACCN.Enabled = false; }, null); });
                for (int i = 0; i < processes.Count; i++)
                {
                    try
                    {
                        using (Process exeProcess = Process.Start(processes[i]))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "End of execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { txtWarning.Visible = false; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnACCN.Enabled = true; }, null); });
                }
            });
            th.Start();
        }

        private void PicACCNOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog accn = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open file with accession numbers",
                Filter = "Accn files (*.txt)|*.txt|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (accn.ShowDialog() == DialogResult.OK)
            {
                txtACCN.Text = accn.FileName;               
            }
        }

        private void TxtOutput_DoubleClick(object sender, EventArgs e)
        {
            PicFileSave_Click_1(sender, e);
        }

        private void TxtACCN_DragDrop_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtACCN.Lines = files;
            }
        }

        private void TxtACCN_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void RdbNucleotide_CheckedChanged(object sender, EventArgs e)
        {
            cboProduct.Enabled = rdbNucleotide.Checked ? true : false;
            txtMinLength.Enabled = rdbNucleotide.Checked ? true : false;
            txtMaxLength.Enabled = rdbNucleotide.Checked ? true : false;
            btnACCN.Enabled = rdbNucleotide.Checked ? true : false;
        }
    }
}
