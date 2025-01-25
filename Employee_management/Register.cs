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
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Employee_management
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

        public bool IsEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (reguname_tb.Text.Trim() != "" && regpass_tb.Text.Trim() != "" && textBox1.Text.Trim() != "" && regemail_tb.Text.Trim() != "" && regmob_tb.Text.Trim() != "")
                {

                    string emailAddress = regemail_tb.Text;
                    bool isValid = IsEmailValid(emailAddress);
                    if (isValid) 
                    {
                        if (regpass_tb.Text.Trim().Length >= 8)
                        {
                            if (regpass_tb.Text.Trim() == textBox1.Text.Trim())
                            {

                                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                                Con.Open();
                                SqlCommand cmd = new SqlCommand("sp_register1", Con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@username", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = reguname_tb.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = regpass_tb.Text.Trim();


                                SqlParameter p3 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = textBox1.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = regemail_tb.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@mobile", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = regmob_tb.Text.Trim();

                                int a = cmd.ExecuteNonQuery();

                                if (a > 0)
                                {
                                    MessageBox.Show("Registered Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Registeration Failed");
                                    Con.Close();
                                }
                            }

                            else
                            {
                                MessageBox.Show("Miss match Password");
                            }


                        }

                        else
                        {
                            MessageBox.Show("Password must have 8 Digits");

                        }
                    }

                    else 
                    {
                        MessageBox.Show("Please  enter valid Email");
                    }



                    

                }
                else
                {
                    MessageBox.Show("Fill All The Data's");
                }

               
               }


                 catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
               
               }
           


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
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
            reguname_tb.Clear();
            regpass_tb.Clear();
            textBox1.Clear();
            regemail_tb.Clear();
            regmob_tb.Clear();
        }

        private void regpass_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
