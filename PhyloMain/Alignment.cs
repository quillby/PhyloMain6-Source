using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Alignment : Form
    {
        string clustalw = PhyloMain.clustalw;
        string mafft = PhyloMain.mafft;
        string muscle = PhyloMain.muscle;
        string bioedit = PhyloMain.bioedit;
        string gblocks = PhyloMain.gblocks;
        bool param = PhyloMain.param;
        string options = "";

        public Alignment()
        {
            InitializeComponent();
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
            rdbMAFFT.Checked = true;
            grpMAFFT.Visible = true;
            chkCommand.Checked = true;
            btnAlign.Enabled = false;
            btnStartBioEdit.Enabled = false;
        }

        private void RdbMuscle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMuscle.Checked)
            {
                ParametersInvisible(sender, e);
                grpMuscle.Visible = true;
                chkCommand.Enabled = true;
                txtMuscleIterations.Focus();
            }
            else
            {
                grpMuscle.Visible = false;
            }
        }

        private void RdbMAFFT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMAFFT.Checked)
            {
                ParametersInvisible(sender, e);
                grpMAFFT.Visible = true;
                chkCommand.Enabled = true;
            }
            else
            {
                grpMAFFT.Visible = false;
            }
        }

        private void RdbClustalW_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbClustalW.Checked)
            {
                ParametersInvisible(sender, e);
                grpClustalW.Visible = true;
                chkCommand.Enabled = true;
            }
            else
            {
                grpClustalW.Visible = false;
            }
        }

        private void ParametersInvisible(object sender, EventArgs e)
        {
            grpClustalW.Visible = false;
            grpMAFFT.Visible = false;
            grpMuscle.Visible = false;
        }

        private void PicFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta file for alignment",
                Filter = "Fasta files (*.fas)|*.fas|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
                //folder = Path.GetDirectoryName(txtFastaFile.Text);
            }
            if (txtAlignment.Text != "")
            {
                btnAlign.Enabled = true;
            }
        }

        private void PicFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog align = new SaveFileDialog
            {
                Filter = "Fasta alignment (*.afa)|*.afa|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "align.afa"
            };
            if (align.ShowDialog() == DialogResult.OK)
            {
                txtAlignment.Text = align.FileName;
                chkGblocks.Enabled = txtAlignment.Text != "" ? true : false;
            }
            if (txtFastaFile.Text != "")
            {
                btnAlign.Enabled = true;
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtAlignment.Clear();
            txtFastaFile.Clear();
            rdbMAFFT.Checked = true;
            options = "";
            btnAlign.Enabled = false;
            btnStartBioEdit.Enabled = false;
        }

        private void BtnAlign_Click(object sender, EventArgs e)
        {
            btnAlign.Enabled = false;
            options = "";
            if (rdbClustalW.Checked)
            {
                string options = " -ALIGN -CONVERT -OUTPUT=fasta -INFILE=\"" + txtFastaFile.Text + "\" -OUTFILE=\"" + txtAlignment.Text + "\" -BOOTSTRAP=" + txtBootstrap.Text;
                if (chkNJtree.Checked)
                {
                    options += " -TREE";
                }
                if (rdbAligned.Checked)
                {
                    options += " -OUTORDER=aligned";
                }
                else
                {
                    options += " -OUTORDER=input";
                }
                RunProg(clustalw, options, param);
            }

            if (rdbMuscle.Checked)
            {
                string options = " -in \"" + txtFastaFile.Text + "\" -out \"" + txtAlignment.Text + "\" -maxiters " + txtMuscleIterations.Text;
                if (chkDiag.Checked)
                {
                    options += " -diags1";
                }
                RunProg(muscle, options, param);
            }

            if (rdbMAFFT.Checked)
            {
                if (rdbFFT1.Checked)
                {
                    options = " --retree " + cboRetree.Text;
                }
                if (rdbEINS.Checked)
                {
                    options = " --genafpair";
                }
                if (rdbLINS.Checked)
                {
                    options = " --localpair";
                }
                if (rdbGINS.Checked)
                {
                    options = " --globalpair";
                }
                if (chkAdjust.Checked)
                {
                    options += " --adjustdirection";
                }
                options += " --maxiterate 1000 --reorder \"" + txtFastaFile.Text + "\" > \"" + txtAlignment.Text + "\"";
                RunProg(mafft, options, param);
            }
            if (chkGblocks.Checked)
            {
                if (PhyloMain.IDlines(txtAlignment.Text))
                {
                    MessageBox.Show("GBlocks can't be executed, because there are '>' lines present larger than 50 characters.", "Fasta ID line too long", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string gap = cboGaps.Text;
                string b5 = "";
                switch (gap)
                {
                    case "None":
                        b5 = "n";
                        break;
                    case "With Half":
                        b5 = "h";
                        break;
                    case "All":
                        b5 = "a";
                        break;
                }
                options = " -t=d -b3=" + txtB3.Text + " -b4=" + txtB4.Text + " -b5=" + b5 + " -e=.gb";
                RunGblocks(txtAlignment.Text, options);               
            }           
            btnAlign.Enabled = true;
            //btnStartBioEdit.Enabled = true;
        }

        private void RunGblocks(string file, string opt)
        {
            string cgblocks = PhyloMain.IfRequired(gblocks);
            file = PhyloMain.IfRequired(file);
            ProcessStartInfo gb = new ProcessStartInfo();
            gb.FileName = cgblocks;
            gb.Arguments = file + opt;
            gb.UseShellExecute = false;
            gb.RedirectStandardOutput = false;
            Process.Start(gb);
        }

        private void RunBioEdit(string file)
        {
            string cbioedit = PhyloMain.IfRequired(bioedit);
            string cfile = PhyloMain.IfRequired(file);
            ProcessStartInfo alignshow = new ProcessStartInfo();
            alignshow.FileName = cbioedit;
            alignshow.Arguments = cfile;
            alignshow.UseShellExecute = false;
            Process.Start(alignshow);
        }

        private void RunProg(string prog, string options, bool param)
        {
            btnStartBioEdit.Enabled = false;
            SynchronizationContext originalContext = SynchronizationContext.Current;            
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            prog = PhyloMain.IfRequired(prog);
            ProcessStartInfo execute = new ProcessStartInfo();
            if (chkCommand.Checked)
            {
                execute.WindowStyle = ProcessWindowStyle.Normal;
            }
            else
            {
                execute.WindowStyle = ProcessWindowStyle.Hidden;
                execute.RedirectStandardOutput = true;
                execute.CreateNoWindow = true;
            }
            execute.UseShellExecute = false;
            execute.FileName = prog;
            execute.Arguments = options;
            if (chkCommand.Checked)
            {
                btnAlign.Enabled = false;
                try
                {
                    using (Process exeProcess = Process.Start(execute))
                    {
                        panel1.Visible = true;
                        Thread.Sleep(100);
                        SetParent(exeProcess.MainWindowHandle, panel1.Handle);
                        SetWindowLong(exeProcess.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                        MoveWindow(exeProcess.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The program " + prog + " encountered a problem.", "Execution halted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                panel1.Visible = false;
                //btnAlign.Enabled = true;
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { label11.Visible = true; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnAlign.Enabled = false; }, null); });
                    try
                    {
                        using (Process exeProcess = Process.Start(execute))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The program " + prog + " encountered a problem.\n\n" + ex.Message, "Execution halted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { label11.Visible = false; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnAlign.Enabled = true; }, null); });
                });                
                th.Start();                
            }
            btnStartBioEdit.Enabled = true;
            btnAlign.Enabled = true;
        }

        private void RdbFFT1_CheckedChanged(object sender, EventArgs e)
        {
            cboRetree.Enabled = rdbFFT1.Checked;
        }

        private void TxtAlignment_TextChanged(object sender, EventArgs e)
        {
                btnAlign.Enabled = txtFastaFile.Text != "" ? true : false;
        }

        private void TxtFastaFile_TextChanged(object sender, EventArgs e)
        {
            btnAlign.Enabled = txtAlignment.Text != "" ? true : false;
        }

        private void PicFileOpen_MouseHover(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.None;
        }

        private void PicFileSave_MouseHover(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileSave_MouseLeave(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.None;
        }

        private void TxtAlignment_DoubleClick(object sender, EventArgs e)
        {
            PicFileSave_Click(sender, e);
        }

        private void TxtFastaFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile.Lines = files;
            }
        }

        private void TxtFastaFile_DragEnter(object sender, DragEventArgs e)
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

        private void ChkGblocks_CheckedChanged(object sender, EventArgs e)
        {
            txtB3.Enabled = chkGblocks.Checked ? true : false;
            txtB4.Enabled = chkGblocks.Checked ? true : false;
            cboGaps.Enabled = chkGblocks.Checked ? true : false;
        }

        private void TxtB4_TextChanged(object sender, EventArgs e)
        {
            txtB4.Text = Convert.ToInt16(txtB4.Text) < 3 ? "2" : txtB4.Text;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);
        static readonly int GWL_STYLE = -16;
        static readonly int WS_VISIBLE = 0x10000000;

        private void btnStartBioEdit_Click(object sender, EventArgs e)
        {            
            string newfile = txtAlignment.Text;
            if (chkGblocks.Checked)
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Do you want to see the alignment after GBlocks was used?", "Which alignment to open", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    newfile = txtAlignment.Text + ".gb";
                }
            }
            if (File.Exists(newfile))
            {
                RunBioEdit(newfile);
            }          
        }
    }
}
