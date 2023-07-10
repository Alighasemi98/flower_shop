namespace flower_shop.Insert
{
    partial class pardakht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pardakht));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.texprise = new System.Windows.Forms.TextBox();
            this.texghaemat = new System.Windows.Forms.TextBox();
            this.texnumber = new System.Windows.Forms.TextBox();
            this.textakh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "نقد ",
            "کارت خوان",
            "قسطی",
            "کارت به کارت "});
            this.comboBox1.Location = new System.Drawing.Point(18, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // texprise
            // 
            this.texprise.Location = new System.Drawing.Point(18, 137);
            this.texprise.Name = "texprise";
            this.texprise.Size = new System.Drawing.Size(149, 20);
            this.texprise.TabIndex = 1;
            // 
            // texghaemat
            // 
            this.texghaemat.Enabled = false;
            this.texghaemat.Location = new System.Drawing.Point(18, 71);
            this.texghaemat.Name = "texghaemat";
            this.texghaemat.Size = new System.Drawing.Size(149, 20);
            this.texghaemat.TabIndex = 2;
            // 
            // texnumber
            // 
            this.texnumber.Enabled = false;
            this.texnumber.Location = new System.Drawing.Point(18, 45);
            this.texnumber.Name = "texnumber";
            this.texnumber.Size = new System.Drawing.Size(149, 20);
            this.texnumber.TabIndex = 3;
            // 
            // textakh
            // 
            this.textakh.Location = new System.Drawing.Point(18, 97);
            this.textakh.Name = "textakh";
            this.textakh.Size = new System.Drawing.Size(149, 20);
            this.textakh.TabIndex = 4;
            this.textakh.Text = "0";
            this.textakh.TextChanged += new System.EventHandler(this.textakh_TextChanged);
            this.textakh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textakh_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butpar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textakh);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.texnumber);
            this.groupBox1.Controls.Add(this.texprise);
            this.groupBox1.Controls.Add(this.texghaemat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(287, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پرداخت";
            // 
            // butpar
            // 
            this.butpar.BackColor = System.Drawing.SystemColors.Window;
            this.butpar.ForeColor = System.Drawing.Color.LimeGreen;
            this.butpar.Location = new System.Drawing.Point(18, 163);
            this.butpar.Name = "butpar";
            this.butpar.Size = new System.Drawing.Size(149, 23);
            this.butpar.TabIndex = 10;
            this.butpar.Text = "پرداخت ";
            this.butpar.UseVisualStyleBackColor = false;
            this.butpar.Click += new System.EventHandler(this.butpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "مبلغ قابل پرداخت :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تخفیف :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "تعداد :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "قیمت کل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "نوع پرداخت :";
            // 
            // pardakht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pardakht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پرداخت";
            this.Load += new System.EventHandler(this.pardakht_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox texprise;
        public System.Windows.Forms.TextBox texghaemat;
        public System.Windows.Forms.TextBox texnumber;
        private System.Windows.Forms.TextBox textakh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}