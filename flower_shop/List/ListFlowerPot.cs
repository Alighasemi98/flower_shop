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
    public partial class ListFlowerPot : Form
    {
        public ListFlowerPot()
        {
            InitializeComponent();
        }
        private void AddImageToImageList(ImageList iml, Bitmap bm, string key, float wid, float hgt)   // افزودن ستون نمایش تصویر
        {
            Bitmap iml_bm = new Bitmap(iml.ImageSize.Width, iml.ImageSize.Height);
            using (Graphics gr = Graphics.FromImage(iml_bm))
            {
                gr.Clear(Color.Transparent);
                gr.InterpolationMode = InterpolationMode.High;
                RectangleF source_rect = new RectangleF(0, 0, bm.Width, bm.Height);
                RectangleF dest_rect = new RectangleF(0, 0, iml_bm.Width, iml_bm.Height);
                dest_rect = ScaleRect(source_rect, dest_rect);
                gr.DrawImage(bm, dest_rect, source_rect, GraphicsUnit.Pixel);
            }
            iml.Images.Add(key, iml_bm);
        }
        private Bitmap BytesToImage(byte[] bytes)                // خواندن تصاویر در آرایه
        {
            using (MemoryStream image_stream = new MemoryStream(bytes))
            {
                Bitmap bm = new Bitmap(image_stream);
                image_stream.Close();
                return bm;
            }
        }
        private RectangleF ScaleRect(RectangleF source_rect, RectangleF dest_rect)
        {
            float source_aspect = source_rect.Width / source_rect.Height;
            float wid = dest_rect.Width;
            float hgt = dest_rect.Height;
            float dest_aspect = wid / hgt;
            if (source_aspect > dest_aspect)
            {
                hgt = wid / source_aspect;
            }
            else
            {
                wid = hgt * source_aspect;
            }
            float x = dest_rect.Left + (dest_rect.Width - wid) / 2;
            float y = dest_rect.Top + (dest_rect.Height - hgt) / 2;
            return new RectangleF(x, y, wid, hgt);
        }
        public void Listshow()  /// خواندن اطلاعات از بانک
        {
            try
            {
                comboBox1.SelectedIndex = 0;
                listView1.SmallImageList = imlSmallIcons;
                listView1.LargeImageList = imlLargeIcons;
                listView1.MakeColumnHeaders("تصویر/شماره کود", 200, HorizontalAlignment.Left, "نام", 60, HorizontalAlignment.Left,
                "قیمت خرید", 150, HorizontalAlignment.Left, "قیمت فروش", 100, HorizontalAlignment.Left,
                "تعداد", 100, HorizontalAlignment.Left, "توضیح", 210, HorizontalAlignment.Left, "تاریخ", 120, HorizontalAlignment.Left);
                SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                se.Open();
                string query = "SELECT (*) FROM TFlowerPot ORDER BY Id";
                SqlCommand comm = new SqlCommand(query, se);
                SqlDataReader reader = comm.ExecuteReader();
                listView1.Items.Clear();
                imlLargeIcons.Images.Clear();
                imlSmallIcons.Images.Clear();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(8))
                    {
                        Bitmap bm = BytesToImage((byte[])reader.GetValue(7));
                        float source_aspect = bm.Width / (float)bm.Height;
                        AddImageToImageList(imlLargeIcons, bm, reader[0].ToString(), imlLargeIcons.ImageSize.Width, imlLargeIcons.ImageSize.Height);
                        AddImageToImageList(imlSmallIcons, bm, reader[0].ToString(), imlLargeIcons.ImageSize.Width, imlLargeIcons.ImageSize.Height);
                    }

                    listView1.AddRow(reader[0].ToString(),
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString(),
                        reader[5].ToString(),
                        reader[6].ToString(),
                        reader[7].ToString());
                }
                reader.Close();
                se.Close();
            }
            catch
            {
            }
        }

        void adad()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM TFlowerPot"); // تعداد سطرهای موجود در جدول
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
                SqlCommand com = new SqlCommand("SELECT SUM(Number) FROM TFlowerPot"); // تعداد سطرهای موجود در جدول
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
        private void ListFlowerPot_Load(object sender, EventArgs e)
        {
            Listshow();
            adad();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "معرفی مختصر کالا":
                    listView1.View = View.Tile;
                    break;
                case "اطلاعات کامل کالا":
                    listView1.View = View.Details;
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
