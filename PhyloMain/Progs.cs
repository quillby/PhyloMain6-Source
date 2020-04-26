using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Progs : Form
    {
        private bool saved;

        public Progs()
        {
            InitializeComponent();
        }

        private void Progs_Load(object sender, EventArgs e)
        {
            saved = true;
            btnSave.Enabled = false;
            listView1.View = View.Details;
            listView1.Items.Clear();
            string query = "SELECT * FROM Progs ORDER BY ID";
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            OleDbConnection con = new OleDbConnection(PhyloMain.connectionString);
            SQLQuery.CommandText = query;
            SQLQuery.Connection = con;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                listitem.SubItems.Add(dr["ProgName"].ToString());
                listitem.SubItems.Add(dr["Location"].ToString());
                listView1.Items.Add(listitem);
                if (dr["ProgName"].ToString() == "param")
                {
                    chkParameter.Checked = dr["Location"].ToString() == "yes" ? false : true;
                }
            }
        }

        private void Progs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!saved)
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Changes are not saved yet.\nDo you want to save?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.No)
                {
                    return;
                }
                else
                {
                    BtnSave_Click(sender, e);
                    PhyloMain.param = listView1.Items[19].SubItems[2].Text == "yes" ? false : true;
                }
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(PhyloMain.connectionString);
            SQLQuery.Connection = con;
            saved = true;
            btnSave.Enabled = false;
            foreach (ListViewItem item in listView1.Items)
            {
                int id = Convert.ToInt16(item.SubItems[0].Text);
                string progname = item.SubItems[1].Text;
                string content = item.SubItems[2].Text;
                string query = "UPDATE Progs SET ProgName='" + progname + "', Location='" + content + "' WHERE ID=" + id;
                SQLQuery.CommandText = query;
                con.Open();
                SQLQuery.ExecuteNonQuery();
                con.Close();
            }
            PhyloMain.param = listView1.Items[19].SubItems[2].Text == "yes" ? false : true;
            Progs_Load(sender, e);
            PhyloMain.ReadSettings(sender, e);
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            btnBrowse.Enabled = true;
            btnSave.Enabled = true;
            int id= Convert.ToInt16(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text);
            string progname= listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
            string content = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
            label3.Text = progname;
            txtProgName.Text = content;
            label3.Visible = true;
            if (progname == "param")
            {
                btnBrowse.Visible = false;
                txtProgName.Visible = false;
                cboParam.Visible = true;
                return;
            }
            else
            {
                btnBrowse.Visible = true;
                txtProgName.Visible = true;
                cboParam.Visible = false;
            }
            if (progname == "progsdir")
            {
                FolderBrowserDialog pd = new FolderBrowserDialog();
                pd.ShowNewFolderButton = false;
                DialogResult result = pd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = pd.SelectedPath;
                    saved = false;
                }
                else
                {
                    listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = txtProgName.Text;
                }
                label3.Visible = false;
                txtProgName.Visible = false;
                btnBrowse.Visible = false;
            }
            else
            {
                OpenFileDialog pn = new OpenFileDialog()
                {
                    Title="Choose directory and program",
                    Filter="Program (*.*)|*.*",
                    FileName = txtProgName.Text
                };
                DialogResult result = pn.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = pn.FileName;
                    saved = false;
                }
                else
                {
                    listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = txtProgName.Text;
                }
                label3.Visible = false;
                txtProgName.Visible = false;
                btnBrowse.Visible = false;
            }
            //saved = false;
        }

        private void CboParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = cboParam.Text;
            cboParam.Visible = false;
            label3.Visible = false;
            saved = false;
            btnSave.Enabled = true;
        }
    }
}
