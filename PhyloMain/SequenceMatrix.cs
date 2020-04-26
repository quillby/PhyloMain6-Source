using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class SequenceMatrix : Form
    {
        private string sequencematrix = PhyloMain.sequencematrix;

        public SequenceMatrix()
        {
            InitializeComponent();
        }

        private void SequenceMatrix_Load(object sender, EventArgs e)
        {
            sequencematrix = PhyloMain.IfRequired(sequencematrix);
            ProcessStartInfo execute = new ProcessStartInfo();
            execute.FileName = sequencematrix;
            execute.UseShellExecute = false;
            Process.Start(execute);
        }
    }
}
