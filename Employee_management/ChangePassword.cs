using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_management
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void Conifirm_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (Set_New_pass.Text.Trim().Length >= 6) {


                    if (Set_New_pass.Text.Trim() == Re_Enter_pass.Text.Trim())
                    {

                        SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("sp_register_tbl1", Con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@username", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = Change_Uname.Text.Trim();


                        SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
                        cmd.Parameters.Add(p2).Value = Set_New_pass.Text.Trim();

                        SqlParameter p3 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                        cmd.Parameters.Add(p3).Value = Re_Enter_pass.Text.Trim();



                        int a = cmd.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Password Updated Successfully");
                            Login log = new Login();
                            log.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("!! Password Updataion Failed!!");

                            Change_Uname.Clear();
                            Set_New_pass.Clear();
                            Re_Enter_pass.Clear();

                            Con.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Miss Match Password");
                    }
                }
                
                else
                {
                    MessageBox.Show("Password Must Have 6 Digits");
                }      

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Change_Uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Re_Enter_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
