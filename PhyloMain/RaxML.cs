using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class RaxML : Form
    {
        string raxml = PhyloMain.raxml;
        string threads = PhyloMain.threads;
        bool param = PhyloMain.param;
        string figtree = PhyloMain.figtree;
        string options = "";
        string folder = "";

        SynchronizationContext originalContext = SynchronizationContext.Current;
        List<ProcessStartInfo> processes = new List<ProcessStartInfo>();

        public RaxML()
        {
            InitializeComponent();
            lblParam.Text = param ? "parameters invisible" : "parameters visible";
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtBootstraps.Text = "1000";
            txtFastaFile.Clear();
            txtRaxMLtree.Clear();
            chkDefault.Checked = true;
            chkThreads.Checked = false;
            chkViewTree.Checked = false;
            txtThreads.Text = "2";
            txtThreads.Enabled = false;
            chkCommand.Checked = true;
        }

        private void BtnStartRaxML_Click(object sender, EventArgs e)
        {
            if(txtFastaFile.Text=="" || txtRaxMLtree.Text == "")
            {
                return;
            }
            string fasta = Path.GetFileName(txtFastaFile.Text);
            string mltree = Path.GetFileName(txtRaxMLtree.Text);
            string program = raxml;
            folder = Path.GetDirectoryName(txtRaxMLtree.Text);
            options = " -s \"" + fasta + "\" -n \"" + mltree + "\" -m GTRCAT -f a -x 5434 -p 3493";
            if (chkAmountTaxa.Checked)
            {
                options = " -D" + options;
            }
            else
            {
                options = " -d" + options;
            }
            if (chkDefault.Checked)
            {
                options += " -N autoMRE";
            }
            else
            {
                options += " -N " + txtBootstraps.Text;
            }           
            if (chkThreads.Checked)
            {
                program = threads;
                options += " -T " + txtThreads.Text;
            }
            string bfile = Path.GetFileNameWithoutExtension(txtFastaFile.Text);

            string raxmlfile = Path.GetFileName(txtRaxMLtree.Text);
            if (File.Exists(PhyloMain.IfRequired(folder + "\\RAxML_info." + raxmlfile)))
            {
                DialogResult answer = MessageBox.Show("A calculation with the same name already exists.\nDo you want to delete this session?", "RAxML calculation exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (answer)
                {
                    case DialogResult.Yes:
                        {
                            foreach (string f in Directory.EnumerateFiles(PhyloMain.IfRequired(folder), "RAxML*.*"))
                            {
                                File.Delete(PhyloMain.IfRequired(f));
                            }
                            break;
                        }
                    case DialogResult.No:
                        {
                            txtRaxMLtree.Clear();
                            return;
                        }
                }
            }
            if (!param)
            {
                MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Directory.SetCurrentDirectory(PhyloMain.IfRequired(folder));
            raxml = PhyloMain.IfRequired(raxml);

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
            process1.FileName = raxml;
            process1.Arguments = options;
            processes.Add(process1);

            if (chkViewTree.Checked)
            {
                string tree = PhyloMain.IfRequired(folder + "\\RAxML_bipartitions." + bfile + ".tre");
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
                btnStartRaxML.Enabled = false;
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
                    btnStartRaxML.Enabled = true;
                    btnNew.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("The program " + raxml + " encountered on error.", "Execution halted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = true; }, null); });
                    ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartRaxML.Enabled = false; }, null); });
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
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnStartRaxML.Enabled = true; }, null); });
                        ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnNew.Enabled = true; }, null); });
                    }
                });
                th.Start();
            }
            if (chkCommand.Checked)
            {
                if (chkViewTree.Checked)
                {
                    string tree = PhyloMain.IfRequired(folder + "\\RAxML_bipartitions." + bfile + ".tre");
                    Process.Start(figtree, tree);
                }
            }

            //btnStartRaxML.Enabled = false;
            //btnNew.Enabled = false;
            //RunProg(program, options, param);
            //btnStartRaxML.Enabled = true;
            //btnNew.Enabled = true;

            //if (chkViewTree.Checked)
            //{                
            //    string tree = PhyloMain.IfRequired(folder + "\\RAxML_bipartitions." + bfile + ".tre");
            //    RunFigTree(tree);
            //}
        }

        private void ChkDefault_CheckedChanged(object sender, EventArgs e)
        {
            txtBootstraps.Enabled = chkDefault.Checked ? false : true;
        }

        private void ChkThreads_CheckedChanged(object sender, EventArgs e)
        {
            txtThreads.Enabled = chkThreads.Checked ? true : false;
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta file for alignment",
                Filter = "Fasta files (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
                folder = Path.GetDirectoryName(txtFastaFile.Text);
            }
        }

        private void PicSaveTree_Click(object sender, EventArgs e)
        {
            string afile = txtFastaFile.Text;
            string bfile = Path.GetFileNameWithoutExtension(afile) + ".tre";
            SaveFileDialog align = new SaveFileDialog
            {
                Filter = "Newick tree (*.tre)|*.tre",
                FilterIndex = 2,
                FileName = bfile
            };
            if (align.ShowDialog() == DialogResult.OK)
            {
                txtRaxMLtree.Text = align.FileName;
            }
            if (txtFastaFile.Text != "")
            {
                folder = Path.GetDirectoryName(txtFastaFile.Text);
                string raxmlfile = Path.GetFileName(txtRaxMLtree.Text);
                if (File.Exists(PhyloMain.IfRequired(folder + "\\RAxML_info." + raxmlfile)))
                {
                    DialogResult answer = MessageBox.Show("A calculation with the same name already exists.\nDo you want to delete this session?", "RAxML calculation exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (answer)
                    {
                        case DialogResult.Yes:
                            {
                                foreach (string f in Directory.EnumerateFiles(PhyloMain.IfRequired(folder), "RAxML*.*"))
                                {
                                    File.Delete(PhyloMain.IfRequired(f));
                                }
                                break;
                            }
                        case DialogResult.No:
                            {
                                txtRaxMLtree.Clear();
                                return;
                            }
                    }
                }
            }           
        }

        //private void RunProg(string prog, string options, bool param)
        //{
        //    string raxmlfile = Path.GetFileName(txtRaxMLtree.Text);
        //    if (File.Exists(PhyloMain.IfRequired(folder + "\\RAxML_info." + raxmlfile)))
        //    {
        //        DialogResult answer = MessageBox.Show("A calculation with the same name already exists.\nDo you want to delete this session?", "RAxML calculation exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        switch (answer)
        //        {
        //            case DialogResult.Yes:
        //                {
        //                    foreach (string f in Directory.EnumerateFiles(PhyloMain.IfRequired(folder), "RAxML*.*"))
        //                    {
        //                        File.Delete(PhyloMain.IfRequired(f));
        //                    }
        //                    break;
        //                }
        //            case DialogResult.No:
        //                {
        //                    txtRaxMLtree.Clear();
        //                    return;
        //                }
        //        }
        //    }
        //        if (!param)
        //    {
        //        MessageBox.Show(options, "Parameters used for calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    ProcessStartInfo execute = new ProcessStartInfo();
        //    Directory.SetCurrentDirectory(PhyloMain.IfRequired(folder));
        //    prog = PhyloMain.IfRequired(prog);
        //    execute.FileName = prog;
        //    execute.Arguments = options;
        //    execute.WindowStyle = ProcessWindowStyle.Minimized;
        //    execute.UseShellExecute = false;
        //    execute.RedirectStandardOutput = false;
        //    try
        //    {
        //        using (Process exeProcess = Process.Start(execute))
        //        {
        //            panel1.Visible = true;
        //            Thread.Sleep(100);
        //            SetParent(exeProcess.MainWindowHandle, panel1.Handle);
        //            SetWindowLong(exeProcess.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
        //            MoveWindow(exeProcess.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        //            exeProcess.WaitForExit();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("The defined options are not correct.","Check the amount of taxa",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //    }         
        //    panel1.Visible = false;
        //}

        //private void RunFigTree(string file)
        //{
        //    figtree = PhyloMain.IfRequired(figtree);
        //    ProcessStartInfo treeshow = new ProcessStartInfo();
        //    treeshow.FileName = figtree;
        //    treeshow.Arguments = file;
        //    treeshow.UseShellExecute = false;
        //    Process.Start(treeshow);
        //}

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
            btnStartRaxML.Enabled = txtRaxMLtree.Text != "" ? true : false;
        }

        private void TxtRaxMLtree_TextChanged(object sender, EventArgs e)
        {
            btnStartRaxML.Enabled = txtFastaFile.Text != "" ? true : false;
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

        private void TxtRaxMLtree_DoubleClick(object sender, EventArgs e)
        {
            PicSaveTree_Click(sender, e);
        }
    }
}
