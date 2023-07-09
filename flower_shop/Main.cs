using flower_shop.Insert;
using flower_shop.List;
using flower_shop.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        //برای ساعت
        private void Main_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
       
        }
        //ساعت 
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }
        private void تعریفگلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Flower"] == null)
            {
                Flower flo = new Flower();
                flo.MdiParent = this;
                flo.Show();
            }
            else
            {
                Application.OpenForms["Flower"].Focus();
            }
        }
        private void تعریفگلدانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FlowerPot"] == null)
            {
                FlowerPot flo = new FlowerPot();
                flo.MdiParent = this;
                flo.Show();
            }
            else
            {
                Application.OpenForms["FlowerPot"].Focus();
            }
        }

        private void تعریفکودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Fertilizer"] == null)
            {
                Fertilizer fer = new Fertilizer();
                fer.MdiParent = this;
                fer.Show();
            }
            else
            {
                Application.OpenForms["Fertilizer"].Focus();
            }
        }

        private void تعریفبذرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Seed"] == null)
            {
                Seed sed = new Seed();
                sed.MdiParent = this;
                sed.Show();
            }
            else
            {
                Application.OpenForms["Seed"].Focus();
            }
        }

        private void نقدیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Money"] == null)
            {
                Money mon = new Money();
                mon.MdiParent = this;
                mon.Show();
            }
            else
            {
                Application.OpenForms["Money"].Focus();
            }
        }

        private void فهرستگلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ListFlower"] == null)
            {
                ListFlower lis = new ListFlower();
                lis.MdiParent = this;
                lis.Show();
            }
            else
            {
                Application.OpenForms["ListFlower"].Focus();
            }
        }

        private void فهرستگلدانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ListFlowerPot"] == null)
            {
                ListFlowerPot lis = new ListFlowerPot();
                lis.MdiParent = this;
                lis.Show();
            }
            else
            {
                Application.OpenForms["ListFlowerPot"].Focus();
            }
        }

        private void فهرستکودوسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ListFertilizer"] == null)
            {
                ListFertilizer lis = new ListFertilizer();
                lis.MdiParent = this;
                lis.Show();
            }
            else
            {
                Application.OpenForms["ListFertilizer"].Focus();
            }
        }

        private void فهرستبذرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ListSeed"] == null)
            {
                ListSeed lis = new ListSeed();
                lis.MdiParent = this;
                lis.Show();
            }
            else
            {
                Application.OpenForms["ListSeed"].Focus();
            }
        }

        private void فاکتورفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
            if (Application.OpenForms["Buy"] == null)
            {
                Buy Buy = new Buy();
                Buy.MdiParent = this;
                Buy.Show();
            }
            else
            {
                Application.OpenForms["Buy"].Focus();
            }
        }

        private void فاکتورخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Sale"] == null)
            {
                Sale sel = new Sale();
                sel.MdiParent = this;
                sel.Show();
            }
            else
            {
                Application.OpenForms["Sale"].Focus();
            }
        }

        private void تعریفمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Moshtari"] == null)
            {
                Moshtari mosh = new Moshtari();
                mosh.MdiParent = this;
                mosh.Show();
            }
            else
            {
                Application.OpenForms["Moshtari"].Focus();
            }
        }

        private void نحوهیپرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Paytape"] == null)
            {
                Paytape pay = new Paytape();
                pay.MdiParent = this;
                pay.Show();
            }
            else
            {
                Application.OpenForms["Paytape"].Focus();
            }

        }

        private void هزینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Hazine"] == null)
            {
                Hazine haz = new Hazine();
                haz.MdiParent = this;
                haz.Show();
            }
            else
            {
                Application.OpenForms["Hazine"].Focus();
            }
        }

        private void جستوجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Serch"] == null)
            {
                Serch se = new Serch();
                se.MdiParent = this;
                se.Show();
            }
            else
            {
                Application.OpenForms["Serch"].Focus();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Sale"] == null)
            {
                Sale sel = new Sale();
                sel.MdiParent = this;
                sel.Show();
            }
            else
            {
                Application.OpenForms["Sale"].Focus();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Serch"] == null)
            {
                Serch se = new Serch();
                se.MdiParent = this;
                se.Show();
            }
            else
            {
                Application.OpenForms["Serch"].Focus();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Flower"] == null)
            {
                Flower flo = new Flower();
                flo.MdiParent = this;
                flo.Show();
            }
            else
            {
                Application.OpenForms["Flower"].Focus();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FlowerPot"] == null)
            {
                FlowerPot flo = new FlowerPot();
                flo.MdiParent = this;
                flo.Show();
            }
            else
            {
                Application.OpenForms["FlowerPot"].Focus();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Fertilizer"] == null)
            {
                Fertilizer fer = new Fertilizer();
                fer.MdiParent = this;
                fer.Show();
            }
            else
            {
                Application.OpenForms["Fertilizer"].Focus();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Seed"] == null)
            {
                Seed sed = new Seed();
                sed.MdiParent = this;
                sed.Show();
            }
            else
            {
                Application.OpenForms["Seed"].Focus();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Account"] == null)
            {
                Account acc = new Account();
                acc.MdiParent = this;
                acc.Show();
            }
            else
            {
                Application.OpenForms["Account"].Focus();
            }
        }

        private void بانکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Account"] == null)
            {
                Account acc = new Account();
                acc.MdiParent = this;
                acc.Show();
            }
            else
            {
                Application.OpenForms["Account"].Focus();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Money"] == null)
            {
                Money mon = new Money();
                mon.MdiParent = this;
                mon.Show();
            }
            else
            {
                Application.OpenForms["Money"].Focus();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Settings"] == null)
            {
                Settings set = new Settings();
                set.MdiParent = this;
                set.Show();
            }
            else
            {
                Application.OpenForms["Settings"].Focus();
            }
        }

    }
}
