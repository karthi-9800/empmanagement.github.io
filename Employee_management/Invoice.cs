using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management
{
    public partial class Invoice : Form
    {
        public string Date, Name, Department, Salary, Bonus, Total, Gender;

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (BM == null)
            {
                throw new ArgumentNullException(nameof(BM), "Bitmap cannot be null.");
            }

            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(BM, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        public Image img = null;

        public PrintDocument PrintDocument1 { get; private set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print(this.panel1);
        }

        public object PrintPreviewDialog1 { get; private set; }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        public Invoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString();
        }

        private void print(Panel a)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a), "Panel cannot be null.");
            }

            panel1 = a;

            BM = new Bitmap(a.Width, a.Height);
            a.DrawToBitmap(BM, new Rectangle(0, 0, a.Width, a.Height));

            if (printPreviewDialog1 == null)
            {
                printPreviewDialog1 = new PrintPreviewDialog();
            }

            if (PrintDocument1 == null)
            {
                PrintDocument1 = new PrintDocument();
            }

            printPreviewDialog1.Document = PrintDocument1;

            PrintDocument1.PrintPage -= printDocument1_PrintPage; // Ensure no duplicate event handlers
            PrintDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }


        private Bitmap BM;
        private PrintPageEventHandler PrintEventHandler(Action<object, PrintPageEventArgs> printDocument1_PrintPage)
        {
            throw new NotImplementedException();
        }

        private PrintPageEventHandler PrintEventHandler(PrintDocument printDocument1)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            date.Text = Date;
            pictureBox3.Image = img;    
            lbl_name.Text = Name;
            lbl_bonus.Text = Bonus;
            lbl_salary.Text = Salary;
            lbl_dept.Text = Department;
            lbl_total.Text = Total;
            lbl_gender.Text = Gender;

        }
    }

    internal class PrinterSettings
    {
    }
}
