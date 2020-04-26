using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Bayes : Form
    {
        string bayes = PhyloMain.bayes;
        string figtree = PhyloMain.figtree;
        string options = "";

        public Bayes()
        {
            InitializeComponent();
        }

        private void Bayes_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            splitContainer1.Panel2.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            btnStartBayes.Enabled = false;
            chkViewTree.Checked = false;
            chkCommand.Checked = true;
            txtChains.Text = "4";
            txtGenerations.Text = "1";
            txtChains.Enabled = true;
            txtGenerations.Enabled = true;
            txtSeqLength.Enabled = false;
            txtNrStrains.Enabled = false;
            picFastaOpen.Enabled = true;
            picNexusOpen.Enabled = true;
            picSaveNexus.Enabled = true;
            picBayesOpen.Enabled = true;
            txtMrBayes.Enabled = true;
            txtNewBayes.Enabled = true;
            txtFasta.Enabled = true;
            txtNexus.Enabled = true;
            lblParam.Visible = false;
        }

        private void PicBayesOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog bayes = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Bayes nexus file",
                FilterIndex = 1,
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (bayes.ShowDialog() == DialogResult.OK)
            {
                txtMrBayes.Text = bayes.FileName;
            }
            else
            {
                txtMrBayes.Text = "";
            }
        }

        private void TxtMrBayes_TextChanged(object sender, EventArgs e)
        {
            if (txtMrBayes.Text != "")
            {
                picFastaOpen.Enabled = txtMrBayes.Text != "" ? false : true;
                picNexusOpen.Enabled = txtMrBayes.Text != "" ? false : true;
                picSaveNexus.Enabled = txtMrBayes.Text != "" ? false : true;
                txtNrStrains.Enabled = txtMrBayes.Text != "" ? false : true;
                txtSeqLength.Enabled = txtMrBayes.Text != "" ? false : true;
                btnStartBayes.Enabled = txtMrBayes.Text != "" ? true : false;
                txtFasta.Enabled = txtMrBayes.Text != "" ? false : true;
                txtNexus.Enabled = txtMrBayes.Text != "" ? false : true;
                txtNewBayes.Enabled= txtMrBayes.Text != "" ? false : true;
                txtNrStrains.Enabled = txtMrBayes.Text != "" ? false : true;
                txtGenerations.Enabled = txtMrBayes.Text != "" ? false : true;
                txtSeqLength.Enabled = txtMrBayes.Text != "" ? false : true;
                txtChains.Enabled = txtMrBayes.Text != "" ? false : true;
                txtBurnin.Enabled = txtMrBayes.Text != "" ? false : true;
            }
        }

        private void BtnNewCalculation_Click(object sender, EventArgs e)
        {
            Bayes_Load(sender, e);
        }

        private void TxtFasta_TextChanged(object sender, EventArgs e)
        {
            txtSeqLength.Enabled = txtFasta.Text != "" ? true : false;
            txtNrStrains.Enabled = txtFasta.Text != "" ? true : false;
            picNexusOpen.Enabled= txtFasta.Text != "" ? false : true;
            picSaveNexus.Enabled= txtFasta.Text != "" ? true : false;
            picBayesOpen.Enabled = txtFasta.Text != "" ? false : true;
            txtGenerations.Enabled = txtFasta.Text != "" ? true : false;
            txtChains.Enabled = txtFasta.Text != "" ? true : false;
            txtBurnin.Enabled = txtFasta.Text != "" ? true : false;
        }

        private void TxtNewBayes_TextChanged(object sender, EventArgs e)
        {
            btnStartBayes.Enabled = txtNewBayes.Text != "" ? true : false;
            picBayesOpen.Enabled = txtNewBayes.Text != "" ? false : true;
            txtChains.Enabled = txtNewBayes.Text != "" ? true : false;
            txtGenerations.Enabled = txtNewBayes.Text != "" ? true : false;
            txtBurnin.Enabled = txtNewBayes.Text != "" ? true : false;
        }

        private void TxtNexus_TextChanged(object sender, EventArgs e)
        {
            picFastaOpen.Enabled = txtNexus.Text != "" ? false : true;
            picBayesOpen.Enabled = txtNexus.Text != "" ? false : true;
            txtNrStrains.Enabled = txtNexus.Text != "" ? false : true;
            txtSeqLength.Enabled = txtNexus.Text != "" ? false : true;
            txtChains.Enabled = txtNexus.Text != "" ? true : false;
            txtGenerations.Enabled = txtNexus.Text != "" ? true : false;
            txtMrBayes.Enabled = txtNexus.Text != "" ? false : true;
            txtFasta.Enabled = txtNexus.Text != "" ? false : true;
            txtBurnin.Enabled = txtNexus.Text != "" ? true : false;
        }

        private void BtnStartBayes_Click(object sender, EventArgs e)
        {
            SynchronizationContext originalContext = SynchronizationContext.Current;
            List<ProcessStartInfo> processes = new List<ProcessStartInfo>();
            string tree = "";
            if (txtMrBayes.Text != "")
            {
                if (chkInteractive.Checked)
                {
                    options = " -i ";
                }
                options += txtMrBayes.Text;
                tree = txtMrBayes.Text + ".con.tre";
            }      
            if(txtFasta.Text!="" && txtNewBayes.Text != "")
            {
                if(txtNrStrains.Text=="" || txtSeqLength.Text == "")
                {
                    MessageBox.Show("When fasta-files are used, MrBayes needs to know the number of taxa and the sequence length.", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //prepare a nexus file with fasta data to NewBayes file
                string fasta = txtFasta.Text;
                string export = txtNewBayes.Text;
                tree = export + ".con.tre";
                string temp = "";
                var sb = new StringBuilder();
                StreamReader file = new StreamReader(fasta);
                StreamWriter sW = new StreamWriter(export, true);
                sW.WriteLine("#NEXUS");
                sW.WriteLine("BEGIN DATA;");
                sW.WriteLine("DIMENSIONS NTAX=" + txtNrStrains.Text + " NCHAR=" + txtSeqLength.Text + ";");
                sW.WriteLine("FORMAT DATATYPE=DNA GAP=-;");
                sW.WriteLine("MATRIX");
                temp = file.ReadLine();
                while (!file.EndOfStream)
                {
                    if (temp != "" && temp.Substring(0, 1) == ">")
                    {
                        temp = temp.Substring(1, temp.Length - 1) + "\t";
                        sb.AppendLine(temp);
                        temp = file.ReadLine();
                        while (temp.Substring(0, 1) != ">" && !file.EndOfStream)
                        {                           
                            sb.AppendLine(temp);
                            temp = file.ReadLine();
                        }
                    }
                    else
                    {
                        temp = file.ReadLine();
                    }
                }
                // write last line
                sb.AppendLine(temp);
                sW.WriteLine(sb.ToString());
                file.Dispose();

                file.Close();
                sW.WriteLine(";");
                sW.WriteLine("END;");
                sW.WriteLine(" ");
                var bb = new StringBuilder();
                // add MrBayes block
                string gen = (Convert.ToInt16(txtGenerations.Text) * 1000000).ToString();
                bb.AppendLine("BEGIN MRBAYES;");
                bb.AppendLine("set autoclose=yes nowarn=yes;");
                bb.AppendLine("Lset applyto=(1) nst=6 rates=equal;");
                bb.AppendLine("Prset applyto=(1) statefreqpr=Fixed(equal);");
                bb.AppendLine("mcmc nruns=2 nchains=" + txtChains.Text + " ngen=" + gen + " samplefreq=1000 savebrlens=yes;");
                bb.AppendLine("sump burninfrac=" + txtBurnin.Text + ";");
                bb.AppendLine("sumt burninfrac=" + txtBurnin.Text + ";");
                bb.AppendLine("quit;");
                bb.AppendLine("END;");
                sW.WriteLine(bb.ToString());
                sW.Close();
                sW.Dispose();
                options = "\"" + txtNewBayes.Text + "\"";
                tree = txtNewBayes.Text + ".con.tre";
            }
            //if a nexus file is chosen, add Bayes block at the end of the file
            if (txtNexus.Text != "" && txtNewBayes.Text != "")
            {
                string nexus = txtNexus.Text;
                string export = txtNewBayes.Text;
                var sb = new StringBuilder();
                StreamReader file = new StreamReader(nexus);
                string line = file.ReadToEnd();
                StreamWriter sW = new StreamWriter(export, true);
                sW.Write(line);
                sW.Flush();
                file.Close();
                string gen = (Convert.ToInt16(txtGenerations.Text) * 1000000).ToString();
                sb.AppendLine("BEGIN MRBAYES;");
                sb.AppendLine("set autoclose=yes nowarn=yes;");
                sb.AppendLine("Lset applyto=(1) nst=6 rates=equal;");
                sb.AppendLine("Prset applyto=(1) statefreqpr=Fixed(equal);");
                sb.AppendLine("mcmc nruns=2 nchains=" + txtChains.Text + " ngen=" + gen + " samplefreq=1000 savebrlens=yes;");
                sb.AppendLine("sump burninfrac=" + txtBurnin.Text + ";");
                sb.AppendLine("sumt burninfrac=" + txtBurnin.Text + ";");
                sb.AppendLine("quit;");
                sb.AppendLine("END;");
                sW.WriteLine(sb.ToString());
                sW.Close();
                options = "\"" + txtNewBayes.Text + "\"";
                tree = txtNewBayes.Text + ".con.tre";
            }

            ProcessStartInfo process1 = new ProcessStartInfo();
            process1.UseShellExecute = false;
            process1.RedirectStandardOutput = false;
            if (chkCommand.Checked)
            {
                process1.WindowStyle = ProcessWindowStyle.Normal;               
            }
            else
            {
                process1.WindowStyle = ProcessWindowStyle.Hidden;
                process1.UseShellExecute = true;
                process1.RedirectStandardOutput = false;
                process1.CreateNoWindow = true;
            }
            process1.FileName = "cmd.exe ";
            process1.Arguments = "/C " + bayes + " " + options;
            processes.Add(process1);

            if (chkViewTree.Checked)
            {
                ProcessStartInfo process2 = new ProcessStartInfo();
                string view = PhyloMain.IfRequired(figtree);
                process2.FileName = view;
                process2.Arguments = tree;
                process2.UseShellExecute = false;
                process2.RedirectStandardOutput = false;
                processes.Add(process2);
            }
            if (chkCommand.Checked)
            {
                btnStartBayes.Enabled = false;
                try
                {
                    using (Process exeProcess = Process.Start(process1))
                    {
                        panel1.Visible = true;
                        Thread.Sleep(100);
                        SetParent(exeProcess.MainWindowHandle, panel1.Handle);
                        SetWindowLong(exeProcess.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                        MoveWindow(exeProcess.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
                        exeProcess.WaitForExit();
                    }
                    panel1.Visible = false;
                    btnStartBayes.Enabled = true;                    
                }
                catch (Exception)
                {
                    MessageBox.Show("MrBayes wasn't able to execute the created file.", "Corrupted file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = true; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartBayes.Enabled = false; }, null); });
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
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = false; }, null); });
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartBayes.Enabled = true; }, null); });
                    }
                });
                th.Start();
            }
            if (chkCommand.Checked)
            {
                if (chkViewTree.Checked)
                {
                    Process.Start(figtree, tree);
                }
            }            
        }

        private void PicNexusOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog nexus = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Nexus file",
                FilterIndex = 1,
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (nexus.ShowDialog() == DialogResult.OK)
            {
                txtNexus.Text = nexus.FileName;
                picFastaOpen.Enabled = false;
                txtFasta.Enabled = false;
                txtNrStrains.Enabled = false;
                txtSeqLength.Enabled = false;
            }
        }

        private void PicSaveNexus_Click(object sender, EventArgs e)
        {
            SaveFileDialog newbayes = new SaveFileDialog
            {
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "newbayes.nex"
            };
            if (newbayes.ShowDialog() == DialogResult.OK)
            {
                txtNewBayes.Text = newbayes.FileName;
            }
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Fasta file",
                FilterIndex = 1,
                Filter = "Fasta files (*.afa)|*.afa|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFasta.Text = fasta.FileName;
                picNexusOpen.Enabled = false;
                picBayesOpen.Enabled = false;
                txtSeqLength.Enabled = true;
                txtNrStrains.Enabled = true;
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);
        static readonly int GWL_STYLE = -16;
        static readonly int WS_VISIBLE = 0x10000000;

        private void PicBayesOpen_MouseHover(object sender, EventArgs e)
        {
            picBayesOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicBayesOpen_MouseLeave(object sender, EventArgs e)
        {
            picBayesOpen.BorderStyle = BorderStyle.None;
        }

        private void PicFastaOpen_MouseHover(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFastaOpen_MouseLeave(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.None;
        }

        private void PicNexusOpen_MouseHover(object sender, EventArgs e)
        {
            picNexusOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicNexusOpen_MouseLeave(object sender, EventArgs e)
        {
            picNexusOpen.BorderStyle = BorderStyle.None;
        }

        private void PicSaveNexus_MouseHover(object sender, EventArgs e)
        {
            picSaveNexus.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicSaveNexus_MouseLeave(object sender, EventArgs e)
        {
            picSaveNexus.BorderStyle = BorderStyle.None;
        }

        private void TxtNewBayes_DoubleClick(object sender, EventArgs e)
        {
            PicSaveNexus_Click(sender, e);
        }

        private void txtBurnin_Leave(object sender, EventArgs e)
        {
            if (txtBurnin.Text == "")
            {
                txtBurnin.Text = "0.25";
            }
            if (float.Parse(txtBurnin.Text) > 0.50 || float.Parse(txtBurnin.Text) < 0.10)
            {
                MessageBox.Show("Apply a burnin fraction between 0.10 and 0.50", "Burnin fraction out of bound", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBurnin.Focus();
            }
        }
    }
}
