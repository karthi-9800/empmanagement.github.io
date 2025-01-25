using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management
{
    public partial class EmployeeSalary : Form
    {

        public string Gender = "";
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeSalary_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            Invoice I = new Invoice();
            I.img = pictureBox1.Image;
            I.Name = guna2TextBox1.Text;
            if(guna2ComboBox1.SelectedIndex == -1)
            {
                I.Department = "";
            }
            else
            {
                I.Department = guna2ComboBox1.SelectedItem.ToString();
            }

            I.Department = guna2ComboBox1.SelectedItem.ToString();
            I.Salary = guna2TextBox2.Text;
            I.Bonus = guna2TextBox3.Text;
            I.Total = guna2TextBox4.Text;
            I.Gender = Gender;
         
            I.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Z = new OpenFileDialog();
            Z.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            Z.Title = "Selcet an Employee Image";

            if(Z.ShowDialog() == DialogResult.OK)
            {
                string filepath = Z.FileName;
                pictureBox1.Image = Image.FromFile(filepath);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBox3.Text.Length > 0)
            {
                guna2TextBox4.Text =( Convert.ToInt32(guna2TextBox3.Text) + Convert.ToInt32(guna2TextBox2.Text)).ToString();
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
