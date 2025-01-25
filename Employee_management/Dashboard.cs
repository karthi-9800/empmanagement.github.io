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
using System.Drawing.Printing;

namespace Employee_management
{
    public partial class Dashboard : Form
    {
        private object dataGridView1;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully");
                Login log = new Login();
                log.Show();
                this.Hide();

               
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_emp_register", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = Emp_Id.Text.Trim();


                SqlParameter p2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = Emp_Name.Text.Trim();

                SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.Float);
                cmd.Parameters.Add(p3).Value = Emp_Salary.Text.Trim();

                SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = Emp_Dep.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = Emp_Rl.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Employee Details Added");
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

        private void Emp_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Fetch_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
            Con.Open();

            SqlCommand cmd = new SqlCommand("sp_fect", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);

            data_GridView1.DataSource = DS.Tables[0];
            Con.Close();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Want to Delete Employee?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = Search_Emp.Text;

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                }

                Con.Close();


        

            }
       

        

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
            Con.Open();

            SqlCommand cmd = new SqlCommand("sp_search", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = Search_Emp.Text;

            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            data_GridView1.DataSource = DS.Tables[0];
            Con.Close();
        }

        private void Btn_Udate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source =DESKTOP-ABR59QJ\SQLEXPRESS;Initial Catalog = DB_EMPLOYEES;Integrated Security = True");
                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_update", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = Emp_Id.Text.Trim();


                SqlParameter p2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = Emp_Name.Text.Trim();

                SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.Float);
                cmd.Parameters.Add(p3).Value = Emp_Salary.Text.Trim();

                SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = Emp_Dep.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = Emp_Rl.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("!! Updataion Failed!!");
                    Con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (data_GridView1.Rows.Count > 0)
            {
                using (Bitmap B = new Bitmap(data_GridView1.Width, data_GridView1.Height))
                {
                    data_GridView1.DrawToBitmap(B, new Rectangle(0, 0, data_GridView1.Width, data_GridView1.Height));
                    e.Graphics.DrawImage(B, 120, 120);
                }
            }
            else
            {
                e.Graphics.DrawString("No data available to print.", new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog
            {
                Document = printDocument1
            };
            printPreviewDialog1.ShowDialog();
        }

        private void data_GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Emp_Id.Text = data_GridView1.SelectedRows[0].Cells[0].Value.ToString();

                Emp_Name.Text = data_GridView1.SelectedRows[0].Cells[1].Value.ToString();

                Emp_Salary.Text = data_GridView1.SelectedRows[0].Cells[2].Value.ToString();

                Emp_Dep.Text = data_GridView1.SelectedRows[0].Cells[3].Value.ToString();

                Emp_Rl.Text = data_GridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void data_GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void payslip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeSalary emp = new EmployeeSalary();
            emp.Show();
            this.Hide();
        }
    }
}
