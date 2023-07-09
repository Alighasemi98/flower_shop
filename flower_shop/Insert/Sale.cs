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
    public partial class Sale : Form
    {
      //  public Invoicing invoo;
        public Sale()
        {
            InitializeComponent();
        }
        private string connacion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True";

        // لود کومبو باکس ها و دیتا ها 
        private void flowerlood()
        {
            try
            {
                SqlConnection se = new SqlConnection(connacion);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Name_Flower,Sale_Price,Explanation,Number,Picture FROM Tflower ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "نام";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "قیمت فروش";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "توضیحات";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "تعداد موجود";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "تصویر";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
                todutadd.Enabled = true;

            }
            catch
            {

            }
        }
        private void flowerpotlood()
        {
            try
            {
                SqlConnection se = new SqlConnection(connacion);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name_FlowerPot, Sale_Price, Explanation,Number,Picture FROM TFlowerPot ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "نام";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "قیمت فروش";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "توضیحات";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "تعداد موجود";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "تصویر";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
                todutadd.Enabled = true;

            }
            catch
            {

            }
        }
        private void fertilizerlood()
        {
            try
            {
                SqlConnection se = new SqlConnection(connacion);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name_Fertilizer, Sale_Price, Explanation,Number,Picture FROM TFertilizer ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "نام";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "قیمت فروش";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "توضیحات";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "تعداد موجود";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "تصویر";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
                todutadd.Enabled = true;

            }
            catch
            {

            }
        }
        private void seedlood()
        {
            try
            {
                SqlConnection se = new SqlConnection(connacion);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name_Seed,Sale_Price,Explanation,Number,Picture FROM TSeed ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                se.Dispose();
                dataGridView1.Columns[0].HeaderText = "نام";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "قیمت فروش";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "توضیحات";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "تعداد موجود";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "تصویر";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
                todutadd.Enabled = true;

            }
            catch
            {

            }
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
        private int prozxs = 0, faktor = 0;
        private void addflower()
        { 
                string numbber = textBox1.Text;
                prozxs =(int) dataGridView1.CurrentRow.Cells[0].Value;
                SqlConnection sc = new SqlConnection(connacion);
                sc.Open();
                string numberre = "SELECT Sale_Price FROM Tflower WHERE Id=@Id";
                SqlCommand resultumber = new SqlCommand(numberre, sc);
                resultumber.Parameters.AddWithValue("@Id", prozxs);
                var reznum = resultumber.ExecuteReader();
                reznum.Read();
                string reed = reznum["Sale_Price"].ToString();
                int ree = Convert.ToInt32(reed);
                int y = Convert.ToInt32(textBox1.Text);
                int av = ree * y;
                string xz = av.ToString();
                reznum.Close();

                string selectquery = "SELECT Id,Name_Flower,sale_Price,Number FROM Tflower WHERE Id=@Id";
                string insertquery = "INSERT INTO Record (Name,Number,Sale_Price,Sale_PriceAll) VALUES (@Name,'" + numbber + "',@Sale_Price,'" + xz + "')";
             try
             { 
                SqlCommand comselect = new SqlCommand(selectquery, sc);
                comselect.Parameters.AddWithValue("@Id", prozxs);
                var resultselectquery = comselect.ExecuteReader();
                SqlCommand cominsert = new SqlCommand(insertquery, sc);


                while (resultselectquery.Read())
                {
                    cominsert.Parameters.AddWithValue("@Name", resultselectquery[1]);
                    cominsert.Parameters.AddWithValue("@Number", resultselectquery[2]);
                    cominsert.Parameters.AddWithValue("@Sale_Price", resultselectquery[3]);
                    cominsert.Parameters.AddWithValue("@Sale_PriceAll", xz);
                }
                resultselectquery.Close();
                cominsert.ExecuteNonQuery();
             }
            
             finally
             {
                sc.Close();
             }
        }

        private void addflowerPot()
        {
            string numbber = textBox1.Text;
            prozxs = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlConnection sc = new SqlConnection(connacion);
            sc.Open();
            string numberre = "SELECT Sale_Price FROM TFlowerPot WHERE Id=@Id";
            SqlCommand resultumber = new SqlCommand(numberre, sc);
            resultumber.Parameters.AddWithValue("@Id", prozxs);
            var reznum = resultumber.ExecuteReader();
            reznum.Read();
            string reed = reznum["Sale_Price"].ToString();
            int ree = Convert.ToInt32(reed);
            int y = Convert.ToInt32(textBox1.Text);
            int av = ree * y;
            string xz = av.ToString();
            reznum.Close();

            string selectquery = "SELECT Id,Name_FlowerPot,sale_Price,Number FROM TFlowerPot WHERE Id=@Id";
            string insertquery = "INSERT INTO Record (Name,Number,Sale_Price,Sale_PriceAll) VALUES (@Name,'" + numbber + "',@Sale_Price,'" + xz + "')";
            try
            {
                SqlCommand comselect = new SqlCommand(selectquery, sc);
                comselect.Parameters.AddWithValue("@Id", prozxs);
                var resultselectquery = comselect.ExecuteReader();
                SqlCommand cominsert = new SqlCommand(insertquery, sc);


                while (resultselectquery.Read())
                {
                    cominsert.Parameters.AddWithValue("@Name", resultselectquery[1]);
                    cominsert.Parameters.AddWithValue("@Number", resultselectquery[2]);
                    cominsert.Parameters.AddWithValue("@Sale_Price", resultselectquery[3]);
                    cominsert.Parameters.AddWithValue("@Sale_PriceAll", xz);
                }
                resultselectquery.Close();
                cominsert.ExecuteNonQuery();
            }

            finally
            {
                sc.Close();
            }
        }
        private void addfertilizer()
        {
            string numbber = textBox1.Text;
            prozxs = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlConnection sc = new SqlConnection(connacion);
            sc.Open();
            string numberre = "SELECT Sale_Price FROM TFertilizer WHERE Id=@Id";
            SqlCommand resultumber = new SqlCommand(numberre, sc);
            resultumber.Parameters.AddWithValue("@Id", prozxs);
            var reznum = resultumber.ExecuteReader();
            reznum.Read();
            string reed = reznum["Sale_Price"].ToString();
            int ree = Convert.ToInt32(reed);
            int y = Convert.ToInt32(textBox1.Text);
            int av = ree * y;
            string xz = av.ToString();
            reznum.Close();

            string selectquery = "SELECT Id,Name_Fertilizer,sale_Price,Number FROM TFertilizer WHERE Id=@Id";
            string insertquery = "INSERT INTO Record (Name,Number,Sale_Price,Sale_PriceAll) VALUES (@Name,'" + numbber + "',@Sale_Price,'" + xz + "')";
            try
            {
                SqlCommand comselect = new SqlCommand(selectquery, sc);
                comselect.Parameters.AddWithValue("@Id", prozxs);
                var resultselectquery = comselect.ExecuteReader();
                SqlCommand cominsert = new SqlCommand(insertquery, sc);


                while (resultselectquery.Read())
                {
                    cominsert.Parameters.AddWithValue("@Name", resultselectquery[1]);
                    cominsert.Parameters.AddWithValue("@Number", resultselectquery[2]);
                    cominsert.Parameters.AddWithValue("@Sale_Price", resultselectquery[3]);
                    cominsert.Parameters.AddWithValue("@Sale_PriceAll", xz);
                }
                resultselectquery.Close();
                cominsert.ExecuteNonQuery();
            }

            finally
            {
                sc.Close();
            }
        }
        private void addseed()
        {
            string numbber = textBox1.Text;
            prozxs = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlConnection sc = new SqlConnection(connacion);
            sc.Open();
            string numberre = "SELECT Sale_Price FROM TSeed WHERE Id=@Id";
            SqlCommand resultumber = new SqlCommand(numberre, sc);
            resultumber.Parameters.AddWithValue("@Id", prozxs);
            var reznum = resultumber.ExecuteReader();
            reznum.Read();
            string reed = reznum["Sale_Price"].ToString();
            int ree = Convert.ToInt32(reed);
            int y = Convert.ToInt32(textBox1.Text);
            int av = ree * y;
            string xz = av.ToString();
            reznum.Close();

            string selectquery = "SELECT Id,Name_Seed,sale_Price,Number FROM TSeed WHERE Id=@Id";
            string insertquery = "INSERT INTO Record (Name,Number,Sale_Price,Sale_PriceAll) VALUES (@Name,'" + numbber + "',@Sale_Price,'" + xz + "')";
            try
            {
                SqlCommand comselect = new SqlCommand(selectquery, sc);
                comselect.Parameters.AddWithValue("@Id", prozxs);
                var resultselectquery = comselect.ExecuteReader();
                SqlCommand cominsert = new SqlCommand(insertquery, sc);


                while (resultselectquery.Read())
                {
                    cominsert.Parameters.AddWithValue("@Name", resultselectquery[1]);
                    cominsert.Parameters.AddWithValue("@Number", resultselectquery[2]);
                    cominsert.Parameters.AddWithValue("@Sale_Price", resultselectquery[3]);
                    cominsert.Parameters.AddWithValue("@Sale_PriceAll", xz);
                }
                resultselectquery.Close();
                cominsert.ExecuteNonQuery();
            }

            finally
            {
                sc.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "گل")
                flowerlood();
            else if (comboBox1.Text == "گلدان")
                flowerpotlood();
            else if (comboBox1.Text == "کود و سم")
                fertilizerlood();
            else if (comboBox1.Text == "بذر")
                seedlood();

        }
        //برای حذف تک به تک 
        private void toobutdelete_Click(object sender, EventArgs e)
        {
          if (dataGridView2.CurrentRow != null)
            {
                faktor = (int)dataGridView2.CurrentRow.Cells[0].Value;
                SqlConnection sc = new SqlConnection(connacion);
                sc.Open();
                string deletequery = "DELETE FROM Record WHERE ID=@ID";
                try
                {
                    SqlCommand comm = new SqlCommand(deletequery,sc);
                    comm.Parameters.AddWithValue("@Id", faktor);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("کالا با موفقیت حذف شد", "عملیات موفق");

                }
                finally
                {
                    sc.Close();
                }
                endidiel();



            }
        }
        //حذف همه 
        private void toobutdeletall_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                faktor = (int)dataGridView2.CurrentRow.Cells[0].Value;
                SqlConnection sc = new SqlConnection(connacion);
                sc.Open();
                string deletequery = "DELETE FROM Record";
                try
                {
                    SqlCommand comm = new SqlCommand(deletequery, sc);
                    DialogResult dr;
                    dr = MessageBox.Show("ایا مطمعا هستید ", "اختار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        comm.ExecuteNonQuery();
                        MessageBox.Show("کالا با موفقیت حذف شد", "عملیات موفق");
                    }
                    else
                        return;

                }
                finally
                {
                    sc.Close();
                }
                endidiel();


            }
        }
        private void todutadd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)

            {
                if (comboBox1.Text == "گل")
                {
                    addflower();
                    todutadd.Enabled = true;
                }
                else if (comboBox1.Text == "گلدان")
                {
                    addflowerPot();
                    todutadd.Enabled = true;
                }
                else if (comboBox1.Text == "کود و سم")
                {
                    addfertilizer();
                    todutadd.Enabled = true;
                }
                else if (comboBox1.Text == "بذر")
                {
                    addseed();
                    todutadd.Enabled = true;
                }
            }
            recordlood();
            endidiel();



        }

        private void Sale_Load(object sender, EventArgs e)
        {
            endidiel();
        }

        private void endidiel()
        {
            recordlood();
            if (dataGridView2.CurrentRow != null)
            {
                toobutdelete.Enabled = true;
                toobutdeletall.Enabled = true;
            }
            else
            {
                toobutdelete.Enabled = false;
                toobutdeletall.Enabled = false;

            }
            buttyt();
            listt();
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
            buttyt();
        }

        private void text_numberfon_TextChanged(object sender, EventArgs e)
        {
            buttyt();
        }

        private void buttyt()
        {
            if ((text_name.Text != "" && text_numberfon.Text != "" && textizih.Text != "" && texshakhsi.Text != ""&& texadress.Text != "") && (dataGridView2.CurrentRow != null))
            {
                toosodorfok.Enabled = true;
            }
            else
            {
                toosodorfok.Enabled = false;
            }
            if (dataGridView2.CurrentRow != null)
            {
                text_name.Enabled = true;
                text_numberfon.Enabled = true;
                texadress.Enabled = true;
                texshakhsi.Enabled = true;
                textizih.Enabled = true;
                toosabtfok.Enabled = true;
            }
            else
            {
                text_name.Enabled = false;
                text_numberfon.Enabled = false;
                texadress.Enabled = false;
                texshakhsi.Enabled = false;
                textizih.Enabled = false;
                toosabtfok.Enabled = false;
                text_numberfon.Text = text_name.Text = texadress.Text = texshakhsi.Text = textizih.Text = null;
            }
        }
        //پیش فاکتور 
        private void toosabtfok_Click(object sender, EventArgs e)
        {
            Invoicedisplay inplay = new Invoicedisplay();
            inplay.Show();

        }
        // صدور فاکتور 
        
        private void toosodorfok_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(" آیا از فاکتور کردن اطمینا دارید  ","فاکتور کردن ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            { 
                Invoicing invo = new Invoicing();
                invo.labnamee.Text = text_name.Text;
                invo.labnumber.Text = text_numberfon.Text;
                invo.labnoe.Text = texshakhsi.Text;
                invo.labadress.Text = texadress.Text;

                invo.Show();
                text_name.Text = text_numberfon.Text =texadress.Text=texshakhsi.Text=textizih.Text = null;
            }


            
            
        }
       
        private void but_addmoshtari_Click(object sender, EventArgs e)
        {
            prozxs = (int)dataGridView3.CurrentRow.Cells[0].Value;
            SqlConnection sc = new SqlConnection(connacion);
            sc.Open();
            string query = "SELECT Id,Name,Number,Noe,Addres,Moshakhas FROM TMoshtari ";

            SqlCommand commm = new SqlCommand(query, sc);
            SqlDataReader reader = commm.ExecuteReader();
            reader.Read();
            string reedname = reader["Name"].ToString();
            string reednumber = reader["Number"].ToString(); 
            string  reednoe = reader["Noe"].ToString();
            string reedaddres = reader["Addres"].ToString(); 
            string reedmoshakhas = reader["Moshakhas"].ToString();

            text_name.Text = reedname;
            text_numberfon.Text = reednumber;
            texshakhsi.Text = reednoe;
            texadress.Text = reedaddres;
            textizih.Text = reedmoshakhas;


        }

        private void texshakhsi_TextChanged(object sender, EventArgs e)
        {
            buttyt();
        }

        private void textizih_TextChanged(object sender, EventArgs e)
        {
            buttyt();
        }

        private void texadress_TextChanged(object sender, EventArgs e)
        {
            buttyt();
        }

        private void listt()
        {
            try
            {
                SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Name,Number,Noe,Addres,Moshakhas FROM TMoshtari ", se);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                se.Dispose();
                dataGridView3.Columns[0].HeaderText = "شماره";
                dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView3.Columns[1].HeaderText = "نام";
                dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView3.Columns[2].HeaderText = "شماره تماس";
                dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView3.Columns[3].HeaderText = "نوع خرید";
                dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView3.Columns[4].HeaderText = "ادرس";
                dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView3.Columns[5].HeaderText = "توضیحات";
                dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                se.Close();
            }
            catch
            {
            }
        }
    }
}
