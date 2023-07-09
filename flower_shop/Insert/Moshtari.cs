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
    public partial class Moshtari : Form
    {
        public Moshtari()
        {
            InitializeComponent();
        }
        private void listt()
        {
            try
            {
                SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Name,Number,Noe,Addres,Moshakhas FROM TMoshtari ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "شماره";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView1.Columns[2].HeaderText = "شماره تماس";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView1.Columns[3].HeaderText = "نوع خرید";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].HeaderText = "ادرس";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "توضیحات";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
            }
            catch
            {
            }
        }

        private void butsabt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(texname.Text))
                    errorProvider1.SetError(texname, "لطفا نام را وارد کیند");
                if (string.IsNullOrWhiteSpace(texnumber.Text))
                    errorProvider1.SetError(texnumber, "لطفا شماره تماس را وارد کیند");
                if (string.IsNullOrWhiteSpace(texshakhsi.Text))
                    errorProvider1.SetError(texshakhsi, "لطفا نوع خرید را وارد کیند");
                if (string.IsNullOrWhiteSpace(texadres.Text))
                    errorProvider1.SetError(texadres, "لطفا ادرس را وارد کیند");
                else
                {


                    SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                    se.Open();
                    SqlCommand comm = new SqlCommand("INSERT INTO TMoshtari(Name,Number,Noe,Addres,Moshakhas) VALUES (@n,@u,@s,@a,@m)", se);

                    comm.Parameters.AddWithValue("@n", texname.Text);
                    comm.Parameters.AddWithValue("@u", texnumber.Text);
                    comm.Parameters.AddWithValue("@s", texshakhsi.Text);
                    comm.Parameters.AddWithValue("@a", texadres.Text);
                    comm.Parameters.AddWithValue("@m", textizih.Text);
                    comm.ExecuteNonQuery();
                    se.Close();

                    MessageBox.Show("باموفقیت ثبت شد ", "موفق");

                }
            }
            catch
            {

            }
            listt();
        }

        private void Moshtari_Load(object sender, EventArgs e)
        {
            listt();
        }
    }
}
