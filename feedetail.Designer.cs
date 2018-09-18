namespace Demo
{
    partial class feedetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedetail));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errgmob = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.errid = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.id = new System.Windows.Forms.TextBox();
            this.getdetail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.theme2 = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View All Students Fee Details",
            "View Indivisual fee Detail"});
            this.comboBox1.Location = new System.Drawing.Point(14, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select Students Type";
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // errgmob
            // 
            this.errgmob.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.errgmob.BorderWidth = 2;
            this.errgmob.Location = new System.Drawing.Point(13, 55);
            this.errgmob.Name = "errgmob";
            this.errgmob.Size = new System.Drawing.Size(167, 29);
            // 
            // errid
            // 
            this.errid.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.errid.BorderWidth = 2;
            this.errid.Location = new System.Drawing.Point(13, 88);
            this.errid.Name = "errid";
            this.errid.Size = new System.Drawing.Size(167, 29);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.id.Location = new System.Drawing.Point(13, 89);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(166, 27);
            this.id.TabIndex = 2;
            this.id.Text = "Candidate ID ";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getdetail
            // 
            this.getdetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getdetail.BackColor = System.Drawing.Color.Transparent;
            this.getdetail.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.getdetail.FlatAppearance.BorderSize = 2;
            this.getdetail.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.getdetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.getdetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.getdetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getdetail.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.getdetail.ForeColor = System.Drawing.Color.White;
            this.getdetail.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.getdetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.getdetail.Location = new System.Drawing.Point(194, 86);
            this.getdetail.Name = "getdetail";
            this.getdetail.Size = new System.Drawing.Size(151, 33);
            this.getdetail.TabIndex = 58;
            this.getdetail.Text = "Get Details";
            this.getdetail.UseVisualStyleBackColor = false;
            this.getdetail.Click += new System.EventHandler(this.getdetail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 598);
            this.dataGridView1.TabIndex = 59;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1116, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 31);
            this.close.TabIndex = 60;
            this.close.Text = " X ";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Cambria", 15.25F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(3, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 25);
            this.back.TabIndex = 73;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.getdetail);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.theme2);
            this.panel1.Controls.Add(this.theme);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 126);
            this.panel1.TabIndex = 74;
            // 
            // theme2
            // 
            this.theme2.AutoSize = true;
            this.theme2.BackColor = System.Drawing.Color.Transparent;
            this.theme2.Font = new System.Drawing.Font("Cambria", 26.25F);
            this.theme2.ForeColor = System.Drawing.Color.White;
            this.theme2.Location = new System.Drawing.Point(521, 57);
            this.theme2.Name = "theme2";
            this.theme2.Size = new System.Drawing.Size(182, 41);
            this.theme2.TabIndex = 76;
            this.theme2.Text = "Fee Details";
            // 
            // theme
            // 
            this.theme.AutoSize = true;
            this.theme.BackColor = System.Drawing.Color.Transparent;
            this.theme.Font = new System.Drawing.Font("Cambria", 38.25F);
            this.theme.ForeColor = System.Drawing.Color.White;
            this.theme.Location = new System.Drawing.Point(341, 1);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(474, 59);
            this.theme.TabIndex = 75;
            this.theme.Text = "Your Insititute Name";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.errid,
            this.errgmob});
            this.shapeContainer2.Size = new System.Drawing.Size(1164, 126);
            this.shapeContainer2.TabIndex = 77;
            this.shapeContainer2.TabStop = false;
            // 
            // feedetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "feedetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "feedetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape errgmob;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape errid;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button getdetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label theme;
        private System.Windows.Forms.Label theme2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}