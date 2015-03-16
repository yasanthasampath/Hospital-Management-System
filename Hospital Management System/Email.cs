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
            MailMessage message = new MailMessage();     //creating message class
            message.From = new MailAddress(txtEm3.Text);
            message.Subject = txtSub1.Text;
            message.Body = txtBody2.Text;




        }
    }
}
