using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_management
{
    public partial class Login : Form
    {
        public char ShowPass_Checked { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           DialogResult check = MessageBox.Show("Are you Want to Exit?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                Con.Open();
                SqlCommand cmd = new SqlCommand("sp_login1", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@username", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = textBox1.Text.Trim();

                SqlParameter p2 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = textBox2.Text.Trim();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //  int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                // if (a > 0)



                if (ds.Tables[0].Rows.Count > 0)
                    {
                    MessageBox.Show("Welcom back" + " " + textBox1.Text);
                    EmpDashboard ED = new EmpDashboard();
                    ED.Show();
                    this.Hide();
                }

                else if(textBox1.Text.Trim() =="" || textBox2.Text.Trim() =="" )
                {
                    MessageBox.Show("Fill all the data's");
                }

                 else if (textBox1.Text.Trim() == "Admin" || textBox2.Text.Trim() == "12345")
                {
                    MessageBox.Show("Welcome Back Admin");
                    Dashboard d = new Dashboard();  
                    d.Show();
                     this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

            
     

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register R = new Register();
            R.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword FP = new ForgotPassword();
            FP.Show();
            this.Hide();
        }
    }
}
