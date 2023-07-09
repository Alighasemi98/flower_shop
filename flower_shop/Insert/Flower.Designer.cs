namespace flower_shop.Insert
{
    partial class Flower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flower));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tex_buy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_number = new System.Windows.Forms.TextBox();
            this.tex_sell = new System.Windows.Forms.TextBox();
            this.tex_descripion = new System.Windows.Forms.TextBox();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.but_addflower = new System.Windows.Forms.Button();
            this.but_addpicture = new System.Windows.Forms.Button();
            this.but_adddflower = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_buy = new System.Windows.Forms.TextBox();
            this.text_sale = new System.Windows.Forms.TextBox();
            this.text_number = new System.Windows.Forms.TextBox();
            this.comflower = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.databaseFlowershopDataSet = new flower_shop.DatabaseFlowershopDataSet();
            this.tflowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tflowerTableAdapter = new flower_shop.DatabaseFlowershopDataSetTableAdapters.TflowerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFlowershopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tflowerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tex_buy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tex_number);
            this.groupBox1.Controls.Add(this.tex_sell);
            this.groupBox1.Controls.Add(this.tex_descripion);
            this.groupBox1.Controls.Add(this.tex_name);
            this.groupBox1.Controls.Add(this.but_addflower);
            this.groupBox1.Controls.Add(this.but_addpicture);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(573, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن گل به فروشگاه";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(108, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر گل";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "توضیح :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "قیمت فروش :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "قیمت خرید :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "نام گل :";
            // 
            // tex_buy
            // 
            this.tex_buy.Location = new System.Drawing.Point(369, 46);
            this.tex_buy.Name = "tex_buy";
            this.tex_buy.Size = new System.Drawing.Size(132, 20);
            this.tex_buy.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "تعداد :";
            // 
            // tex_number
            // 
            this.tex_number.Location = new System.Drawing.Point(150, 72);
            this.tex_number.Name = "tex_number";
            this.tex_number.Size = new System.Drawing.Size(132, 20);
            this.tex_number.TabIndex = 13;
            // 
            // tex_sell
            // 
            this.tex_sell.Location = new System.Drawing.Point(150, 46);
            this.tex_sell.Name = "tex_sell";
            this.tex_sell.Size = new System.Drawing.Size(132, 20);
            this.tex_sell.TabIndex = 13;
            // 
            // tex_descripion
            // 
            this.tex_descripion.Location = new System.Drawing.Point(150, 20);
            this.tex_descripion.Name = "tex_descripion";
            this.tex_descripion.Size = new System.Drawing.Size(132, 20);
            this.tex_descripion.TabIndex = 12;
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(369, 20);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(132, 20);
            this.tex_name.TabIndex = 10;
            // 
            // but_addflower
            // 
            this.but_addflower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but_addflower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_addflower.Location = new System.Drawing.Point(408, 99);
            this.but_addflower.Name = "but_addflower";
            this.but_addflower.Size = new System.Drawing.Size(93, 23);
            this.but_addflower.TabIndex = 8;
            this.but_addflower.Text = "افزودن گل";
            this.but_addflower.UseVisualStyleBackColor = true;
            this.but_addflower.Click += new System.EventHandler(this.but_addflower_Click);
            // 
            // but_addpicture
            // 
            this.but_addpicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_addpicture.Location = new System.Drawing.Point(21, 112);
            this.but_addpicture.Name = "but_addpicture";
            this.but_addpicture.Size = new System.Drawing.Size(100, 23);
            this.but_addpicture.TabIndex = 9;
            this.but_addpicture.Text = "انتخاب عکس";
            this.but_addpicture.UseVisualStyleBackColor = true;
            this.but_addpicture.Click += new System.EventHandler(this.but_addpicture_Click);
            // 
            // but_adddflower
            // 
            this.but_adddflower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but_adddflower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_adddflower.Location = new System.Drawing.Point(7, 126);
            this.but_adddflower.Name = "but_adddflower";
            this.but_adddflower.Size = new System.Drawing.Size(121, 23);
            this.but_adddflower.TabIndex = 8;
            this.but_adddflower.Text = "افزایش گل";
            this.but_adddflower.UseVisualStyleBackColor = true;
            this.but_adddflower.Click += new System.EventHandler(this.but_adddflower_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(0, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(779, 216);
            this.dataGridView1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(782, 235);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فهرست گل های موجود";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "تعداد گل های ثبت شده :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.text_buy);
            this.groupBox4.Controls.Add(this.text_sale);
            this.groupBox4.Controls.Add(this.text_number);
            this.groupBox4.Controls.Add(this.comflower);
            this.groupBox4.Controls.Add(this.but_adddflower);
            this.groupBox4.Location = new System.Drawing.Point(591, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(203, 151);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "افزایش گل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "انتخاب گل :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "قیمت خرید :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "قیمت فروش :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "تعداد :";
            // 
            // text_buy
            // 
            this.text_buy.Enabled = false;
            this.text_buy.Location = new System.Drawing.Point(7, 42);
            this.text_buy.Name = "text_buy";
            this.text_buy.Size = new System.Drawing.Size(121, 20);
            this.text_buy.TabIndex = 4;
            // 
            // text_sale
            // 
            this.text_sale.Enabled = false;
            this.text_sale.Location = new System.Drawing.Point(7, 71);
            this.text_sale.Name = "text_sale";
            this.text_sale.Size = new System.Drawing.Size(121, 20);
            this.text_sale.TabIndex = 3;
            // 
            // text_number
            // 
            this.text_number.Enabled = false;
            this.text_number.Location = new System.Drawing.Point(7, 100);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(121, 20);
            this.text_number.TabIndex = 2;
            // 
            // comflower
            // 
            this.comflower.FormattingEnabled = true;
            this.comflower.Location = new System.Drawing.Point(7, 11);
            this.comflower.Name = "comflower";
            this.comflower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comflower.Size = new System.Drawing.Size(121, 21);
            this.comflower.TabIndex = 0;
            this.comflower.SelectedIndexChanged += new System.EventHandler(this.comflower_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // databaseFlowershopDataSet
            // 
            this.databaseFlowershopDataSet.DataSetName = "DatabaseFlowershopDataSet";
            this.databaseFlowershopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tflowerBindingSource
            // 
            this.tflowerBindingSource.DataMember = "Tflower";
            this.tflowerBindingSource.DataSource = this.databaseFlowershopDataSet;
            // 
            // tflowerTableAdapter
            // 
            this.tflowerTableAdapter.ClearBeforeFill = true;
            // 
            // Flower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 434);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Flower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن گل";
            this.Load += new System.EventHandler(this.Flower_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFlowershopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tflowerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_addflower;
        private System.Windows.Forms.Button but_addpicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tex_buy;
        private System.Windows.Forms.TextBox tex_sell;
        private System.Windows.Forms.TextBox tex_descripion;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button but_adddflower;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comflower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_buy;
        private System.Windows.Forms.TextBox text_sale;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tex_number;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DatabaseFlowershopDataSet databaseFlowershopDataSet;
        private System.Windows.Forms.BindingSource tflowerBindingSource;
        private DatabaseFlowershopDataSetTableAdapters.TflowerTableAdapter tflowerTableAdapter;
    }
}