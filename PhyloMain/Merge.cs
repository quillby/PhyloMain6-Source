using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Merge : Form
    {
        string mafft = PhyloMain.mafft;
        bool param = PhyloMain.param;
        string bioedit = PhyloMain.bioedit;
        string options = "";

        public Merge()
        {
            InitializeComponent();
        }

        private void Merge_Load(object sender, EventArgs e)
        {
            txtFastaFile1.Clear();
            txtFastaFile2.Clear();
            txtSaveAs.Clear();
            btnMerge.Enabled = false;
            chkOpenAlignment.Checked = false;
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Merge_Load(sender, e);
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            options = " --auto --leavegappyregion --adjustdirection --add " + "\"" + txtFastaFile2.Text + "\" --reorder \"" + txtFastaFile1.Text + "\" > \"" + txtSaveAs.Text + "\"";
            btnMerge.Enabled = false;
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            mafft = PhyloMain.IfRequired(mafft);
            ProcessStartInfo execute = new ProcessStartInfo();
            execute.FileName = mafft;
            execute.Arguments = options;
            execute.WindowStyle = ProcessWindowStyle.Minimized;
            execute.UseShellExecute = false;
            execute.RedirectStandardOutput = false;
            using (Process exeProcess = Process.Start(execute))
            {
                panel1.Visible = true;
                Thread.Sleep(100);
                SetParent(exeProcess.MainWindowHandle, panel1.Handle);
                SetWindowLong(exeProcess.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(exeProcess.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
                exeProcess.WaitForExit();
            }
            panel1.Visible = false;
            if (chkOpenAlignment.Checked)
            {
                RunBioEdit(txtSaveAs.Text);
            }
        }

        private void RunBioEdit(string file)
        {
            string cfile = PhyloMain.IfRequired(file);
            bioedit = PhyloMain.IfRequired(bioedit);
            ProcessStartInfo alignshow = new ProcessStartInfo();
            alignshow.FileName = bioedit;
            alignshow.Arguments = file;
            alignshow.UseShellExecute = false;
            Process.Start(alignshow);
        }

        private void TxtFastaFile1_TextChanged(object sender, EventArgs e)
        {
            btnMerge.Enabled = (txtFastaFile2.Text != "" && txtSaveAs.Text != "") ? true : false;
        }

        private void TxtFastaFile2_TextChanged(object sender, EventArgs e)
        {
            btnMerge.Enabled = (txtSaveAs.Text != "" && txtFastaFile1.Text != "") ? true : false;
        }

        private void TxtSaveAs_TextChanged(object sender, EventArgs e)
        {
            btnMerge.Enabled = (txtFastaFile1.Text != "" && txtFastaFile2.Text != "") ? true : false;
        }

        private void PicFileOpen1_Click(object sender, EventArgs e)
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
                txtFastaFile1.Text = fasta.FileName;
            }
        }

        private void PicFileOpen2_Click(object sender, EventArgs e)
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
                txtFastaFile2.Text = fasta.FileName;
            }
        }

        private void PicSaveNew_Click(object sender, EventArgs e)
        {
            string folder = Path.GetDirectoryName(txtFastaFile1.Text);
            Directory.SetCurrentDirectory(folder);
            SaveFileDialog align = new SaveFileDialog
            {
                InitialDirectory = folder,
                Filter = "Fasta files (*.fas)|*.fas|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "merged_files.fas"
            };
            if (align.ShowDialog() == DialogResult.OK)
            {
                txtSaveAs.Text = align.FileName;
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

        private void PicFileOpen1_MouseHover(object sender, EventArgs e)
        {
            picFileOpen1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen1_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen1.BorderStyle = BorderStyle.None;
        }

        private void PicFileOpen2_MouseHover(object sender, EventArgs e)
        {
            picFileOpen2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen2_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen2.BorderStyle = BorderStyle.None;
        }

        private void PicSaveNew_MouseHover(object sender, EventArgs e)
        {
            picSaveNew.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicSaveNew_MouseLeave(object sender, EventArgs e)
        {
            picSaveNew.BorderStyle = BorderStyle.None;
        }

        private void TxtSaveAs_DoubleClick(object sender, EventArgs e)
        {
            PicSaveNew_Click(sender, e);
        }

        private void TxtFastaFile1_DragDrop_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile1.Lines = files;
            }
        }

        private void TxtFastaFile1_DragEnter_1(object sender, DragEventArgs e)
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

        private void TxtFastaFile2_DragDrop_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile2.Lines = files;
            }
        }

        private void TxtFastaFile2_DragEnter_1(object sender, DragEventArgs e)
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
