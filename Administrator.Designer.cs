namespace Demo
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.adminhello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Addnew = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.vewfee = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.GenCert = new System.Windows.Forms.Button();
            this.feesubmit = new System.Windows.Forms.Button();
            this.studentlist = new System.Windows.Forms.Button();
            this.editstd = new System.Windows.Forms.Button();
            this.Selecttime = new System.Windows.Forms.ComboBox();
            this.datatable1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Controls.Add(this.adminhello);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 224);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1057, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = " X ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(9, 8);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(52, 19);
            this.home.TabIndex = 4;
            this.home.Text = "HOME";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.Font = new System.Drawing.Font("Cambria", 25.75F);
            this.Admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin.Location = new System.Drawing.Point(645, 87);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(293, 41);
            this.Admin.TabIndex = 3;
            this.Admin.Text = " Mr. Administrator";
            // 
            // adminhello
            // 
            this.adminhello.AutoSize = true;
            this.adminhello.BackColor = System.Drawing.Color.Transparent;
            this.adminhello.Font = new System.Drawing.Font("Cambria", 25.75F);
            this.adminhello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminhello.Location = new System.Drawing.Point(168, 87);
            this.adminhello.Name = "adminhello";
            this.adminhello.Size = new System.Drawing.Size(124, 41);
            this.adminhello.TabIndex = 2;
            this.adminhello.Text = "Hello ! ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Addnew
            // 
            this.Addnew.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Addnew.FlatAppearance.BorderSize = 2;
            this.Addnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Addnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.Addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addnew.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.Addnew.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Addnew.Location = new System.Drawing.Point(219, 231);
            this.Addnew.Name = "Addnew";
            this.Addnew.Size = new System.Drawing.Size(214, 38);
            this.Addnew.TabIndex = 3;
            this.Addnew.Text = "Student Registration";
            this.Addnew.UseVisualStyleBackColor = true;
            this.Addnew.Click += new System.EventHandler(this.Addnew_Click);
            // 
            // remove
            // 
            this.remove.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.remove.FlatAppearance.BorderSize = 2;
            this.remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.remove.Location = new System.Drawing.Point(450, 275);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(184, 37);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remove Student";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // vewfee
            // 
            this.vewfee.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.vewfee.FlatAppearance.BorderSize = 2;
            this.vewfee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.vewfee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.vewfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vewfee.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vewfee.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.vewfee.Location = new System.Drawing.Point(668, 275);
            this.vewfee.Name = "vewfee";
            this.vewfee.Size = new System.Drawing.Size(190, 37);
            this.vewfee.TabIndex = 5;
            this.vewfee.Text = "View Fee details ";
            this.vewfee.UseVisualStyleBackColor = true;
            this.vewfee.Click += new System.EventHandler(this.vewfee_Click);
            // 
            // viewall
            // 
            this.viewall.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.viewall.FlatAppearance.BorderSize = 2;
            this.viewall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.viewall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewall.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewall.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.viewall.Location = new System.Drawing.Point(219, 275);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(214, 37);
            this.viewall.TabIndex = 6;
            this.viewall.Text = "View All Students";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1036, 772);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Location = new System.Drawing.Point(14, 237);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(185, 34);
            // 
            // GenCert
            // 
            this.GenCert.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.GenCert.FlatAppearance.BorderSize = 2;
            this.GenCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenCert.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.GenCert.Location = new System.Drawing.Point(880, 231);
            this.GenCert.Name = "GenCert";
            this.GenCert.Size = new System.Drawing.Size(192, 81);
            this.GenCert.TabIndex = 11;
            this.GenCert.Text = "Genrate Certificate";
            this.GenCert.UseVisualStyleBackColor = true;
            this.GenCert.Click += new System.EventHandler(this.GenCert_Click);
            // 
            // feesubmit
            // 
            this.feesubmit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.feesubmit.FlatAppearance.BorderSize = 2;
            this.feesubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesubmit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesubmit.Location = new System.Drawing.Point(668, 231);
            this.feesubmit.Name = "feesubmit";
            this.feesubmit.Size = new System.Drawing.Size(192, 38);
            this.feesubmit.TabIndex = 12;
            this.feesubmit.Text = "Submit Student Fee";
            this.feesubmit.UseVisualStyleBackColor = true;
            this.feesubmit.Click += new System.EventHandler(this.feesubmit_Click);
            // 
            // studentlist
            // 
            this.studentlist.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.studentlist.FlatAppearance.BorderSize = 2;
            this.studentlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.studentlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.studentlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentlist.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlist.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.studentlist.Location = new System.Drawing.Point(14, 275);
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(186, 37);
            this.studentlist.TabIndex = 1;
            this.studentlist.Text = " Student List";
            this.studentlist.UseVisualStyleBackColor = true;
            this.studentlist.Click += new System.EventHandler(this.studentlist_Click);
            // 
            // editstd
            // 
            this.editstd.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.editstd.FlatAppearance.BorderSize = 2;
            this.editstd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.editstd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.editstd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstd.Font = new System.Drawing.Font("Cambria", 13.75F);
            this.editstd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.editstd.Location = new System.Drawing.Point(450, 231);
            this.editstd.Name = "editstd";
            this.editstd.Size = new System.Drawing.Size(184, 38);
            this.editstd.TabIndex = 13;
            this.editstd.Text = "Edit Student Details";
            this.editstd.UseVisualStyleBackColor = true;
            this.editstd.Click += new System.EventHandler(this.editstd_Click);
            // 
            // Selecttime
            // 
            this.Selecttime.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Selecttime.AllowDrop = true;
            this.Selecttime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selecttime.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecttime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Selecttime.FormattingEnabled = true;
            this.Selecttime.Items.AddRange(new object[] {
            "07-08 AM",
            "08-09 AM",
            "09-10 AM",
            "10-11 AM",
            "11-12 AM",
            "12-01 PM",
            "01-02 PM",
            "02-03 PM",
            "03-04 PM",
            "04-05 PM",
            "05-06 PM",
            "06-07 PM"});
            this.Selecttime.Location = new System.Drawing.Point(15, 239);
            this.Selecttime.Name = "Selecttime";
            this.Selecttime.Size = new System.Drawing.Size(183, 30);
            this.Selecttime.TabIndex = 85;
            this.Selecttime.Text = "Select Timing";
            // 
            // datatable1
            // 
            this.datatable1.AllowUserToAddRows = false;
            this.datatable1.AllowUserToDeleteRows = false;
            this.datatable1.AllowUserToResizeColumns = false;
            this.datatable1.AllowUserToResizeRows = false;
            this.datatable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datatable1.BackgroundColor = System.Drawing.Color.Teal;
            this.datatable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datatable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datatable1.ColumnHeadersHeight = 25;
            this.datatable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datatable1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datatable1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datatable1.GridColor = System.Drawing.Color.White;
            this.datatable1.Location = new System.Drawing.Point(3, 318);
            this.datatable1.Name = "datatable1";
            this.datatable1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datatable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datatable1.RowHeadersVisible = false;
            this.datatable1.RowHeadersWidth = 50;
            this.datatable1.Size = new System.Drawing.Size(1096, 442);
            this.datatable1.TabIndex = 86;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 772);
            this.Controls.Add(this.datatable1);
            this.Controls.Add(this.Selecttime);
            this.Controls.Add(this.editstd);
            this.Controls.Add(this.feesubmit);
            this.Controls.Add(this.GenCert);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.vewfee);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Addnew);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label adminhello;
        private System.Windows.Forms.Button Addnew;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button vewfee;
        private System.Windows.Forms.Button viewall;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button GenCert;
        private System.Windows.Forms.Button feesubmit;
        private System.Windows.Forms.Button studentlist;
        private System.Windows.Forms.Button editstd;
        private System.Windows.Forms.ComboBox Selecttime;
        private System.Windows.Forms.DataGridView datatable1;
        private System.Windows.Forms.Label label2;
    }
}