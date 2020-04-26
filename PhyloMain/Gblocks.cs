using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Gblocks : Form
    {
        string bioedit = PhyloMain.bioedit;
        string gblocks = PhyloMain.gblocks;
        string options = "";

        public Gblocks()
        {
            InitializeComponent();            
        }

        private void Gblocks_Load(object sender, EventArgs e)
        {
            btnGblocks.Enabled = false;
            btnOpenGb.Enabled = false;
            btnClearAll.Enabled = false;
            txtAlignment.Clear();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Gblocks_Load(sender, e);
        }

        private void BtnGblocks_Click(object sender, EventArgs e)
        {
            string align = txtAlignment.Text;
            if (PhyloMain.IDlines(align))
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
            if (File.Exists(align))
            {
                RunGblocks(align, options);
            }           
        }

    private void TxtAlignment_TextChanged(object sender, EventArgs e)
        {
            btnClearAll.Enabled = txtAlignment.Text != "" ? true : false;
            btnGblocks.Enabled = txtAlignment.Text != "" ? true : false;
            txtB3.Enabled = txtAlignment.Text != "" ? true : false;
            txtB4.Enabled = txtAlignment.Text != "" ? true : false;
            cboGaps.Enabled= txtAlignment.Text != "" ? true : false;
        }

        private void RunGblocks(string file, string opt)
        {
            file = PhyloMain.IfRequired(file);
            gblocks = PhyloMain.IfRequired(gblocks);
            ProcessStartInfo gb = new ProcessStartInfo();
            gb.FileName = gblocks;
            gb.Arguments = file + opt;
            gb.UseShellExecute = false;
            gb.RedirectStandardOutput = false;
            Process.Start(gb);
            btnOpenGb.Enabled = true;
        }

        private void RunBioEdit(string file)
        {
            file = PhyloMain.IfRequired(file);
            bioedit = PhyloMain.IfRequired(bioedit);
            ProcessStartInfo alignshow = new ProcessStartInfo();
            alignshow.FileName = bioedit;
            alignshow.Arguments = file;
            alignshow.UseShellExecute = false;
            Process.Start(alignshow);
        }

        private void PicFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta alignment",
                Filter = "Alignment files (*.afa)|*.afa|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtAlignment.Text = fasta.FileName;
            }
        }

        private void PicFileOpen_MouseHover(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.None;
        }

        private void TxtB4_TextChanged(object sender, EventArgs e)
        {
            if (txtB4.Text == "")
            {
                txtB4.Text = "2";
            }
            txtB4.Text = Convert.ToInt16(txtB4.Text) < 2 ? "2" : txtB4.Text;
        }

        private void BtnOpenGb_Click(object sender, EventArgs e)
        {
            string gbfile = txtAlignment.Text + ".gb";
            if (File.Exists(gbfile))
            {
                RunBioEdit(gbfile);
            }            
        }

        private void txtAlignment_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtAlignment.Lines = files;
            }
        }

        private void txtAlignment_DragEnter(object sender, DragEventArgs e)
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
    }
}
