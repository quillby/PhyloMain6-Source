using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class MatGAT : Form
    {
        private string similarity = PhyloMain.similarity;

        public MatGAT()
        {
            InitializeComponent();
        }

        private void MatGAT_Load(object sender, EventArgs e)
        {
            similarity = PhyloMain.IfRequired(similarity);
            string folder = Path.GetDirectoryName(similarity);
            Directory.SetCurrentDirectory(folder);
            ProcessStartInfo simid = new ProcessStartInfo();
            simid.FileName = similarity;
            simid.UseShellExecute = true;
            Process.Start(simid);
        }
    }
}
