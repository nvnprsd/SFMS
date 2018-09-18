namespace Demo
{
    partial class cert_ex_chek
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.get = new System.Windows.Forms.Button();
            this.candidatenme = new System.Windows.Forms.TextBox();
            this.frstex = new System.Windows.Forms.TextBox();
            this.secex = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(-6, -16);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2350, 204);
            this.panel1.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.get);
            this.panel2.Controls.Add(this.candidatenme);
            this.panel2.Controls.Add(this.frstex);
            this.panel2.Controls.Add(this.secex);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(133, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 186);
            this.panel2.TabIndex = 148;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // get
            // 
            this.get.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.get.BackColor = System.Drawing.Color.White;
            this.get.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.get.FlatAppearance.BorderSize = 2;
            this.get.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.get.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.get.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.get.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.get.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.get.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.get.Location = new System.Drawing.Point(197, 143);
            this.get.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(107, 36);
            this.get.TabIndex = 109;
            this.get.Text = "Get Certificate";
            this.get.UseVisualStyleBackColor = false;
            this.get.Click += new System.EventHandler(this.spic_Click_1);
            // 
            // candidatenme
            // 
            this.candidatenme.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatenme.Location = new System.Drawing.Point(6, 22);
            this.candidatenme.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.candidatenme.Name = "candidatenme";
            this.candidatenme.Size = new System.Drawing.Size(290, 32);
            this.candidatenme.TabIndex = 108;
            this.candidatenme.Text = "Candidate Name";
            this.candidatenme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frstex
            // 
            this.frstex.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.frstex.Location = new System.Drawing.Point(6, 65);
            this.frstex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.frstex.Name = "frstex";
            this.frstex.Size = new System.Drawing.Size(298, 27);
            this.frstex.TabIndex = 107;
            this.frstex.Text = "Enter 1st Term Exams Marks Out of 100";
            this.frstex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frstex.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // secex
            // 
            this.secex.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.secex.Location = new System.Drawing.Point(6, 104);
            this.secex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.secex.Name = "secex";
            this.secex.Size = new System.Drawing.Size(297, 27);
            this.secex.TabIndex = 106;
            this.secex.Text = "Enter 2nd Term Exam Marks out of 100";
            this.secex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(684, -96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 32);
            this.textBox1.TabIndex = 105;
            this.textBox1.Text = "Candidate ID";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(561, 32);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(282, 33);
            this.label24.TabIndex = 143;
            this.label24.Text = "Your Insititute Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(704, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 114);
            this.label1.TabIndex = 147;
            this.label1.Text = "Certificate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 27);
            this.label2.TabIndex = 148;
            this.label2.Text = "This Certificate Is Award To Mr. /Miss. /Mrs. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 149;
            this.label3.Text = "payao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1067, 456);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 150;
            this.label4.Text = "label4";
            // 
            // cert_ex_chek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1362, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "cert_ex_chek";
            this.Text = "cert_ex_chek";
            this.Load += new System.EventHandler(this.cert_ex_chek_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.TextBox candidatenme;
        private System.Windows.Forms.TextBox frstex;
        private System.Windows.Forms.TextBox secex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}