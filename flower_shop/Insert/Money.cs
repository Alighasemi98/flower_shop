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
//using Microsoft.Office.Interop.Excel; // مورد نیاز خروجی اکسل  // ارور میده
using System.Drawing.Printing; // مورد نیاز پرینت




namespace flower_shop.Insert
{
    public partial class Money : Form
    {
     
        public Money()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public void DGV()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlCommand com = new SqlCommand();
                SqlDataReader oldr;
                System.Data.DataTable Table = new System.Data.DataTable();
                con.Open();
               
                com.Connection = con;
                com.CommandText = "SELECT * FROM TMojodi";
                oldr = com.ExecuteReader();
                Table.Load(oldr);
                
                dataGridView1.DataSource = Table;
                dataGridView1.Columns[0].HeaderText = "شماره";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].HeaderText = "موجودی";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ست کردن اندازه عرض ستون نسبت به بزرگترین متن موجود در ستون
                dataGridView1.Columns[2].HeaderText = "برداشت";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].HeaderText = "واریز";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].HeaderText = "تاریخ";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].HeaderText = "توضیحات";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D6DBE9");
                this.dataGridView1.Columns[1].DefaultCellStyle.Format = "c0";
                this.dataGridView1.Columns[2].DefaultCellStyle.Format = "c0";
                this.dataGridView1.Columns[3].DefaultCellStyle.Format = "c0";
                con.Close();
            }
            catch
            {

            }
            
            finally
            {
               
            }
            
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
        //مبلق اولیه 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tex_numberFR.Text)) errorProvider1.SetError(tex_numberFR, "لطفا شماره را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_mablaghFR.Text)) errorProvider1.SetError(tex_mablaghFR, "لطفا مبلغ را وارد کیند");
                if (string.IsNullOrWhiteSpace(dateTimePicker3.Text)) errorProvider1.SetError(dateTimePicker3, "لطفا تاریخ را انتخاب کیند");
                else
                {
                    try
                    {
                        com.Connection = sc;
                        com.CommandText = "INSERT INTO Tmojodi (Id, Mojodi, Bardasht, Variz, Dat, Explanation) VALUES (@i, @m, @b, @v, @d, @e)";
                        com.Parameters.AddWithValue("@i", tex_numberFR.Text);
                        com.Parameters.AddWithValue("@m", tex_mablaghFR.Text);
                        com.Parameters.AddWithValue("@b", 0);
                        com.Parameters.AddWithValue("@v", 0);
                        com.Parameters.AddWithValue("@d", dateTimePicker3.Value);
                        com.Parameters.AddWithValue("@e", tex_ExplanationFR.Text);
                        try
                        {
                            sc.Open();
                            int result = com.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("مقدار اولیه صندوق به مبلغ  (" + tex_mablaghFR.Text + ") ثبت شد", "ثبت شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                ClearTxt(this);
                                DGV();
                            }
                            else
                                MessageBox.Show("عملیات انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        catch
                        {
                        }

                        finally
                        {
                            sc.Close();
                            sc.Dispose();
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    groupBox1.Enabled = true;
                else
                    groupBox1.Enabled = false;
            }
            catch
            {
            }
            ClearTxt(this);
        }
        //واریز
        private void button3_Click(object sender, EventArgs e)
        {
            double a = 0;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT TOP 1 Mojodi FROM TMojodi ORDER BY Id DESC";
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    a = double.Parse(dr[0].ToString());
                }
                con.Close();
            }
            catch
            {
            }
            finally
            {
                
            }
            try
            {
                if (string.IsNullOrWhiteSpace(tex_numberVa.Text)) errorProvider1.SetError(tex_numberVa, "لطفا شماره را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_mablaghVa.Text)) errorProvider1.SetError(tex_mablaghVa, "لطفا مبلغ واریزی را وارد کیند");
                if (string.IsNullOrWhiteSpace(dateTimePicker2.Text)) errorProvider1.SetError(dateTimePicker2, "لطفا تاریخ را انتخاب کیند");
                else
                {
                    SqlConnection con1;
                    SqlDataAdapter adapter;
                    string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True";
                    System.Data.DataTable dy = new System.Data.DataTable();
                    con1 = new SqlConnection(conString);
                    string chek = "select Id from TMojodi where Id='" + tex_numberVa.Text + "'";
                    adapter = new SqlDataAdapter(chek, con1);                                  /// تکراری نبودن شماره قبل از درج
                    dy.Clear();
                    adapter.Fill(dy);
                    if (dy.Rows.Count > 0)
                    {
                        MessageBox.Show("شماره قبلا ثبت شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\source\\repos\\flower_shop\\flower_shop\\DatabaseFlowershop.mdf;Integrated Security=True");
                            SqlCommand com2 = new SqlCommand();
                            com2.Connection = con2;
                            com2.CommandText = "INSERT INTO TMojodi (Id, Mojodi, Bardasht, Variz, Dat, Explanation) VALUES (@i, @m, @b, @v, @d, @e)";
                            com2.Parameters.AddWithValue("@i", tex_numberVa.Text);
                            com2.Parameters.AddWithValue("@m", a = a + double.Parse(tex_mablaghVa.Text));
                            com2.Parameters.AddWithValue("@b", 0);
                            com2.Parameters.AddWithValue("@v", tex_mablaghVa.Text);
                            com2.Parameters.AddWithValue("@d", dateTimePicker2.Value);
                            com2.Parameters.AddWithValue("@e", tex_ExplanationVa.Text);
                            try
                            {
                                con2.Open();
                                int result = com2.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("واریز مبلغ  (" + tex_mablaghVa.Text + ") به صندوق ثبت شد", "ثبت شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ClearTxt(this);
                                    DGV();
                                }
                                else
                                    MessageBox.Show("عملیات انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch
                            {
                            }
                            finally
                            {
                                con2.Close();
                                con2.Dispose();
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //برداشت 
        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AnbarDB;Integrated Security=True");
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT TOP 1 Mojodi FROM TMojodi ORDER BY Id DESC";
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    a = double.Parse(dr[0].ToString());
                }
                con.Close();
            }
            catch
            {
            }
            finally
            {
                
            }
            try
            {
                if (string.IsNullOrWhiteSpace(tex_numberBr.Text)) errorProvider1.SetError(tex_numberBr, "لطفا شماره را وارد کیند");
                if (string.IsNullOrWhiteSpace(tex_mablaghBr.Text)) errorProvider1.SetError(tex_mablaghBr, "لطفا مبلغ برداشتی را وارد کیند");
                if (string.IsNullOrWhiteSpace(dateTimePicker1.Text)) errorProvider1.SetError(dateTimePicker1, "لطفا تاریخ را انتخاب کیند");
                else
                {
                    SqlConnection con1;
                    SqlDataAdapter adapter;
                    string conString = "Data Source=.;Initial Catalog=AnbarDB;Integrated Security=True";
                    System.Data.DataTable dy = new System.Data.DataTable();
                    con1 = new SqlConnection(conString);
                    string chek = "select Id from TMojodi where Id='" + tex_numberBr.Text + "'";
                    adapter = new SqlDataAdapter(chek, con1);                                  /// تکراری نبودن شماره قبل از درج
                    dy.Clear();
                    adapter.Fill(dy);
                    if (dy.Rows.Count > 0)
                    {
                        MessageBox.Show("شماره قبلا ثبت شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AnbarDB;Integrated Security=True");
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;
                            com.CommandText = "INSERT INTO TMojodi (Id, Mojodi, Bardasht, Variz, Dat, Toz) VALUES (@i, @m, @b, @v, @d, @t)";
                            com.Parameters.AddWithValue("@i", tex_numberBr.Text);
                            com.Parameters.AddWithValue("@m", a = a - double.Parse(tex_mablaghBr.Text));
                            com.Parameters.AddWithValue("@b", tex_mablaghBr.Text);
                            com.Parameters.AddWithValue("@v", 0);
                            com.Parameters.AddWithValue("@d", dateTimePicker1.Value);
                            com.Parameters.AddWithValue("@t", tex_ExplanationBr.Text);
                            try
                            {
                                con.Open();
                                int result = com.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("برداشت مبلغ  (" + tex_mablaghBr.Text + ") از صندوق ثبت شد", "ثبت شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ClearTxt(this);
                                    DGV();
                                }
                                else
                                    MessageBox.Show("عملیات انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch
                            {
                            }
                            finally
                            {
                                con.Close();
                                con.Dispose();
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* try
            {
                object mis = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = false;
                worksheet = (Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Worksheet)workbook.ActiveSheet;
                worksheet.Name = "تراکنش صندوق";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Document(*.xlsx)|*.xlsx";
                sfd.FileName = "فهرست تراکنش های صندوق";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
            catch
            {
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.Cursor = Cursors.WaitCursor;
                flower_shop.DGVPrinter printer = new flower_shop.DGVPrinter();
                printer.CellAlignment = StringAlignment.Center;
                printer.CellFormatFlags = StringFormatFlags.DirectionRightToLeft;
                flower_shop.imageadress adress = new flower_shop.imageadress();
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.HeaderCellFormatFlags = StringFormatFlags.DirectionRightToLeft;
                printer.PageNumberAlignment = StringAlignment.Near;
                printer.PageNumbers = false;
                printer.PorportionalColumns = true;
                flower_shop.imageadress.adress = @"\";
                flower_shop.imageadress.ImageWidth = 90;
                flower_shop.imageadress.ImageHeight = 90;
                if (flower_shop.imageadress.adress == @"\")
                {
                    printer.PrintMargins = new Margins(60, 60, 40, 40);
                }
                printer.Title = "فهرست تراکنش صندوق";
                printer.TitleAlignment = StringAlignment.Center;
                printer.TitleColor = Color.SlateGray;
                printer.TitleFont = new System.Drawing.Font("Tahoma", 16);
                printer.TitleFormatFlags = StringFormatFlags.DirectionRightToLeft;
                printer.PrintPreviewDataGridView(dataGridView1);
                this.Cursor = Cursors.Default;
            }
            catch
            {
            }*/
        }
    }
}
