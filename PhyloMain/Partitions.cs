using System;
using System.IO;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Partitions : Form
    {
        private int line;
        private string charset;
        private bool partsaved;
        private string partfile;

        public Partitions()
        {
            InitializeComponent();
        }

        private void Partitions_Load(object sender, EventArgs e)
        {
            BtnClear_Click(sender, e);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNrGenes.Clear();
            txtMarker.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            btnSave.Enabled = false;
            btnAddItem.Enabled = true;
            dgvPartitions.Rows.Clear();
            chkShow.Checked = false;
            chkChar.Checked = false;
            line = 0;
            txtNrGenes.Focus();
            btnHomPart.Enabled = false;
            partsaved = false;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt16(txtNrGenes.Text);
            if (txtMarker.Text != "" && txtFrom.Text != "" && txtTo.Text != "" && line < nr)
            {
                dgvPartitions.Rows.Insert(line, txtMarker.Text, txtFrom.Text, txtTo.Text);
                line++;
                txtMarker.Clear();
                int temp = Convert.ToInt16(txtTo.Text);
                temp += 1;
                txtFrom.Text = temp.ToString();
                txtTo.Clear();
                txtMarker.Focus();
            }
            if (line == Convert.ToInt16(txtNrGenes.Text))
            {
                txtTo.Clear();
                txtFrom.Clear();
                txtMarker.Clear();
                btnAddItem.Enabled = false;
                btnSave.Enabled = true;
                btnSave.Focus();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            string line;            
            SaveFileDialog partition = new SaveFileDialog()
            {               
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "partition.nex"
            };
            if (partition.ShowDialog() == DialogResult.OK)
            {
                partfile = partition.FileName;
            }
            else
            {
                return;
            }
            string cpartfile = PhyloMain.IfRequired(partfile);
            StreamWriter sb = new StreamWriter(cpartfile);
            //sb.WriteLine("#NEXUS");
            sb.WriteLine("BEGIN SETS;");
            for(int r = 0; r < dgvPartitions.RowCount; r++)
            {
                line = "CHARSET " + dgvPartitions.Rows[r].Cells[0].Value + " = " + dgvPartitions.Rows[r].Cells[1].Value + "-" + dgvPartitions.Rows[r].Cells[2].Value + ";";
                sb.WriteLine(line);
                charset += line.Substring(8) + ", ";
            }
            if (chkChar.Checked)
            {
                string newChar = charset.Replace(" = ", ":");
                string newChar2 = newChar.Replace(";", "");
                charset = newChar2.Substring(0, newChar2.Length - 2);
                sb.WriteLine("CHARPARTITION " + txtMyChar.Text + "=" + charset + ";");
            }
            sb.WriteLine("END;");
            sb.Close();
            btnSave.Enabled = true;
            txtTo.Clear();
            txtFrom.Clear();
            btnClear.Focus();
            partsaved = true;
            btnHomPart.Enabled = true;
            Msg("part");
        }

        private void ChkChar_CheckedChanged(object sender, EventArgs e)
        {
            txtMyChar.Visible = chkChar.Checked ? true : false;
        }

        private void TxtNexusFile_TextChanged(object sender, EventArgs e)
        {
            //if (txtNexusFile.Text.Contains(" "))
            //{
            //    MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            btnHomPart.Enabled = txtNexusFile.Text != "" ? true : false;
        }

        private void PicFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog nexus = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Nexus alignment",
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (nexus.ShowDialog() == DialogResult.OK)
            {
                txtNexusFile.Text = nexus.FileName;
            }
        }

        private void BtnHomPart_Click(object sender, EventArgs e)
        {
            if (!partsaved)
            {
                MessageBox.Show("First create and save a partition file with charpartition", "No partition file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string cpartfile = PhyloMain.IfRequired(partfile); // + ".log"
            string cnexus = PhyloMain.IfRequired(txtNexusFile.Text);
            string logfile = Path.GetFileNameWithoutExtension(txtNexusFile.Text);
            string curdir = Path.GetDirectoryName(txtNexusFile.Text);
            logfile = PhyloMain.IfRequired(curdir + "\\" + logfile + ".log");
            StreamReader addpart = new StreamReader(cpartfile);
            string all = addpart.ReadToEnd();
            string repall = all.Replace("#NEXUS", "");
            addpart.Close();
            File.AppendAllText(cnexus, repall);
            StreamWriter hompart = new StreamWriter(cnexus, true);
            hompart.WriteLine(" ");
            hompart.WriteLine("BEGIN PAUP;");
            hompart.WriteLine("log file=" + logfile + " append;");
            //hompart.WriteLine("set increase;");
            hompart.WriteLine("exclude uninf;");
            hompart.WriteLine("set autoclose=yes;");
            hompart.WriteLine("set criterion=parsimony;");
            hompart.WriteLine("set increase=auto;");
            hompart.WriteLine("hompart partition=" + txtMyChar.Text + " nreps=100 search=heuristic / start=stepwise addseq=random nreps=5 savereps=no randomize=addseq rstatus=no swap=tbr hold=1 multree=yes timelimit=600;");
            hompart.WriteLine("include all;");
            hompart.WriteLine("log stop;");
            hompart.WriteLine("END;");
            hompart.Close();
            Msg("hompart");
        }

        private void Msg(string what)
        {
            switch (what)
            {
                case "part":
                    MessageBox.Show("The partition file has been saved.", "Saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "hompart":
                    MessageBox.Show("The PAUP file has been saved and can be executed in PaupUp.", "Saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
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

        private void TxtNexusFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtNexusFile.Lines = files;
            }
        }

        private void TxtNexusFile_DragEnter(object sender, DragEventArgs e)
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
