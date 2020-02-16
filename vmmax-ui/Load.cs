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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1;

            if (bunifuProgressBar1.Value == 100)
            {
                Main objUI = new Main();
                objUI.Show();
                this.Hide();

                timer1.Stop();
            }
        }
    }
}
