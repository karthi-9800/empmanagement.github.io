using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace Employee_management
{
    public partial class Salary : Form
    {
        private object textBox3;

        public Salary()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Managers_Btn_CheckedChanged(object sender, EventArgs e)
        {
            Managers_Btn.ForeColor = Color.Green;
            Emp_Radio_Btn.ForeColor = Color.Red;

            Name_ComBox.Items.Clear();

            Name_ComBox.Items.Add("Venkat");
            Name_ComBox.Items.Add("ram");
            Name_ComBox.Items.Add("Ezhumalai");
        }

        private void Emp_Radio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            Emp_Radio_Btn.ForeColor = Color.Green;
            Managers_Btn.ForeColor = Color.Red;

            Name_ComBox.Items.Clear();


            Name_ComBox.Items.Add("Moorthi");
            Name_ComBox.Items.Add("Dinesh");
            Name_ComBox.Items.Add("ganesh");


        }

        private void data_GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Name_ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(Name_ComBox.SelectedItem.ToString() == "Venkat")
            {
                Total_Salary.Text = "250000";
         

            }
            else if (Name_ComBox.SelectedItem.ToString() == "ram")
            {
                Total_Salary.Text = "60000";
           

            }

            else if (Name_ComBox.SelectedItem.ToString() == "Ezhumalai")
            {
                Total_Salary.Text = "30000";
               

            }
            else if (Name_ComBox.SelectedItem.ToString() == "Moorthi")
            {
                Total_Salary.Text = "15000";
             

            }

            else if (Name_ComBox.SelectedItem.ToString() == "ganesh")
            {
                Total_Salary.Text = "123000";
             

            }
            else if (Name_ComBox.SelectedItem.ToString() == "Dinesh")
            {
                Total_Salary.Text = "187000";
               

            }
            else
            {
                Total_Salary.Text = "0";
            }






        }

        private void Bonus_txt_TextChanged(object sender, EventArgs e)
        {
            if(Bonus_txt.Text.Length > 0){

                Total_txt.Text = (Convert.ToInt32(Total_Salary.Text) + Convert.ToInt32(Bonus_txt.Text)).ToString();
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_salary", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = Name_ComBox.Text.Trim();


                SqlParameter p2 = new SqlParameter("@salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = Total_Salary.Text.Trim();

                SqlParameter p3 = new SqlParameter("@bonus", SqlDbType.Float);
                cmd.Parameters.Add(p3).Value = Bonus_txt.Text.Trim();

                SqlParameter p4 = new SqlParameter("@total", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = Total_txt.Text.ToString();

              

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Employee Salary Added");
                }
                else
                {
                    MessageBox.Show("!!Failed!!");
                    Con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Salary_Fecth_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
            Con.Open();

            SqlCommand cmd = new SqlCommand("sp_salary_Fetch", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);

            data_GridView1.DataSource = DS.Tables[0];
            Con.Close();
        }

        private void Salary_Fecth_btn_MouseHover(object sender, EventArgs e)
        {
            Salary_Fecth_btn.BackColor = Color.Blue;
            Salary_Fecth_btn.ForeColor = Color.White;

    }

        private void Salary_Fecth_btn_MouseLeave(object sender, EventArgs e)
        {
            Btn_Add.BackColor = Color.White;
            Btn_Add.ForeColor = Color.Blue;

        }

        private void Btn_Add_MouseHover(object sender, EventArgs e)
        {
            Btn_Add.BackColor = Color.Aqua;
            Btn_Add.ForeColor = Color.White;
        }

        private void Btn_Add_MouseLeave(object sender, EventArgs e)
        {
            Btn_Add.BackColor = Color.White;
            Btn_Add.ForeColor = Color.Blue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files(*.*)|*.*";
            OF.FilterIndex = 1;
            OF.RestoreDirectory = true;
            
            if(OF.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OF.FileName);
            }
        }
    }
}
