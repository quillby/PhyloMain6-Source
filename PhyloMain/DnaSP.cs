using System;
using System.IO;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class DnaSP : Form
    {
        private int n = 1;
        private string[] nrhaplos;
        private string[] hapchars;
        private string ntax;
        private string nchar;

        public DnaSP()
        {
            InitializeComponent();
        }

        private void DnaSP_Load(object sender, EventArgs e)
        {
            dgvTraits.Rows.Clear();
            if (dgvTraits.Columns.Count > 1)
            {
                for (int x = n; x > 1; x--)
                {
                    dgvTraits.Columns.Remove("Column" + x.ToString());
                }
            }
            txtDnaSP.Clear();
            txtPopArt.Clear();
            txtTraitName.Clear();
            numTraits.Value = 2;
            btnWritePopArt.Enabled = false;
        }

        private void PicFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dnasp = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open DnaSP file",
                FilterIndex = 1,
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (dnasp.ShowDialog() == DialogResult.OK)
            {
                txtDnaSP.Text = dnasp.FileName;
                //if (txtDnaSP.Text.Contains(" "))
                //{
                //    MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
            }
            SearchHaplotypes(txtDnaSP.Text);
        }

        private void PicFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog popart = new SaveFileDialog
            {
                Filter = "Nexus files (*.nex)|*.nex|All files (*.*)|*.*",
                FileName="popart.nex",
                FilterIndex = 1
            };
            if (popart.ShowDialog() == DialogResult.OK)
            {
                txtPopArt.Text = popart.FileName;
                if (txtPopArt.Text.Contains(" "))
                {
                    string cfile = txtPopArt.Text;
                    if (File.Exists(PhyloMain.IfRequired(cfile)))
                    {
                        File.Delete(cfile);
                    }
                    //MessageBox.Show("Spaces in directory or filename are not allowed.\nIt will throw an error.", "No spaces allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }                
                btnWritePopArt.Enabled = txtPopArt.Text != "" ? true : false;
            }
        }

        private void TxtTraitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (n > numTraits.Value)
            {
                txtTraitName.Clear();
                MessageBox.Show("All traits have been entered.", "All done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTraitName.Text != "")
                {
                    string col = "Column" + (n + 1).ToString();
                    dgvTraits.Columns.Add(col, txtTraitName.Text);
                    n++;
                    txtTraitName.Clear();
                }
            }
        }

        private void SearchHaplotypes(string temp)
        {
            temp = PhyloMain.IfRequired(temp);
            string sBuf = "";
            StreamReader haplotypes = new StreamReader(temp);
            sBuf = haplotypes.ReadToEnd();
            haplotypes.Close();
            if (!sBuf.Contains("DnaSP"))
            {
                MessageBox.Show("This file doesn't seem to be a DnaSP file.", "Check format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDnaSP.Clear();
                return;
            }
            string line = "";
            int count = 0;
            //find number of taxa (haplotype groups)            
            StreamReader all = new StreamReader(temp);
            line = all.ReadLine();
            while (line != null)
            {
                if (line.Contains("NTAX="))
                {
                    int start = line.IndexOf("NTAX=") + "NTAX=".Length;
                    int end = line.IndexOf(";") - start;
                    ntax = line.Substring(start, end);
                    nrhaplos = new string[Convert.ToInt16(ntax)];
                }
                if (line.Contains("[Hap#"))
                {
                    line = all.ReadLine();
                    do
                    {
                        int start2 = line.IndexOf(":") + ":".Length;
                        nrhaplos[count] = line.Substring(start2 + 1, 3);
                        count++;
                        line = all.ReadLine();
                    } while (line.Contains("[Hap_"));
                    break;
                }
                line = all.ReadLine();
            }
            all.Close();
            int totalhaps = nrhaplos.Length;
            for (int i = 0; i < totalhaps; i++)
            {
                //dgvTraits.Rows.Add();
                string item= "Hap_" + (i + 1).ToString() + ": " + nrhaplos[i].ToString();
                dgvTraits.Rows.Insert(i, item);
            }
            StreamReader chars = new StreamReader(temp);
            line = chars.ReadLine();
            while (chars != null)
            {
                if (line.Contains("NCHAR="))
                {
                    int start = line.IndexOf("NCHAR=") + "NCHAR=".Length;
                    int end = line.IndexOf(";") - start;
                    nchar = line.Substring(start, end);
                    hapchars = new string[Convert.ToInt16(nchar)];
                }
                if (line.Contains("MATRIX"))
                {
                    line = chars.ReadLine();
                    line = chars.ReadLine();
                    line = chars.ReadLine();
                    count = 0;
                    do
                    {
                        hapchars[count] = line;
                        count++;
                        line = chars.ReadLine();
                    } while (line.Contains("Hap_"));
                    break;
                }
                line = chars.ReadLine();
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            DnaSP_Load(sender, e);
        }

        private void BtnWritePopArt_Click(object sender, EventArgs e)
        {
            string pfile = PhyloMain.IfRequired(txtPopArt.Text);
            StreamWriter pop = new StreamWriter(pfile, true);
            pop.WriteLine("#NEXUS");
            pop.WriteLine("BEGIN TAXA;");
            pop.WriteLine("DIMENSIONS NTAX=" + ntax + ";");
            pop.WriteLine("TAXLABELS");
            for(int x = 1; x <= Convert.ToInt16(ntax); x++)
            {
                pop.WriteLine("Hap_" + x.ToString());
            }
            pop.WriteLine(";");
            pop.WriteLine("END;");
            pop.WriteLine(" ");
            pop.WriteLine("BEGIN CHARACTERS;");
            pop.WriteLine("DIMENSIONS NCHAR=" + nchar + ";");
            pop.WriteLine("FORMAT DATATYPE=DNA MISSING=? GAP=- MATCHCHAR=. ;");
            pop.WriteLine("MATRIX");
            for (int x = 0; x < Convert.ToInt16(ntax); x++)
            {
                pop.WriteLine(hapchars[x]);
            }
            pop.WriteLine(";");
            pop.WriteLine("END;");
            pop.WriteLine(" ");
            pop.WriteLine("BEGIN TRAITS;");
            pop.WriteLine("Dimensions NTRAITS=" + numTraits.Value.ToString() + ";");
            pop.WriteLine("Format labels=yes missing=? separator=Comma;");
            string traitlabels = "";
            for(int c = 1; c < dgvTraits.ColumnCount; c++)
            {
                traitlabels += dgvTraits.Columns[c].HeaderText + " ";
            }
            pop.WriteLine("TraitLabels " + traitlabels + ";");
            pop.WriteLine("Matrix");
            string values = "";
            for(int r = 0; r < dgvTraits.RowCount; r++)
            {
                for(int c = 1; c < dgvTraits.ColumnCount; c++)
                {
                    values += dgvTraits.Rows[r].Cells[c].Value + ",";
                }
                values = values.Substring(0, values.Length - 1);
                pop.WriteLine("Hap_" + (r+1).ToString() + " " + values);
                values = "";
            }
            pop.WriteLine(";");
            pop.WriteLine("END;");
            pop.Close();
            btnWritePopArt.Enabled = false;
        }

        private void PicFileOpen_MouseHover(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.None;
        }

        private void PicFileSave_MouseHover(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileSave_MouseLeave(object sender, EventArgs e)
        {
            picFileSave.BorderStyle = BorderStyle.None;
        }

        private void TxtDnaSP_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtDnaSP.Lines = files;
            }
        }

        private void TxtDnaSP_DragEnter(object sender, DragEventArgs e)
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

        private void TxtPopArt_DoubleClick(object sender, EventArgs e)
        {
            PicFileSave_Click(sender, e);
        }
    }
}
