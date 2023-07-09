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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flower_shop.Insert
{
    public partial class Flower : Form
    {
        public Flower()
        {
            InitializeComponent();
        }
        
        private void Picselect()
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "انتخاب تصویر";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = op.FileName;
                }
            }
            catch
            {
                MessageBox.Show("خطا در بارگذاری تصویر", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void but_addpicture_Click(object sender, EventArgs e)
        {
         Picselect();
        }
        public static byte[] ImageToByte(Image img) // image ذخیره عکس در فیلد 
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
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

        public void DGV()
        {
            try
            {
                SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name_Flower, Buy_Price, Sale_Price, Explanation, Number, time, Picture FROM Tflower ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;                
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "شماره";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView1.Columns[2].HeaderText = "قیمت خرید";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView1.Columns[3].HeaderText = "قیمت فروش";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].HeaderText = "توضیحات";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "تعداد";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[6].HeaderText = "تاریخ";
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[7].HeaderText = "تصویر";
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
            }
            catch
            {
            }
        }
        private void but_addflower_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tex_name.Text))
                    errorProvider1.SetError(tex_name, "لطفا نام را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_buy.Text))
                    errorProvider1.SetError(tex_buy, "لطفا قیمت خرید را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_sell.Text))
                    errorProvider1.SetError(tex_sell, "لطفا نام قیمت فروش را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_number.Text))
                    errorProvider1.SetError(tex_number, "لطفا تعداد را وارد کیند");
                else
                {


                    SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                    se.Open();
                    SqlCommand comm = new SqlCommand("INSERT INTO Tflower(Name_Flower,Buy_Price,Sale_Price,Number,Explanation,Picture,time) VALUES (@n,@b,@s,@u,@d,@p,@t)", se);

                    comm.Parameters.AddWithValue("@n", tex_name.Text);
                    comm.Parameters.AddWithValue("@b", tex_buy.Text);
                    comm.Parameters.AddWithValue("@s", tex_sell.Text);
                    comm.Parameters.AddWithValue("@u", tex_number.Text);
                    comm.Parameters.AddWithValue("@d", tex_descripion.Text);
                    comm.Parameters.AddWithValue("@p", ImageToByte(pictureBox1.Image));
                    comm.Parameters.AddWithValue("@t", DateTime.Now.ToString());

                    comm.ExecuteNonQuery();
                    se.Close();

                    MessageBox.Show("باموفقیت ثبت شد ","موفق");
                    ClearTxt(this);
                    pictureBox1.Image = null;
                    DGV();
                }
            }
            catch
            {

            }
        }

        private void Flower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFlowershopDataSet.Tflower' table. You can move, or remove it, as needed.
            this.tflowerTableAdapter.Fill(this.databaseFlowershopDataSet.Tflower);

          
            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
            se.Open();
            string query = "SELECT Name_Flower FROM Tflower";
            SqlCommand comm = new SqlCommand(query,se);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["Name_Flower"].ToString();
                comflower.Items.Add(name);
            }
            se.Close();
            DGV();
        }

        private void but_adddflower_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text_buy.Text))
                    errorProvider1.SetError(text_buy, "لطفا قیمت خرید را وارد کیند");
                if (string.IsNullOrWhiteSpace(text_sale.Text))
                    errorProvider1.SetError(text_sale, "لطفا قیمت فروش را وارد کیند");
                if (string.IsNullOrWhiteSpace(text_number.Text))
                    errorProvider1.SetError(text_number, "لطفا نام تعداد را وارد کیند");
                else
                {
                    string buy = text_buy.Text;
                    string sale = text_sale.Text;
                    string number = text_number.Text;
                    string name = comflower.SelectedItem.ToString();

                    SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                    se.Open();
                    string queryy = "SELECT Number FROM Tflower WHERE Name_Flower='" + name + "'";
                    SqlCommand commm = new SqlCommand(queryy, se);
                    SqlDataReader reader = commm.ExecuteReader();
                    reader.Read();
                    string reed = reader["Number"].ToString();
                    int ree = Convert.ToInt32(reed);
                    int y = Convert.ToInt32(text_number.Text);
                    int av = ree * y;
                    string xz = av.ToString();
                    reader.Close();
                                    
                    string query = "UPDATE Tflower SET Buy_Price='" + buy + "',Sale_Price='" + sale + "',Number='" + xz + "' WHERE Name_Flower='" + name + "'";
                    SqlCommand comm = new SqlCommand(query, se);

                    comm.ExecuteNonQuery();
                    se.Close();
                    MessageBox.Show("با موفقیت افزایش یافت", "موفق");
                    ClearTxt(this);
                    comflower.SelectedItem = null;
                    comitem();
                    DGV();
                }
            }
            catch
            {

            }
        }
        private void comitem()
        {
            text_number.Enabled = false;
            text_buy.Enabled = false;
            text_sale.Enabled = false;
        }
        private void comitemm()
        {
            text_number.Enabled = true;
            text_buy.Enabled = true;
            text_sale.Enabled = true;
        }
        private void comflower_SelectedIndexChanged(object sender, EventArgs e)
        {
            comitemm();
        }
    }
}
