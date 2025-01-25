using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Employee_management
{
    public partial class ForgotPassword : Form
    {

        string randomcode;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Send_Otp_Btn_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody, to;
            Random random = new Random();
            randomcode = (random.Next(99999)).ToString();
            MailMessage message = new MailMessage();
            to = (Reg_Email.Text).ToString();
            from = "kartikvrtk@gmail.com";
            pass = "lxsa lqmf czbw wigf";
            messageBody = "Your One-Time-Password Code :" + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Employee Management Verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials  = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP Sent Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Verify_Otp_Btn_Click(object sender, EventArgs e)
        {

            if(randomcode == (Enter_Otp.Text).ToString()){

                MessageBox.Show("OTP Verfied Successfully");
                ChangePassword CP = new ChangePassword();
                CP.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
