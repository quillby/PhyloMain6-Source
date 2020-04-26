using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class PhyloMain : Form
    {
        public static string progsdir;
        public static bool param;
        public static bool calc;
        public static string bioedit;
        public static string clustalw;
        public static string mafft;
        public static string gblocks;
        public static string raxml;
        public static string threads;
        public static string perl;
        public static string bayes;
        public static string iqtree;
        public static string figtree;
        public static string paupup;
        public static string imagemagick;
        public static string readseq;
        public static string sate;
        public static string similarity;
        public static string muscle;
        public static string fasttree;
        public static string sequencematrix;
        public static string node;
        public static string wsl;
        private string file;
        public static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + appPath + "\\PhyloMain.mdb";

        public PhyloMain()
        {
            InitializeComponent();
        }

        private void PhyloMain_Load(object sender, EventArgs e)
        {
            ReadSettings(sender, e);
            treeView1.Nodes[0].Nodes[1].ForeColor = Color.Yellow;
            foreach(TreeNode node in treeView1.Nodes)
            {
                node.ExpandAll();
            }
        }

        private void DisplayFormInRightPanel(Form frm)
        {
            Form frmPrevious = new Form();
            if (this.panel1.Controls.Count == 1)
            {
                frmPrevious.Close();
                panel1.Controls.Clear();
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
            frmPrevious = frm;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string choice = treeView1.SelectedNode.Name;
            switch (choice)
            {
                case "Node3":
                    Properties.Settings.Default.Save();
                    Application.Exit();
                    break;
                case "Node1":
                    //assign programs
                    Progs progs = new Progs();
                    DisplayFormInRightPanel(progs);
                    break;
                case "Node5":
                    Alignment align = new Alignment();
                    DisplayFormInRightPanel(align);
                    break;
                case "Node6":
                    Export exsequences = new Export();
                    DisplayFormInRightPanel(exsequences);
                    break;
                case "Node7":
                    Likelihood like = new Likelihood();
                    DisplayFormInRightPanel(like);
                    break;
                case "Node8":
                    Merge merging = new Merge();
                    DisplayFormInRightPanel(merging);
                    break;
                case "Node9":
                    ReadSeq Rseq = new ReadSeq();
                    DisplayFormInRightPanel(Rseq);
                    break;
                case "Node11":
                    IQtree qtree = new IQtree();
                    DisplayFormInRightPanel(qtree);
                    break;
                case "Node12":
                    RaxML raxml = new RaxML();
                    DisplayFormInRightPanel(raxml);
                    break;
                case "Node13":
                    Bayes mrbayes = new Bayes();
                    DisplayFormInRightPanel(mrbayes);
                    break;
                case "Node14":
                    FastTree fasttree = new FastTree();
                    DisplayFormInRightPanel(fasttree);
                    break;
                case "Node16":
                    OpenFileDialog tree = new OpenFileDialog
                    {
                        CheckFileExists = true,
                        CheckPathExists = true,
                        FilterIndex = 3,
                        Title = "Open existing tree file",
                        Filter = "Tree file (*.treefile)|*.treefile|Consensus tree (*.contree)|*.contree|Newick tree file (*.nwk,*.tre)|*.nwk;*.tre",
                        ReadOnlyChecked = true
                    };
                    if (tree.ShowDialog() == DialogResult.OK)
                    {
                        file = IfRequired(tree.FileName);
                    }
                    if (file == null)
                    {
                        break;
                    }
                    else
                    {
                        ProcessStartInfo treeshow = new ProcessStartInfo();
                        treeshow.FileName = IfRequired(figtree);
                        treeshow.Arguments = file;
                        treeshow.UseShellExecute = false;
                        Process.Start(treeshow);
                    }
                    break;
                case "Node18":
                    SequenceMatrix seqmatrix = new SequenceMatrix();
                    DisplayFormInRightPanel(seqmatrix);
                    break;
                case "Node19":
                    MatGAT matgat = new MatGAT();
                    DisplayFormInRightPanel(matgat);
                    break;
                case "Node20":
                    DnaSP dna = new DnaSP();
                    DisplayFormInRightPanel(dna);
                    break;
                case "Node21":
                    ProcessStartInfo paup = new ProcessStartInfo();
                    paup.FileName = IfRequired(paupup);
                    paup.UseShellExecute = false;
                    Process.Start(paup);
                    break;
                case "Node22":
                    ProcessStartInfo sateprog = new ProcessStartInfo();
                    sateprog.FileName = IfRequired(sate);
                    sateprog.UseShellExecute = false;
                    Process.Start(sateprog);
                    break;
                case "Node23":
                    OneClick one = new OneClick();
                    DisplayFormInRightPanel(one);
                    break;
                case "Node25":
                    Partitions part = new Partitions();
                    DisplayFormInRightPanel(part);
                    break;
                case "Node27":
                    LabelConversion label = new LabelConversion();
                    DisplayFormInRightPanel(label);
                    break;
                case "Node28":
                    Genbank gb = new Genbank();
                    DisplayFormInRightPanel(gb);
                    break;
                case "Node29":
                    Gblocks blocks = new Gblocks();
                    DisplayFormInRightPanel(blocks);
                    break;
                case "Node31":
                    node = "Node31";
                    MafftFF mff = new MafftFF();
                    DisplayFormInRightPanel(mff);
                    break;
                case "Node32":
                    node = "Node32";
                    MafftFF mff1 = new MafftFF();
                    DisplayFormInRightPanel(mff1);
                    break;
                case "Node33":
                    node = "Node33";
                    MafftFF mff2 = new MafftFF();
                    DisplayFormInRightPanel(mff2);
                    break;
                case "Node34":
                    node = "Node34";
                    MafftFF mff3 = new MafftFF();
                    DisplayFormInRightPanel(mff3);
                    break;
                case "Node35":
                    node = "Node35";
                    Linux linux = new Linux();
                    DisplayFormInRightPanel(linux);
                    break;
                case "Node36":
                    Disclaimer dis = new Disclaimer();
                    DisplayFormInRightPanel(dis);
                    break;
            }              
        }

        public static void ReadSettings(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Progs ORDER BY ID";
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.Connection = null;
            OleDbConnection con = new OleDbConnection(PhyloMain.connectionString);
            SQLQuery.CommandText = query;
            SQLQuery.Connection = con;
            DataTable data = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                int id = Convert.ToInt16(dr["ID"].ToString());
                string loc = dr["Location"].ToString();
                switch (id)       
                {
                    case 1:
                        progsdir = loc;
                        break;
                    case 2:
                        bioedit = loc;
                        break;
                    case 3:
                        clustalw = loc;
                        break;
                    case 4:
                        figtree = loc;
                        break;
                    case 5:
                        gblocks = loc;
                        break;
                    case 6:
                        imagemagick = loc;
                        break;
                    case 7:
                        iqtree = loc;
                        break;
                    case 8:
                        mafft = loc;
                        break;
                    case 9:
                        similarity = loc;
                        break;
                    case 10:
                        bayes = loc;
                        break;
                    case 11:
                        muscle = loc;
                        break;
                    case 12:
                        paupup = loc;
                        break;
                    case 13:
                        sate = loc;
                        break;
                    case 14:
                        sequencematrix = loc;
                        break;
                    case 15:
                        perl = loc;
                        break;
                    case 16:
                        fasttree = loc;
                        break;
                    case 17:
                        raxml = loc;
                        break;
                    case 18:
                        threads = loc;
                        break;
                    case 19:
                        readseq = loc;
                        break;
                    case 20:
                        wsl = loc;
                        break;
                    case 21:
                        param = (loc == "yes") ? false : true;
                        break;
                }
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        public static string IfRequired(string pr)
        {
            return !string.IsNullOrWhiteSpace(pr) ?
        pr.Contains(" ") && (!pr.StartsWith("\"") && !pr.EndsWith("\"")) ?
            "\"" + pr + "\"" : pr :
            string.Empty;
        }

        public static bool IDlines(string align)
        {
            bool toolong = false;
            string line = "";
            int length = 0;
            StreamReader gbfile = new StreamReader(align);
            while ((line = gbfile.ReadLine()) != null)
            {
                if (line.Contains(">"))
                {
                    length = line.Length;
                    if (length > 50)
                    {
                        toolong = true;
                        break;
                    }
                }
            }
            gbfile.Dispose();
            return toolong;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
