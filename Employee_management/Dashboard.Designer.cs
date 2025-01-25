namespace Employee_management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Emp_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Emp_Dep = new System.Windows.Forms.ComboBox();
            this.Emp_Rl = new System.Windows.Forms.ComboBox();
            this.data_GridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Fetch = new System.Windows.Forms.Button();
            this.Btn_Udate = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_Emp = new System.Windows.Forms.TextBox();
            this.Emp_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.payslip = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 90);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(770, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(825, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(880, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(342, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(22, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Name";
            // 
            // Emp_Name
            // 
            this.Emp_Name.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name.Location = new System.Drawing.Point(28, 271);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(253, 34);
            this.Emp_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(23, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Salary";
            // 
            // Emp_Salary
            // 
            this.Emp_Salary.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Salary.Location = new System.Drawing.Point(30, 376);
            this.Emp_Salary.Name = "Emp_Salary";
            this.Emp_Salary.Size = new System.Drawing.Size(253, 34);
            this.Emp_Salary.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(23, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(23, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Department";
            // 
            // Emp_Dep
            // 
            this.Emp_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Dep.FormattingEnabled = true;
            this.Emp_Dep.Items.AddRange(new object[] {
            "Development",
            "HR",
            "Managing Director"});
            this.Emp_Dep.Location = new System.Drawing.Point(30, 478);
            this.Emp_Dep.Name = "Emp_Dep";
            this.Emp_Dep.Size = new System.Drawing.Size(252, 33);
            this.Emp_Dep.TabIndex = 4;
            // 
            // Emp_Rl
            // 
            this.Emp_Rl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Rl.FormattingEnabled = true;
            this.Emp_Rl.Items.AddRange(new object[] {
            "Senior Level",
            "Junior Level"});
            this.Emp_Rl.Location = new System.Drawing.Point(30, 580);
            this.Emp_Rl.Name = "Emp_Rl";
            this.Emp_Rl.Size = new System.Drawing.Size(252, 33);
            this.Emp_Rl.TabIndex = 5;
            // 
            // data_GridView1
            // 
            this.data_GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GridView1.Location = new System.Drawing.Point(307, 193);
            this.data_GridView1.Name = "data_GridView1";
            this.data_GridView1.RowHeadersWidth = 62;
            this.data_GridView1.RowTemplate.Height = 28;
            this.data_GridView1.Size = new System.Drawing.Size(602, 309);
            this.data_GridView1.TabIndex = 13;
            this.data_GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GridView1_CellContentClick);
            this.data_GridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GridView1_CellDoubleClick);
            // 
            // Btn_Fetch
            // 
            this.Btn_Fetch.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Btn_Fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fetch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fetch.ForeColor = System.Drawing.Color.Navy;
            this.Btn_Fetch.Location = new System.Drawing.Point(481, 531);
            this.Btn_Fetch.Name = "Btn_Fetch";
            this.Btn_Fetch.Size = new System.Drawing.Size(107, 46);
            this.Btn_Fetch.TabIndex = 9;
            this.Btn_Fetch.Text = "FETCH";
            this.Btn_Fetch.UseVisualStyleBackColor = true;
            this.Btn_Fetch.Click += new System.EventHandler(this.Btn_Fetch_Click);
            // 
            // Btn_Udate
            // 
            this.Btn_Udate.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Btn_Udate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Udate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Udate.ForeColor = System.Drawing.Color.Navy;
            this.Btn_Udate.Location = new System.Drawing.Point(634, 531);
            this.Btn_Udate.Name = "Btn_Udate";
            this.Btn_Udate.Size = new System.Drawing.Size(130, 46);
            this.Btn_Udate.TabIndex = 10;
            this.Btn_Udate.Text = "UPDATE";
            this.Btn_Udate.UseVisualStyleBackColor = true;
            this.Btn_Udate.Click += new System.EventHandler(this.Btn_Udate_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.Btn_Delete.Location = new System.Drawing.Point(771, 137);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(130, 46);
            this.Btn_Delete.TabIndex = 12;
            this.Btn_Delete.Text = "DELETE";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.Navy;
            this.btn_Print.Location = new System.Drawing.Point(808, 531);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(101, 46);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "PRINT";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Add.Location = new System.Drawing.Point(320, 531);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(107, 46);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Search.Location = new System.Drawing.Point(635, 137);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(130, 46);
            this.Btn_Search.TabIndex = 8;
            this.Btn_Search.Text = "SEARCH";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(315, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search Employee";
            // 
            // Search_Emp
            // 
            this.Search_Emp.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Emp.Location = new System.Drawing.Point(307, 141);
            this.Search_Emp.Name = "Search_Emp";
            this.Search_Emp.Size = new System.Drawing.Size(253, 34);
            this.Search_Emp.TabIndex = 7;
            // 
            // Emp_Id
            // 
            this.Emp_Id.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Id.Location = new System.Drawing.Point(34, 179);
            this.Emp_Id.Name = "Emp_Id";
            this.Emp_Id.Size = new System.Drawing.Size(253, 34);
            this.Emp_Id.TabIndex = 1;
            this.Emp_Id.TextChanged += new System.EventHandler(this.Emp_Id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(28, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee ID";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // payslip
            // 
            this.payslip.AutoSize = true;
            this.payslip.Location = new System.Drawing.Point(770, 617);
            this.payslip.Name = "payslip";
            this.payslip.Size = new System.Drawing.Size(130, 20);
            this.payslip.TabIndex = 21;
            this.payslip.TabStop = true;
            this.payslip.Text = "Generate Payslip";
            this.payslip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.payslip_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 649);
            this.Controls.Add(this.payslip);
            this.Controls.Add(this.Emp_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Search_Emp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.Btn_Udate);
            this.Controls.Add(this.Btn_Fetch);
            this.Controls.Add(this.data_GridView1);
            this.Controls.Add(this.Emp_Rl);
            this.Controls.Add(this.Emp_Dep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_Salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emp_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Emp_Dep;
        private System.Windows.Forms.ComboBox Emp_Rl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView data_GridView1;
        private System.Windows.Forms.Button Btn_Fetch;
        private System.Windows.Forms.Button Btn_Udate;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Search_Emp;
        private System.Windows.Forms.TextBox Emp_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.LinkLabel payslip;
    }
}