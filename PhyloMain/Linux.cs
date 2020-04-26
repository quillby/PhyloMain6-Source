using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Linux : Form
    {
        string wsl = PhyloMain.wsl;
        string options = " -trim -correct -assemble -trim-assemble";
        string workingfolder = "";
        string method = " -nanopore-raw";

        public Linux()
        {
            InitializeComponent();
            btnStart.Enabled = (txtDirectory.Text != "") ? true : false;
        }

        private void Linux_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void picFolderOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog startfolder = new FolderBrowserDialog();
            startfolder.ShowNewFolderButton = true;
            DialogResult result = startfolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDirectory.Text = startfolder.SelectedPath;
                workingfolder = txtDirectory.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDirectory.Clear();
            txtGenomeSize.Text = "13m";
            txtPrefix.Text = "gspecies";
            txtResultsDirectory.Text = "run1";
            rdbNanoporeRaw.Checked = true;
            txtCMD.Clear();
            txtCMD.Visible = false;
            btnStart.Enabled = (txtDirectory.Text != "") ? true : false;
        }

        private void txtDirectory_DoubleClick(object sender, EventArgs e)
        {
            picFolderOpen_Click(sender, e);
        }

        private void rdbNanoporeRaw_CheckedChanged(object sender, EventArgs e)
        {
            method = " -nanopore-raw";
        }

        private void rdbNanoporeCorrected_CheckedChanged(object sender, EventArgs e)
        {
            method = " -nanopore-corrected";
        }

        private void rdbPacbioRaw_CheckedChanged(object sender, EventArgs e)
        {
            method = " -pacbio-raw";
        }

        private void rdbPacbioCorrected_CheckedChanged(object sender, EventArgs e)
        {
            method = " -pacbio-corrected";
        }

        private void txtResultsDirectory_TextChanged(object sender, EventArgs e)
        {
            if (txtResultsDirectory.Text.Contains(" "))
            {
                MessageBox.Show("It is not allowed to use spaces.", "Results directory name contains spaces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if(txtDirectory.Text.Contains(" "))
            {
                MessageBox.Show("Please save your data in a directory without spaces.", "Directory contains spaces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDirectory.Clear();
                return;
            }
            else
            {
                workingfolder = txtDirectory.Text;
                btnStart.Enabled = (txtDirectory.Text != "") ? true : false;
            }           
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            if (txtPrefix.Text.Contains(" "))
            {
                MessageBox.Show("It is not allowed to use spaces.", "Prefix name contains spaces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtGenomeSize_TextChanged(object sender, EventArgs e)
        {
            if (txtGenomeSize.Text == "")
            {
                MessageBox.Show("You have to supply an estimated genome size.", "Unknown genome size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtDirectory.Text == "") return;
            // change directory to the working directory
            Directory.SetCurrentDirectory(workingfolder);
            string linux = Path.GetFileName(workingfolder);
            string driveletter = Path.GetPathRoot(workingfolder).Substring(0,1).ToLower();
            string ret = Environment.NewLine;
            options = " -d ./" + txtResultsDirectory.Text + " -p " + txtPrefix.Text + " genomeSize=" + txtGenomeSize.Text + options + method + " ./*.fastq";
            txtCMD.Text = "Open Windows command line window." + ret + "Start Linux environment with wsl." + ret + "Change directory to: cd /mnt/" + driveletter + "/" + linux + "." + ret + ret + "Type the following command line: " + ret + "canu" + options;
            txtCMD.Visible = true;
        }
    }
}
