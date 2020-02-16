using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vmmax_ui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tabSelect1_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tabPage1;
        }

        private void tabSelect2_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tabPage2;
        }

        private void tabSelect3_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tabPage3;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //TOPMOST
        private void alwaysOnTopCheckBox_OnValueChange(object sender, EventArgs e)
        {
            if(alwaysOnTopCheckBox.Value == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        //ALWAYS REPORT CRASHES
        private void crashReportCheckBox_OnValueChange(object sender, EventArgs e)
        {
            if(crashReportCheckBox.Value == true)
            {
                Globals.Globals.alwaysReportCrash = true;
            }
            else
            {
                Globals.Globals.alwaysReportCrash = false;
            }
        }
    }
}
