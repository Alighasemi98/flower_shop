using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop.Insert
{
    public partial class Invoicing : Form
    {
        

        public Invoicing()
        {
            InitializeComponent();
        }
        private string connacion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True";
        private void Invoicing_Load(object sender, EventArgs e)
        {
            recordlood();
            total();
            totall();
            
        }
        private void recordlood()
        {
            try
            {
                SqlConnection se = new SqlConnection(connacion);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name,Number,Sale_Price,Sale_PriceAll FROM Record ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                se.Dispose();
                dataGridView2.Columns[0].HeaderText = "شماره";
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[1].HeaderText = "نام";
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[2].HeaderText = "تعداد";
                dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[3].HeaderText = "قیمت واحد";
                dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[4].HeaderText = "قیمت کل";
                dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();

            }
            catch
            {

            }
        }
        private void total()
        {
            double price = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                price += (int)dataGridView2[4, i].Value;
            }
            toopricee.Text = price.ToString();
            toopricee.Text = Convert.ToInt32(toopricee.Text).ToString("n0");
        }
        private void totall()
        {
            double price = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                price += (int)dataGridView2[2, i].Value;
            }
            toonumber.Text = " تعداد کل :" + "  " + price.ToString();
        }


        private void tooback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ساری هنوز پرینت کامل نشده");
        }

        private void labnoe_Click(object sender, EventArgs e)
        {

        }
    }
}
