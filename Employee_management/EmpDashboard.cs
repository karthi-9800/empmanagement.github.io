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
    public partial class EmpDashboard : Form
    {
        public EmpDashboard()
        {
            InitializeComponent();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void Emp_btn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible =false;
            groupBox1.Visible = true;
        }
       
            
    }
}
