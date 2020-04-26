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
    public partial class IQtree : Form
    {
        string iqtree = PhyloMain.iqtree;
        string figtree = PhyloMain.figtree;
        bool param = PhyloMain.param;
        string options = "";
        string folder = "";

        SynchronizationContext originalContext = SynchronizationContext.Current;
        List<ProcessStartInfo> processes = new List<ProcessStartInfo>();

        public IQtree()
        {
            InitializeComponent();
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
            txtPartition.Text = "";
            txtPartition.Enabled = false;
            cboModels.Text = "JC";
            cboModels.Enabled = false;
            picPartitionFile.Enabled = false;
            txtBootstraps.Enabled = false;
            txtLRTiterations.Enabled = false;
            txtNonBS.Enabled = false;
            btnStartIQ.Enabled = false;
            chkCommand.Checked = true;
    }

        private void BtnStartIQ_Click(object sender, EventArgs e)
        {
            btnStartIQ.Enabled = false;
            btnNew.Enabled = false;
            string fasta = Path.GetFileName(txtFastaFile.Text);
            folder = Path.GetDirectoryName(txtFastaFile.Text);
            Environment.CurrentDirectory = folder;
            options = " -s " + fasta + " -redo -nt AUTO -nm " + txtMaxIterations.Text;
            if (chkSubstitution.Checked)
            {
                options += " -m " + cboModels.Text;
            }
            else
            {
                options += " -m MFP+MERGE";
            }
            if (chkPartition.Checked)
            {
                options += " -spp" + txtPartition.Text;
            }
            if (rdbAIC.Checked)
            {
                options += " -merit AIC";
            }
            if (rdbAICc.Checked)
            {
                options += " -merit AICc";
            }
            if (chkBayes.Checked)
            {
                options += " -abayes";
            }
            if (chkLRT.Checked)
            {
                options += " -alrt " + txtLRTiterations.Text;
            }
            if (chkBootstraps.Checked)
            {
                options += " -bb " + txtBootstraps.Text;
            }
            if (chkNonBS.Checked)
            {
                options += " -b " + txtNonBS.Text;
            }
            if (chkShort.Checked)
            {
                options += " -pers 0.2 -nstop 500";
            }
            if (chkNNI.Checked)
            {
                options += " -allnni";
            }
            if (chkBranch.Checked && chkBootstraps.Checked)
            {
                options += " -bnni";
            }
            if (chkTest.Checked)
            {
                options += " -zb 1000 -zw -au";
            }
            string bfile = Path.GetFileNameWithoutExtension(txtIQtree.Text);
            options += " -pre " + bfile;

            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            iqtree = PhyloMain.IfRequired(iqtree);

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
            process1.FileName = iqtree;
            process1.Arguments = options;
            processes.Add(process1);

            if (chkViewTree.Checked)
            {
                string tree = bfile + ".treefile";
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
                btnStartIQ.Enabled = false;
                btnNew.Enabled = false;
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
                    btnStartIQ.Enabled = true;
                    btnNew.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("The program " + iqtree + " encountered on error.", "Execution halted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = true; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartIQ.Enabled = false; }, null); });
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
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartIQ.Enabled = true; }, null); });
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnNew.Enabled = true; }, null); });
                    }
                });
                th.Start();
            }
            if (chkCommand.Checked)
            {
                if (chkViewTree.Checked)
                {
                    string tree = bfile + ".treefile";
                    Process.Start(figtree, tree);
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //clear all and reset default settings
            var cntls = GetAll(this, typeof(CheckBox));
            foreach (Control cntrl in cntls)
            {
                CheckBox _cb = (CheckBox)cntrl;
                if (_cb.Checked)
                {
                    _cb.Checked = false;
                }
            }
            txtBootstraps.Text = "1000";
            txtFastaFile.Clear();
            txtIQtree.Clear();
            txtLRTiterations.Text = "1000";
            txtMaxIterations.Text = "1000";
            txtNonBS.Text = "100";
            txtNonBS.Enabled = false;
            txtPartition.Clear();
            rdbBIC.Checked = true;
            btnStartIQ.Enabled = false;
            chkCommand.Checked = true;
        }

        private void PicPartitionFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog partition = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open partition file",
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (partition.ShowDialog() == DialogResult.OK)
            {
                txtPartition.Text = partition.FileName;
            }
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta file for alignment",
                Filter = "Alignment (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.*",
                FilterIndex = 1,
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
                folder = Path.GetDirectoryName(txtFastaFile.Text);
                Environment.CurrentDirectory = folder;
            }
        }

        private void PicSaveTree_Click(object sender, EventArgs e)
        {
            string afile = txtFastaFile.Text;
            string bfile = Path.GetFileNameWithoutExtension(afile) + "_IQ";
            SaveFileDialog align = new SaveFileDialog
            {
                FileName = bfile
            };
            if (align.ShowDialog() == DialogResult.OK)
            {
                txtIQtree.Text = align.FileName;
            }
        }

        private void ChkSubstitution_CheckedChanged(object sender, EventArgs e)
        {
            cboModels.Enabled = chkSubstitution.Checked ? true : false;
            chkPartition.Enabled = chkSubstitution.Checked ? false : true;
            chkModel.Enabled = chkSubstitution.Checked ? false : true;
        }

        private void ChkLRT_CheckedChanged(object sender, EventArgs e)
        {
            txtLRTiterations.Enabled = chkLRT.Checked ? true : false;
        }

        private void ChkBootstraps_CheckedChanged(object sender, EventArgs e)
        {
            txtBootstraps.Enabled = chkBootstraps.Checked ? true : false;
            chkNonBS.Enabled = chkBootstraps.Checked ? false : true;
        }

        private void ChkNonBS_CheckedChanged(object sender, EventArgs e)
        {
            txtNonBS.Enabled = chkNonBS.Checked ? true : false;           
            chkBootstraps.Enabled = chkNonBS.Checked ? false : true;
        }

        private void ChkPartition_CheckedChanged(object sender, EventArgs e)
        {
            txtPartition.Enabled = chkPartition.Checked ? true : false;
            chkModel.Enabled = chkPartition.Checked ? true : false;
            picPartitionFile.Enabled = chkPartition.Checked ? true : false;
            chkSubstitution.Enabled= chkPartition.Checked ? false : true;
            cboModels.Enabled = chkPartition.Checked ? false : true;
        }

        private void RunFigTree(string file)
        {
            OpenFileDialog tree = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = file,
                FilterIndex = 1,
                Title = "Open IQ-tree file",
                Filter = "Tree file (*.treefile)|*.treefile|Consensus tree (*.contree)|*.contree",
                ReadOnlyChecked = true
            };
            if (tree.ShowDialog() == DialogResult.OK)
            {
                file = PhyloMain.IfRequired(tree.FileName);
            }
            figtree = PhyloMain.IfRequired(figtree);
            ProcessStartInfo treeshow = new ProcessStartInfo();
            treeshow.FileName = figtree;
            treeshow.Arguments = file;
            treeshow.UseShellExecute = false;
            Process.Start(treeshow);
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
            //if (txtFastaFile.Text.Contains(" "))
            //{
            //    MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            btnStartIQ.Enabled = txtIQtree.Text != "" ? true : false;
        }

        private void TxtIQtree_TextChanged(object sender, EventArgs e)
        {
            //if (txtIQtree.Text.Contains(" "))
            //{
            //    MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            btnStartIQ.Enabled = txtFastaFile.Text != "" ? true : false;
        }

        private void TxtIQtree_DoubleClick(object sender, EventArgs e)
        {
            PicSaveTree_Click(sender, e);
        }

        private void TxtFastaFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile.Lines = files;
                folder = Path.GetDirectoryName(txtFastaFile.Text);
                Environment.CurrentDirectory = folder;
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
