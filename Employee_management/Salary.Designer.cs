namespace Employee_management
{
    partial class Salary
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
            this.data_GridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Managers_Btn = new System.Windows.Forms.RadioButton();
            this.Emp_Radio_Btn = new System.Windows.Forms.RadioButton();
            this.Total_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_ComBox = new System.Windows.Forms.ComboBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Bonus_txt = new System.Windows.Forms.TextBox();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.Salary_Fecth_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.data_GridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 638);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // data_GridView1
            // 
            this.data_GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GridView1.Location = new System.Drawing.Point(0, 343);
            this.data_GridView1.Name = "data_GridView1";
            this.data_GridView1.RowHeadersWidth = 62;
            this.data_GridView1.RowTemplate.Height = 28;
            this.data_GridView1.Size = new System.Drawing.Size(446, 256);
            this.data_GridView1.TabIndex = 15;
            this.data_GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(506, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(638, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Salary";
            // 
            // Managers_Btn
            // 
            this.Managers_Btn.AutoSize = true;
            this.Managers_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managers_Btn.Location = new System.Drawing.Point(499, 124);
            this.Managers_Btn.Name = "Managers_Btn";
            this.Managers_Btn.Size = new System.Drawing.Size(125, 29);
            this.Managers_Btn.TabIndex = 26;
            this.Managers_Btn.TabStop = true;
            this.Managers_Btn.Text = "Managers";
            this.Managers_Btn.UseVisualStyleBackColor = true;
            this.Managers_Btn.CheckedChanged += new System.EventHandler(this.Managers_Btn_CheckedChanged);
            // 
            // Emp_Radio_Btn
            // 
            this.Emp_Radio_Btn.AutoSize = true;
            this.Emp_Radio_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Radio_Btn.Location = new System.Drawing.Point(722, 124);
            this.Emp_Radio_Btn.Name = "Emp_Radio_Btn";
            this.Emp_Radio_Btn.Size = new System.Drawing.Size(134, 29);
            this.Emp_Radio_Btn.TabIndex = 27;
            this.Emp_Radio_Btn.TabStop = true;
            this.Emp_Radio_Btn.Text = "Employees";
            this.Emp_Radio_Btn.UseVisualStyleBackColor = true;
            this.Emp_Radio_Btn.CheckedChanged += new System.EventHandler(this.Emp_Radio_Btn_CheckedChanged);
            // 
            // Total_Salary
            // 
            this.Total_Salary.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Salary.Location = new System.Drawing.Point(511, 299);
            this.Total_Salary.Name = "Total_Salary";
            this.Total_Salary.Size = new System.Drawing.Size(359, 35);
            this.Total_Salary.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(506, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(516, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total  Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(506, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Bonus";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Name_ComBox
            // 
            this.Name_ComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_ComBox.FormattingEnabled = true;
            this.Name_ComBox.Location = new System.Drawing.Point(511, 205);
            this.Name_ComBox.Name = "Name_ComBox";
            this.Name_ComBox.Size = new System.Drawing.Size(359, 33);
            this.Name_ComBox.TabIndex = 34;
            this.Name_ComBox.SelectedIndexChanged += new System.EventHandler(this.Name_ComBox_SelectedIndexChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Add.Location = new System.Drawing.Point(763, 564);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(107, 46);
            this.Btn_Add.TabIndex = 35;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            this.Btn_Add.MouseLeave += new System.EventHandler(this.Btn_Add_MouseLeave);
            this.Btn_Add.MouseHover += new System.EventHandler(this.Btn_Add_MouseHover);
            // 
            // Bonus_txt
            // 
            this.Bonus_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus_txt.Location = new System.Drawing.Point(511, 400);
            this.Bonus_txt.Name = "Bonus_txt";
            this.Bonus_txt.Size = new System.Drawing.Size(359, 35);
            this.Bonus_txt.TabIndex = 36;
            this.Bonus_txt.TextChanged += new System.EventHandler(this.Bonus_txt_TextChanged);
            // 
            // Total_txt
            // 
            this.Total_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_txt.Location = new System.Drawing.Point(511, 506);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(359, 35);
            this.Total_txt.TabIndex = 37;
            // 
            // Salary_Fecth_btn
            // 
            this.Salary_Fecth_btn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Salary_Fecth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salary_Fecth_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_Fecth_btn.ForeColor = System.Drawing.Color.Navy;
            this.Salary_Fecth_btn.Location = new System.Drawing.Point(511, 564);
            this.Salary_Fecth_btn.Name = "Salary_Fecth_btn";
            this.Salary_Fecth_btn.Size = new System.Drawing.Size(107, 46);
            this.Salary_Fecth_btn.TabIndex = 38;
            this.Salary_Fecth_btn.Text = "FETCH";
            this.Salary_Fecth_btn.UseVisualStyleBackColor = true;
            this.Salary_Fecth_btn.Click += new System.EventHandler(this.Salary_Fecth_btn_Click);
            this.Salary_Fecth_btn.MouseLeave += new System.EventHandler(this.Salary_Fecth_btn_MouseLeave);
            this.Salary_Fecth_btn.MouseHover += new System.EventHandler(this.Salary_Fecth_btn_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(284, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Brows";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 638);
            this.Controls.Add(this.Salary_Fecth_btn);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.Bonus_txt);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Name_ComBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_Radio_Btn);
            this.Controls.Add(this.Managers_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Managers_Btn;
        private System.Windows.Forms.RadioButton Emp_Radio_Btn;
        private System.Windows.Forms.TextBox Total_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Name_ComBox;
        private System.Windows.Forms.DataGridView data_GridView1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox Bonus_txt;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.Button Salary_Fecth_btn;
        private System.Windows.Forms.Button button1;
    }
}