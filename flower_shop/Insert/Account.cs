using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop.Insert
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        private void ClearTxt(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBoxBase)
                {
                    c.ResetText();
                }
                else if (c.Controls != null)
                {
                    ClearTxt(c);
                }
            }
            errorProvider1.Clear();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                    groupBox1.Enabled = true;
                else
                    groupBox1.Enabled = false;
            }
            catch
            {
            }
            ClearTxt(this);
        }
    }
}
