using flower_shop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop.List
{
    public partial class ListSeed : Form
    {
        public ListSeed()
        {
            InitializeComponent();
        }
      
        //برای نمایش تعداد
        void adad()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM TSeed"); // تعداد سطرهای موجود در جدول
                com.Connection = con;
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    int count = Int32.Parse(dr[0].ToString());
                    libnum.Text = count.ToString() + " قلم ";
                    con.Close();
                }
                else
                {
                }
            }
            catch
            {
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlCommand com = new SqlCommand("SELECT SUM(Number) FROM TSeed"); // تعداد سطرهای موجود در جدول
                com.Connection = con;
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    int count = Int32.Parse(dr[0].ToString());
                    libnumall.Text = count.ToString() + " عدد ";
                    con.Close();
                }
                else
                {
                }
            }
            catch
            {
            }
        }


        private void ListSeed_Load(object sender, EventArgs e)
        {
            adad();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "معرفی مختصر کالا":
                
                    break;
                case "اطلاعات کامل کالا":
                   
                    break;
            }
        }
    }
}
