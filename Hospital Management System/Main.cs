using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Main : Form
    {
        private int hr, min, sec;
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

      private void Nurse_Click(object sender, EventArgs e)
        {
            //for search its opening 
            Nurse nurse = new Nurse();
            nurse.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks  for using our system..!", "GoodBye..!");
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor2 doc = new Doctor2();
            doc.Show();
            // first double click button -create object called doc and use Show function 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                hr = DateTime.UtcNow.Hour;
                hr = hr + 4; //Note: since srilanka is GMT+4
                min = DateTime.UtcNow.Minute;
                sec = DateTime.UtcNow.Second;

                if (hr > 12)
                    hr -= 12;
                if (sec % 2 == 0)
                {
                    lblTime.Text = hr + ":" + min + ":" + sec;
                }
                else
                {
                    lblTime.Text = hr + ":" + min + ":" + sec;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception" + ex.Message,"error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            BillForm newBill = new BillForm();

            newBill.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doctor2 doc = new Doctor2();
            doc.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurse nurse = new Nurse();
            nurse.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BillForm bill = new BillForm();
            bill.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Form3 lab = new Form3();
            lab.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           BillForm lab = new BillForm();
            lab.Show();
        }
    }
}

      
      
       

        



    

        



            
               

       
         


       

 
          
        



            
             