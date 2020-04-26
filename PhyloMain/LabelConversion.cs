using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhyloMain
{
    public partial class LabelConversion : Form
    {
        private static Excel.Workbook LabelBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet Sheet1 = null;
        private string props;
        private string Ci;
        private int totCols;
        private int totRows;
        private string ConvertedFile;
        private bool fasta;
        string bioedit = PhyloMain.bioedit;
        string figtree = PhyloMain.figtree;

        public LabelConversion()
        {
            InitializeComponent();
        }
        private void LabelConversion_Load(object sender, EventArgs e)
        {
            cboProps.Enabled = false;
            txtConvertedFile.Clear();
            txtExcel.Clear();
            txtFastaFile.Clear();
            txtOpenTree.Clear();
            chkConvTree.Checked = false;
            chkConvFasta.Checked = false;
            chkConvFasta.Enabled = false;
            chkConvTree.Enabled = false;
            btnConvert.Enabled = false;
            lblProps.Text = "";
            cboProps.Text = "";
            props = "";
            Ci = "";
            txtFinished.Clear();
            txtFinished.Visible = false;
        }

        private void PicFastaOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fasta = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Fasta file",
                FilterIndex = 1,
                Filter = "Fasta files (*.fas)|*.fas|Alignment (*.afa)|*.afa|GBlock alignment (*.gb)|*.gb|All files (*.*)|*.* ",
                ReadOnlyChecked = true
            };
            if (fasta.ShowDialog() == DialogResult.OK)
            {
                txtFastaFile.Text = fasta.FileName;
            }
        }

        private void PicTreeOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog tree = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Tree file",
                FilterIndex = 2,
                Filter = "IQ-tree files (*.treefile)|*.treefile|Tree files(*.tre)|*.tre|Newick files (*.nwk)|*.nwk|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (tree.ShowDialog() == DialogResult.OK)
            {
                txtOpenTree.Text = tree.FileName;
            }
        }

        private void PicExcelOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog labels = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Open Excel file",
                FilterIndex = 1,
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                ReadOnlyChecked = true
            };
            if (labels.ShowDialog() == DialogResult.OK)
            {
                txtExcel.Text = labels.FileName;
            }
            //fill cboProps with Excel file column headers
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            //string cExcel = PhyloMain.IfRequired(txtExcel.Text);
            LabelBook = MyApp.Workbooks.Open(txtExcel.Text);
            Sheet1 = (Excel.Worksheet)LabelBook.Sheets[1];
            totCols = Sheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Column;
            cboProps.Items.Clear();
            for(int index = 3; index <= totCols; index++)
            {
                cboProps.Items.Add(Sheet1.Cells[1,index].Value);
            }
            cboProps.Enabled = true;
        }

        private void PicSaveConversion_Click(object sender, EventArgs e)
        {
            if (txtFastaFile.Text != "")
            {
                string fileWE = Path.GetFileNameWithoutExtension(txtFastaFile.Text);

                fileWE += "_convert";
                SaveFileDialog temp = new SaveFileDialog
                {
                    Filter = "Fasta files (*.fas)|*.fas|Alignment file (*.afa)|*.afa|GBlock file (*.gb)|*.gb|All files (*.*)|*.*",
                    FilterIndex = 1,
                    FileName = fileWE
                };
                if (temp.ShowDialog() == DialogResult.OK)
                {
                    txtConvertedFile.Text = temp.FileName;
                }
                chkConvFasta.Enabled = txtConvertedFile.Text != "" ? true:false;
            }
            else
            {
                string fileWE = Path.GetFileNameWithoutExtension(txtOpenTree.Text);
                fileWE += "_convert.nwk";
                SaveFileDialog temp = new SaveFileDialog
                {
                    Filter = "Newick files (*.nwk)|*.nwk|All files (*.*)|*.*",
                    FilterIndex = 1,
                    FileName = fileWE
                };
                if (temp.ShowDialog() == DialogResult.OK)
                {
                    txtConvertedFile.Text = temp.FileName;
                }
                chkConvTree.Enabled = txtConvertedFile.Text != "" ? true : false;
            }
            
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            txtWarning.Visible = true;
            btnReset.Focus();
            btnConvert.Enabled = false;
            ConvertedFile = txtConvertedFile.Text;
            //in case Fasta is opened
            if (txtFastaFile.Text != "")
            {                   
                fasta = true;
            }
            if (txtOpenTree.Text != "")
            {
                fasta = false;
            }
            string[] Ci_item = Ci.Split('-');
            totRows = Sheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            string sFileName = fasta ? txtFastaFile.Text : txtOpenTree.Text;
            string[] props_item = props.Split('-');
            var content = string.Empty;
            StreamReader sBuf = new StreamReader(sFileName);
            content = sBuf.ReadToEnd();
            sBuf.Close();
            StreamWriter sb = new StreamWriter(ConvertedFile);
            for (int v = 2; v <= totRows; v++)
            {
                string FullName = "";
                string Details = "";
                string DetailList = "";
                string StrainID = Sheet1.Cells[v, 1].Value;
                string species = Sheet1.Cells[v, 2].Value;
                FullName = StrainID + " " + species;
                if (props != "")
                {
                    for (int y = 0; y < props_item.Length; y++)
                    {
                        int k = Convert.ToInt16(Ci_item[y]);
                        Details = Sheet1.Cells[v, k + 3].Value;
                        if (Details != null)
                        {
                            DetailList += Details + txtPiping.Text;
                            Details = null;
                        }
                    }
                }
                if (DetailList != "")
                {
                    DetailList = " [" + DetailList.Substring(0, DetailList.Length - 1) + "]";
                    content = fasta ? content.Replace(StrainID, FullName + DetailList) : content.Replace(StrainID, "'" + FullName + DetailList + "'");
                }
                else
                {
                    content = fasta ? content.Replace(StrainID, FullName) : content.Replace(StrainID, "'" + FullName + "'");
                }
            }
            sb.Write(content);
            sb.Close();               
            LabelBook.Close();
            MyApp.Quit();
            //release objects
            releaseObject(LabelBook);
            releaseObject(MyApp);
            txtFinished.Text = "Conversion finished. File saved as:" + Environment.NewLine + txtConvertedFile.Text;
            txtFinished.Visible = true;
            txtWarning.Visible = false;
            if (chkConvFasta.Checked)
            {
                bioedit = PhyloMain.IfRequired(bioedit);
                Process show = new Process();               
                show.StartInfo.FileName = bioedit;
                show.StartInfo.Arguments = PhyloMain.IfRequired(ConvertedFile);
                show.Start();
            }
            if (chkConvTree.Checked)
            {
                figtree = PhyloMain.IfRequired(figtree);
                Process show = new Process();
                show.StartInfo.FileName = figtree;
                show.StartInfo.Arguments = PhyloMain.IfRequired(ConvertedFile);
                show.Start();
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void TxtFastaFile_TextChanged(object sender, EventArgs e)
        {
            picTreeOpen.Enabled = txtFastaFile.Text != "" ? false : true;
            txtOpenTree.Enabled = txtFastaFile.Text != "" ? false : true;
        }

        private void TxtOpenTree_TextChanged(object sender, EventArgs e)
        {
            picFastaOpen.Enabled = txtOpenTree.Text != "" ? false : true;
            txtFastaFile.Enabled= txtOpenTree.Text != "" ? false : true;
        }

        private void TxtConvertedFile_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = txtConvertedFile.Text != "" ? true : false;
        }

        private void CboProps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (props == "")
            {
                props = cboProps.Text;
                Ci = cboProps.SelectedIndex.ToString();
            }
            else
            {
                props += "-" + cboProps.Text;
                Ci += "-" + cboProps.SelectedIndex.ToString();
            }
            lblProps.Text = props;
            lblProps.Refresh();
            lblProps.Visible = props.Length == 0 ? false : true;
        }

        private void PicReset_Click(object sender, EventArgs e)
        {
            props = "";
            Ci = "";
            lblProps.Text = "";
            cboProps.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LabelConversion_Load(sender, e);
        }

        private void PicFastaOpen_MouseHover(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicFastaOpen_MouseLeave(object sender, EventArgs e)
        {
            picFastaOpen.BorderStyle = BorderStyle.None;
        }

        private void PicTreeOpen_MouseHover(object sender, EventArgs e)
        {
            picTreeOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicTreeOpen_MouseLeave(object sender, EventArgs e)
        {
            picTreeOpen.BorderStyle = BorderStyle.None;
        }

        private void PicExcelOpen_MouseHover(object sender, EventArgs e)
        {
            picExcelOpen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicExcelOpen_MouseLeave(object sender, EventArgs e)
        {
            picExcelOpen.BorderStyle = BorderStyle.None;
        }

        private void PicSaveConversion_MouseHover(object sender, EventArgs e)
        {
            picSaveConversion.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PicSaveConversion_MouseLeave(object sender, EventArgs e)
        {
            picSaveConversion.BorderStyle = BorderStyle.None;
        }

        private void TxtConvertedFile_DoubleClick(object sender, EventArgs e)
        {
            PicSaveConversion_Click(sender, e);
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

        private void TxtOpenTree_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtOpenTree.Lines = files;
            }            
        }

        private void TxtOpenTree_DragEnter(object sender, DragEventArgs e)
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

        private void TxtExcel_DoubleClick(object sender, EventArgs e)
        {
            PicExcelOpen_Click(sender, e);
        }
    }
}
