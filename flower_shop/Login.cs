using flower_shop.Other;
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

namespace flower_shop
{
    public partial class Login : Form
    {
        Welcome wel = new Welcome();
        Main ma = new Main();
        public Login()
        {
            InitializeComponent();
        }



        private void tex_username_Enter(object sender, EventArgs e)
        {
            if (tex_username.Text == "نام کاربری")
            {
                tex_username.Text = "";
                tex_username.ForeColor = Color.Black;
            }
        }

        private void tex_username_Leave(object sender, EventArgs e)
        {
            if (tex_username.Text == "")
            {
                tex_username.Text = "نام کاربری";
                tex_username.ForeColor = Color.Gray;
            }
        }

        private void tex_password_Leave(object sender, EventArgs e)
        {
            if (tex_password.Text == "")
            {
                tex_password.Text = "رمز عبور";
                tex_password.ForeColor = Color.Gray;
                checkBox2.Checked = false;
                tex_password.UseSystemPasswordChar = false;
            }
        }

        private void tex_password_Enter(object sender, EventArgs e)
        {
            if (tex_password.Text == "رمز عبور")
            {
                tex_password.Text = "";
                tex_password.ForeColor = Color.Black;
                tex_password.UseSystemPasswordChar = true;
            }

        }

        private void tex_password_TextChanged(object sender, EventArgs e)
        {
            if (tex_password.Text == "رمز عبور")
            {
                tex_password.UseSystemPasswordChar = false;
            }
            else
            {
                tex_password.UseSystemPasswordChar = true;
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                tex_password.UseSystemPasswordChar = false;
            }
            else
            {
                tex_password.UseSystemPasswordChar = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string us = tex_username.Text;
                string pa = tex_password.Text;

                SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                se.Open();
                string query = "SELECT Password FROM User1 WHERE User_Name='" + us + "'";
                SqlCommand coom = new SqlCommand(query,se);
                SqlDataReader reed = coom.ExecuteReader();
                reed.Read();
                string pass = reed["Password"].ToString();

                if (pa == pass)
                {
                    wel.Show();
                    this.Hide();  
                }
                else
                {
                    MessageBox.Show("رمز کاربری یا کلمه عبور اشتباه است", "اخطار");
                }
                se.Close();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
              
           /* if (tex_username.Text == "admin1" && tex_password.Text == "admin2")
            {
                ma.Show();
                this.Hide();
            }*/
        }
    }
}
