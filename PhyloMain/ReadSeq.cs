using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class ReadSeq : Form
    {
        private string infile = "";
        private string outfile = "";
        private string readseq = PhyloMain.readseq;        
        private bool param = PhyloMain.param;
        private string options = "";

        public ReadSeq()
        {
            InitializeComponent();
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
            btnConvert.Enabled=false;
        }

        private void PicInput_Click(object sender, EventArgs e)
        {
            string format = cboInput.Text;
            switch (format)
            {
                case "Fasta":
                    OpenFileDialog fasta = new OpenFileDialog()
                    {
                        Title = "Choose fasta file",
                        Filter = "Fasta file (*.fas)|*.fas|Alignment file (*.afa)|*.afa",
                    };
                    if (fasta.ShowDialog() == DialogResult.OK)
                    {
                        txtInput.Text = fasta.FileName;
                    }
                    break;
                case "Clustal":
                    OpenFileDialog clustal = new OpenFileDialog()
                    {
                        Title = "Choose clustal file",
                        Filter = "Clustal file (*.aln)|*.aln",
                    };
                    if (clustal.ShowDialog() == DialogResult.OK)
                    {
                        txtInput.Text = clustal.FileName;
                    }
                    break;
                case "Nexus":
                    OpenFileDialog nexus = new OpenFileDialog()
                    {
                        Title = "Choose nexus file",
                        Filter = "Nexus file (*.nex)|*.nex",
                    };
                    if (nexus.ShowDialog() == DialogResult.OK)
                    {
                        txtInput.Text = nexus.FileName;
                    }
                    break;
            }
            infile = txtInput.Text;
        }

        private void PicOutput_Click(object sender, EventArgs e)
        {
            string format = cboOutput.Text;
            switch (format)
            {
                case "Fasta":
                    SaveFileDialog fasta = new SaveFileDialog()
                    {
                        Title = "Choose fasta file",
                        Filter = "Fasta file (*.fas)|*.fas",
                    };
                    if (fasta.ShowDialog() == DialogResult.OK)
                    {
                        txtOutput.Text = fasta.FileName;
                    }
                    break;
                case "Clustal":
                    SaveFileDialog clustal = new SaveFileDialog()
                    {
                        Title = "Choose clustal file",
                        Filter = "Clustal file (*.aln)|*.aln",
                    };
                    if (clustal.ShowDialog() == DialogResult.OK)
                    {
                        txtOutput.Text = clustal.FileName;
                    }
                    break;
                case "Nexus":
                    SaveFileDialog nexus = new SaveFileDialog()
                    {
                        Title = "Choose nexus file",
                        Filter = "Nexus file (*.nex)|*.nex",
                    };
                    if (nexus.ShowDialog() == DialogResult.OK)
                    {
                        txtOutput.Text = nexus.FileName;
                    }
                    break;
            }
            outfile = txtOutput.Text;
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                btnConvert.Enabled = txtOutput.Text != "" ? true : false;
            }
        }

        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                btnConvert.Enabled = txtInput.Text != "" ? true : false;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            txtWarning.Visible = true;
            infile = txtInput.Text;
            outfile = txtOutput.Text;
            options = " -a -f " + cboOutput.Text + " -inform=" + cboInput.Text;
            options += " -C -output=\'" + outfile + "\' \'" + infile + "\'";            
            RunProg(readseq, options, param);           
        }

        private void RunProg(string prog, string options, bool param)
        {
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtWarning.Visible = true;
            prog = PhyloMain.IfRequired(prog);
            ProcessStartInfo convert = new ProcessStartInfo();
            convert.FileName = prog;
            convert.Arguments = options;
            convert.UseShellExecute = false;
            Process.Start(convert);
            txtWarning.Visible = false;
        }

        private void PicInput_MouseHover(object sender, EventArgs e)
        {
            picInput.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicInput_MouseLeave(object sender, EventArgs e)
        {
            picInput.BorderStyle = BorderStyle.None;
        }

        private void PicOutput_MouseHover(object sender, EventArgs e)
        {
            picOutput.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicOutput_MouseLeave(object sender, EventArgs e)
        {
            picOutput.BorderStyle = BorderStyle.None;
        }

        private void TxtOutput_DoubleClick(object sender, EventArgs e)
        {
            PicOutput_Click(sender, e);
        }

        private void TxtInput_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtInput.Lines = files;
            }
        }

        private void TxtInput_DragEnter(object sender, DragEventArgs e)
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

        private void BtnResetAll_Click(object sender, EventArgs e)
        {
            cboInput.Text = "Fasta";
            cboOutput.Text = "Nexus";
            txtInput.Clear();
            txtOutput.Clear();
        }
    }
}
