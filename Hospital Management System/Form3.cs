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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks  for using our system..!", "GoodBye..!");
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

     
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            BillForm l = new BillForm();
            l.Show();
        }

    }
}

        