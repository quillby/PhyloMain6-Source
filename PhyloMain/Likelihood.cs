using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Likelihood : Form
    {
        private string file;
        private string options;
        private string iqtree = PhyloMain.iqtree;
        private string magick = PhyloMain.imagemagick;

        public Likelihood()
        {
            InitializeComponent();
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
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
                file = fasta.FileName;
                txtFastaFile.Text = file;
            }
        }

        private void BtnLikelihood_Click(object sender, EventArgs e)
        {
            iqtree = PhyloMain.IfRequired(iqtree);
            file = PhyloMain.IfRequired(file);
            btnLikelihood.Enabled = false;
            options = " -s " + "\"" + file + "\"" + " -redo -nt AUTO -lmap 2000 -n 0 -m TESTONLY";
            ProcessStartInfo execute = new ProcessStartInfo
            {
                FileName = iqtree,
                Arguments = options,
                WindowStyle = ProcessWindowStyle.Minimized,
                UseShellExecute = false,
                RedirectStandardOutput = false
            };
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
            btnLikelihood.Enabled = true;
            MessageBox.Show("Three files are created: " + file + ".iqtree, " + file + ".lmap.svg, " + file + ".lmap.eps", "Calculation finished succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (chkLogfile.Checked)
            {
                string cfile = "\"" + file + ".iqtree\"";
                Process n = new Process();
                n.StartInfo.FileName = "notepad.exe";
                n.StartInfo.Arguments = cfile;      // file + ".iqtree";
                n.Start();
                n.Close();
            }
            if (chkDiagram.Checked)
            {
                string cfile = "\"" + file + ".lmap.svg\"";
                Process m = new Process();
                m.StartInfo.FileName = magick;
                m.StartInfo.Arguments = cfile;      // file + ".iqtree";
                m.Start();
                m.Close();
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

        private void PicFastaOpen_MouseHover(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFastaOpen_MouseLeave(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.None;
        }

        private void TxtFastaFile_TextChanged(object sender, EventArgs e)
        {

            if (txtFastaFile.Text!="")
            {
                btnLikelihood.Enabled = true;
                //    MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
            }
            else
            {
                btnLikelihood.Enabled = false;
            }
        }

        private void TxtFastaFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile.Lines = files;
                file = txtFastaFile.Text;
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
    }
}
