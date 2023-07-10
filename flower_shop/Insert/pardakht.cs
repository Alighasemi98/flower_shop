using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flower_shop.Insert
{
    public partial class pardakht : Form
    { 
        public pardakht()
        {
            InitializeComponent();
        }
        int x, y, z;
        public string xx;
        public string xxx;
        public string xxxx;
        public string xxxxx;
        private void butpar_Click(object sender, EventArgs e)
        {
            
            Invoicing invo = new Invoicing();
            invo.toopar.Text = texprise.Text;
            invo.labnamee.Text = xx;
            invo.labnumber.Text = xxx;
            invo.labnoe.Text = xxxx;
            invo.labadress.Text = xxxxx;

            invo.Show();
            this.Hide();
            
        }

        private void textakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')

            {
                e.Handled = true;
            }
        }

        private void pardakht_Load(object sender, EventArgs e)
        {
            drvd();
        }


        private void drvd()
        {
            string st = texghaemat.Text.ToString().Replace(",", "");
            x = Convert.ToInt32(st);
            y = int.Parse(textakh.Text);

            z = x - y;
            texprise.Text = z.ToString();
            texprise.Text = Convert.ToInt32(texprise.Text).ToString("n0");
            if (z < 0)
            {
                texprise.Enabled = false;
                MessageBox.Show("قیمت  منفی وجود ندارد ", "اختار");
            }
            else
            {
                texprise.Enabled = true;
            }
        }
        private void textakh_TextChanged(object sender, EventArgs e)
        {
            drvd();
        }    
    }
}
