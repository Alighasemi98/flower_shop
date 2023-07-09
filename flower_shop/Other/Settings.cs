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

namespace flower_shop.Other
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textusername.Text))
                    errorProvider1.SetError(textusername, "لطفا نام کاربری را وارد کیند");
                if (string.IsNullOrWhiteSpace(textnationalcod.Text))
                    errorProvider1.SetError(textnationalcod, "لطفا کدملی را وارد کیند");
                if (string.IsNullOrWhiteSpace(textpassword.Text))
                    errorProvider1.SetError(textpassword, "لطفا رمز عبور را وارد کیند");
                if (string.IsNullOrWhiteSpace(textpasswordagan.Text))
                    errorProvider1.SetError(textpasswordagan, "لطفارمز عبور را وارد کیند");
                else
                {
                    string user = textusername.Text;
                    string pass = textpassword.Text;
                    string nacod = textnationalcod.Text; 
                    SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                    se.Open();
                    string query = "DELETE FROM User1";
                    SqlCommand com = new SqlCommand(query, se);
                    com.ExecuteNonQuery();


                    string querry = "INSERT INTO User1(User_Name,Password,National_Code) VALUES ('"+ user +"','"+ pass +"','"+ nacod +"')";
                    SqlCommand comm = new SqlCommand(querry,se);
                    comm.ExecuteNonQuery();
                    se.Close();

                    MessageBox.Show("رمز با موفقیت تغییر یافت", "عملیات موفق ");

                }

            }
            catch
            {
             
            }
        }
    }
}
