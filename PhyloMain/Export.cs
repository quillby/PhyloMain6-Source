using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace PhyloMain
{
    public partial class Export : Form
    {
        private int total = 0;
        private string fasta;
        private int itemscount = 0;

        public Export()
        {
            InitializeComponent();
        }

        private void PicFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open fasta file or alignment",
                Filter = "Fasta files (*.fas)|*.fas|Alignment file (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
            }
        }

        private void PicSelSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog export = new SaveFileDialog
            {
                Title = "Save exported sequences as",
                Filter = "Fasta files (*.fas)|*.fas|Alignment file (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.*",
                FileName = "export.fas"
            };
            if (export.ShowDialog() == DialogResult.OK)
            {
                txtSelection.Text = export.FileName;
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lstShowExport.Clear();
            lstShowExport.Columns.Add("Exported sequences");
            lstShowExport.Columns[0].Width = -2;
            picShow.Visible = true;
            lblShow.Visible = true;
            lstShowExport.Visible = true;
            foreach (var line in File.ReadLines(txtSelection.Text))
            {
                if (chkIDonly.Checked)
                {
                    if (line.Contains(">"))
                        lstShowExport.Items.Add(line);
                }
                else
                {
                    lstShowExport.Items.Add(line);
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if(txtFastaFile.Text=="" || txtSelection.Text == "")
            {
                MessageBox.Show("Filenames are missing to continue", "Data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string export = txtSelection.Text;
            string line = "";
            string splitC = cboSplit.Text;
            string temp = "";
            fasta = txtFastaFile.Text;
            if (!chkAppend.Checked)
            {
                total = 0;
            }
            //total=0;
            var sb = new StringBuilder();
            StreamReader file = new StreamReader(fasta);
            //should ID be reduced
            line = file.ReadLine();
            if (chkReduce.Checked && lstItems.Items.Count > 0)
            {
                while (!file.EndOfStream)
                    if (line != "" && line.Substring(0, 1) == ">")
                    {
                        //search item found
                        if (line.Contains(txtSearch.Text))
                        {
                            line = line.Substring(1, line.Length - 1);
                            temp = ">";
                            string[] lines = line.Split(Convert.ToChar(splitC));
                            int indices = lstItems.Items.Count;
                            if (lines.Length != itemscount)
                            {
                                MessageBox.Show("It seems there are lines in the fasta file,\nthat don't have the same amount of items.", "Check items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            for (int i = 0; i < indices; i++)
                            {
                                //check whether items is checked, if yes add to 'temp'
                                if (lstItems.GetItemCheckState(i) == CheckState.Checked)
                                {
                                    temp += lines[i] + splitC;
                                }
                            }
                            temp = temp.Substring(0, temp.Length - 1);
                            sb.AppendLine(temp);
                            line = file.ReadLine();
                            // append lines that contain sequence information
                            while (line.Substring(0, 1) != ">" && !file.EndOfStream)
                            {
                                sb.AppendLine(line);
                                line = file.ReadLine();
                                if (line == "") break;
                            }
                            total += 1;
                            txtTotalExported.Text = total.ToString();
                            txtTotalExported.Refresh();
                        }
                        else
                        {
                            line = file.ReadLine();
                        }
                    }
                    else
                    {
                        if(line == "")
                        {
                            MessageBox.Show("There are empty lines in this file.\nThe program is unable to handle empty lines.\n\nEdit the file and try again.", "Empty lines in file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        line = file.ReadLine();
                    }
                //write the last line
                sb.AppendLine(line);
            }           
            //not reduced
            else
            {
                while (!file.EndOfStream)
                    if (line !="" && line.Substring(0, 1) == ">")
                    {
                        //search item found
                        if (line.Contains(txtSearch.Text))
                        {
                            sb.AppendLine(line);
                            line = file.ReadLine();
                            do
                            {
                                sb.AppendLine(line);
                                line = file.ReadLine();
                            }
                            while (line.Substring(0, 1) != ">" && !file.EndOfStream);                       
                            total += 1;
                            txtTotalExported.Text = total.ToString();
                            txtTotalExported.Refresh();
                        }
                        else
                        {
                            line = file.ReadLine();
                        }
                    }
                    else
                    {
                        line = file.ReadLine();
                    }
                // write last line
                sb.AppendLine(line);
            }
            file.Close();
            if (total > 0)
            {
                using (StreamWriter exfile = new StreamWriter(export, chkAppend.Checked))
                {
                    exfile.WriteLine(sb.ToString());
                }
            }           
            btnShow.Enabled = txtTotalExported.Text != "0" ? true : false;
            chkIDonly.Enabled = txtTotalExported.Text != "0" ? true : false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            chkAppend.Checked = false;
            chkIDonly.Checked = false;
            chkIDonly.Enabled = false;
            txtSearch.Clear();
            txtFastaFile.Clear();
            txtSelection.Clear();
            btnShow.Enabled = false;
            chkReduce.Checked = false;
            cboSplit.Text = "";
            total = 0;
            txtTotalExported.Text = total.ToString();
            txtTotalExported.Refresh();
            lstItems.Items.Clear();
        }

        private void ChkReduce_CheckedChanged(object sender, EventArgs e)
        {
            cboSplit.Enabled = chkReduce.Checked ? true : false;
            lstItems.Enabled = chkReduce.Checked ? true : false;
        }

        private void CboSplit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regel = "";
            string splitC = "";
            fasta = txtFastaFile.Text;
            if (fasta == "")
            {
                return;
            }
            lstItems.Items.Clear();
            splitC = cboSplit.Text;
            List<string> lines = File.ReadAllLines(fasta).ToList();
            foreach (string line in lines)
            {
                regel = line.Substring(1, line.Length - 1);
                string[] items = regel.Split(Convert.ToChar(splitC));
                itemscount = items.Length;  //used to compare every fasta line to have the same item count
                if (items.Count() > 1) { 
                    foreach (string chars in items)
                    {
                        lstItems.Items.Add(chars);
                    }
                }
                break;
            }          
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            lstShowExport.Visible = false;
            picShow.Visible = false;
            lblShow.Visible = false;
        }

        private void Export_Load(object sender, EventArgs e)
        {
            BtnReset_Click(sender, e);
        }

        private void PicFileOpen_MouseHover(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.BorderStyle = BorderStyle.None;
        }

        private void PicSelSave_MouseHover(object sender, EventArgs e)
        {
            picSelSave.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicSelSave_MouseLeave(object sender, EventArgs e)
        {
            picSelSave.BorderStyle = BorderStyle.None;
        }

        private void TxtFastaFile_TextChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = txtSelection.Text != "" ? true : false;
        }

        private void TxtSelection_TextChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = txtFastaFile.Text != "" ? true : false;
        }

        private void TxtSelection_DoubleClick(object sender, EventArgs e)
        {
            PicSelSave_Click(sender, e);
        }

        private void TxtFastaFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFastaFile.Lines = files;
                fasta = txtFastaFile.Text;
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

        private void PicShow_MouseHover(object sender, EventArgs e)
        {
            picShow.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicShow_MouseLeave(object sender, EventArgs e)
        {
            picShow.BorderStyle = BorderStyle.None;
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnExport_Click(sender, e);
            }
        }

        private void LblShow_MouseHover(object sender, EventArgs e)
        {
            lblShow.ForeColor = Color.WhiteSmoke;
            lblShow.BackColor = Color.Black;
        }

        private void LblShow_MouseLeave(object sender, EventArgs e)
        {
            lblShow.ForeColor = Color.Black;
            lblShow.BackColor = Color.WhiteSmoke;
        }

        private void LblShow_Click(object sender, EventArgs e)
        {
            PictureBox1_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PictureBox1_Click(sender, e);
        }
    }
}
