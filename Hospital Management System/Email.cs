using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;      //name spaces
using System.Net;           //name spaces


namespace Hospital_Management_System
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {

            try
            {
                if(!txtEm3.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You must provide a gmail address");
                    return;
                }
                
                MailMessage message = new MailMessage();     //creating message class
                message.From = new MailAddress(txtEm3.Text);
                message.Subject = txtSub1.Text;
                message.Body = txtBody2.Text;

                foreach (string s in txtRes5.Text.Split(';'))

                    message.To.Add(s);

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(txtEm3.Text, txtPas4.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);

                MessageBox.Show("Email Sent, Thanks","Send Mail");
            }


            catch(Exception ex)
            {
                MessageBox.Show("There was an error, Please Check", "Error Message" + ex.Message);
            }


            finally
            {
                MessageBox.Show("Thanks for using this Email App","Thanks");
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}
