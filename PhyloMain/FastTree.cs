using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class FastTree : Form
    {
        public bool param= PhyloMain.param;
        public string options = "";
        public string fasttree = PhyloMain.fasttree;
        public string figtree = PhyloMain.figtree;
        public string folder = "";

        public FastTree()
        {
            InitializeComponent();
        }

        private void FastTree_Load(object sender, EventArgs e)
        {
            btnFastTree.Enabled = false;
            txtFasttree.Clear();
            txtFastaFile.Clear();
            chkViewTree.Checked = false;
            chkCommand.Checked = true;
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta file for alignment",
                Filter = "Fasta files (*.fas)|*.fas|Alignment (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.*",
                FilterIndex = 2,
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
            }
        }

        private void PicSaveTree_Click(object sender, EventArgs e)
        {
            string afile = txtFastaFile.Text;
            string bfile = Path.GetFileNameWithoutExtension(afile) + ".tre";     // afile.Substring(0, afile.Length - 4);
            SaveFileDialog align = new SaveFileDialog
            {
                Filter = "All files (*.tre)|*.tre",
                FilterIndex = 2,
                FileName = bfile
            };
            if (align.ShowDialog() == DialogResult.OK)
            {
                txtFasttree.Text = align.FileName;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            btnFastTree.Enabled = false;
            txtFasttree.Clear();
            txtFastaFile.Clear();
            chkViewTree.Checked = false;
            chkCommand.Checked = true;
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void BtnFastTree_Click(object sender, EventArgs e)
        {
            SynchronizationContext originalContext = SynchronizationContext.Current;
            List<ProcessStartInfo> processes = new List<ProcessStartInfo>();
            string align = PhyloMain.IfRequired(txtFastaFile.Text);
            string tree = PhyloMain.IfRequired(txtFasttree.Text);
            string fastprog = PhyloMain.IfRequired(fasttree);
            options = " -gamma -gtr -nt " + align + " > " + tree;
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            process1.Arguments = "/C " + fastprog + " " + options;
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
                btnFastTree.Enabled = false;
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
                    btnFastTree.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("The program " + fastprog + " encountered on error.", "Execution halted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = true; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnFastTree.Enabled = false; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnNew.Enabled = false; }, null); });
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
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnFastTree.Enabled = true; }, null); });
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnNew.Enabled = true; }, null); });
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

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
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

        private void PicSaveTree_MouseHover(object sender, EventArgs e)
        {
            picSaveTree.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicSaveTree_MouseLeave(object sender, EventArgs e)
        {
            picSaveTree.BorderStyle = BorderStyle.None;
        }

        private void TxtFastaFile_TextChanged(object sender, EventArgs e)
        {
            btnFastTree.Enabled = txtFasttree.Text != "" ? true : false;
        }

        private void TxtFasttree_TextChanged(object sender, EventArgs e)
        {
            btnFastTree.Enabled = txtFastaFile.Text != "" ? true : false;
        }

        private void TxtFasttree_DoubleClick(object sender, EventArgs e)
        {
            PicSaveTree_Click(sender, e);
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
