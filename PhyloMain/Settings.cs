using System;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            chkHideCalc.Checked = Properties.Settings.Default.calc;
            chkHideParam.Checked = Properties.Settings.Default.param;
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            if (chkHideParam.Checked)
            {
                bool param = true;
                Properties.Settings.Default.param = param;
            }
            else
            {
                Properties.Settings.Default.param = false;
            }
            if (chkHideCalc.Checked)
            {
                bool calc = true;
                Properties.Settings.Default.calc = calc;
            }
            else
            {
                Properties.Settings.Default.calc = false;
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }
    }
}
