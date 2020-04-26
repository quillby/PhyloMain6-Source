using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class OneClick : Form
    {
        public string muscle = PhyloMain.muscle;
        public string mafft = PhyloMain.mafft;
        public string clustal = PhyloMain.clustalw;
        public string figtree = PhyloMain.figtree;
        public string iqtree = PhyloMain.iqtree;
        public string fasttree = PhyloMain.fasttree;
        public string raxml = PhyloMain.raxml;
        private bool param = PhyloMain.param;
        private string options;
        private string aprog;
        private string tprog;
        private string folder;
        private string temptree;
        
        public OneClick()
        {
            InitializeComponent();
        }

        private void OneClick_Load(object sender, EventArgs e)
        {
            BtnClearAll_Click(sender, e);
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void CboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string align = cboAlign.Text;
            switch (align)
            {
                case "Muscle":
                    aprog = muscle;
                    break;
                case "MAFFT":
                    aprog = mafft;
                    break;
                case "Clustal":
                    aprog = clustal;
                    break;
            }
            btnStart.Enabled = (txtFastaFile.Text != "" && cboTree.Text != "") ? true : false;
        }

        private void CboTree_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tree = cboTree.Text;
            switch (tree)
            {
                case "FastTree":
                    tprog = "cmd.exe ";
                    break;
                case "IQ-tree":
                    tprog = iqtree;
                    break;
                case "RaxML":
                    tprog = raxml;
                    break;
            }
            btnStart.Enabled = (txtFastaFile.Text != "" && cboAlign.Text != "") ? true : false;
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtFastaFile.Clear();
            cboAlign.Text = "";
            cboTree.Text = "";
            btnStart.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //folder = Path.GetDirectoryName(txtFastaFile.Text);
            string tempalign = folder + "\\tempalign.fas";
            tempalign = PhyloMain.IfRequired(tempalign);
            string align = cboAlign.Text;
            switch (align)
            {
                case "Muscle":
                    options = " -maxiters 12 -in \"" + txtFastaFile.Text + "\" -out " + tempalign;
                    break;
                case "MAFFT":
                    options = " --maxiterate 1000 --reorder --adjustdirection \"" + txtFastaFile.Text + "\" > " + tempalign;
                    break;
                case "Clustal":
                    options = " -ALIGN -CONVERT -OUTORDER=aligned -OUTPUT=fasta -INFILE=\"" + txtFastaFile.Text + "\" -OUTFILE=" + tempalign;
                    break;
            }
            //start alignment program
            RunProg(aprog, options, param);

            temptree = Path.GetFileNameWithoutExtension(txtFastaFile.Text);
            string tree = cboTree.Text;
            switch (tree)
            {
                case "FastTree":
                    temptree = PhyloMain.IfRequired(folder + "\\" + temptree + ".tre");
                    options = "/c " + fasttree + " -gamma -gtr -nt " + tempalign + " > " + temptree;
                    break;
                case "IQ-tree":
                    temptree = PhyloMain.IfRequired(folder + "\\" + temptree + "_IQ");
                    options = " -s " + tempalign + " -redo -nt AUTO -nm 1000 -pre " + temptree;
                    break;
                case "RaxML":
                    tempalign = Path.GetFileName(tempalign);
                    options = " -s \"" + tempalign + "\" -n \"" + temptree + "\" -m GTRCAT -f a -N autoMRE -x 9363 -p 4301";
                    temptree = PhyloMain.IfRequired(folder + "\\" + "RAxML_bipartitions." + temptree);
                    break;
            }
            //start treebuilding
            RunProg(tprog, options, param);

            if (chkViewTree.Checked)
            {
                figtree = PhyloMain.IfRequired(figtree);
                ProcessStartInfo treeshow = new ProcessStartInfo();
                //Directory.SetCurrentDirectory(folder);
                treeshow.FileName = figtree;
                treeshow.Arguments = temptree;
                treeshow.UseShellExecute = false;
                Process.Start(treeshow);
            }
            if (File.Exists(PhyloMain.IfRequired(tempalign)))
            {
                File.Delete(PhyloMain.IfRequired(tempalign));
            }           
        }

        private void RunProg(string prog, string options, bool param)
        {
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            prog = PhyloMain.IfRequired(prog);
            ProcessStartInfo execute = new ProcessStartInfo();
            execute.FileName = prog;
            execute.Arguments = options;
            execute.WindowStyle = ProcessWindowStyle.Minimized;
            execute.UseShellExecute = true;
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
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);
        static readonly int GWL_STYLE = -16;
        static readonly int WS_VISIBLE = 0x10000000;

        private void PicFileOpen_MouseHover(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.None;
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
                folder = Path.GetDirectoryName(txtFastaFile.Text);
            }
        }

        private void TxtFastaFile_DragDrop_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile.Lines = files;
            }
        }

        private void TxtFastaFile_DragEnter_1(object sender, DragEventArgs e)
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
