using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop.Other
{
    public partial class Welcome : Form
    {
        Main ma = new Main();
        public Welcome()
        {
            InitializeComponent();
        }

        int t = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            label3.Text = t.ToString();
            if (t == 0)
            {
                ma.Show();
                this.Hide();
            }

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
    }
}
