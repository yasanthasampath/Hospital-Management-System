using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   //Include this in every form to use mysql namespace

namespace Hospital_Management_System
{
    public partial class BillForm : Form
    {
        BillClass bill1;

        public BillClass Bill1
        {
            get { return bill1; }
            set { bill1 = value; }
        }
        public BillForm()
        {
            InitializeComponent();
            bill1 = new BillClass();
            label16.Text = Convert.ToString(bill1.Channel);

            
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            label17.Text = "0";
            label18.Text = Convert.ToString(BillClass.channel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill1.BillTot = bill1.Channel + bill1.calcCharge();
            label18.Text = Convert.ToString(bill1.BillTot);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(dateTimePicker1.Value > DateTime.Today.Date)) //date admit should only be past or today
                {
                    if (dateTimePicker2.Value > DateTime.Today)
                    {

                        bill1.DaysAdmit = dateTimePicker1.Value;
                        bill1.DaysDisch = dateTimePicker2.Value;
                        label17.Text = Convert.ToString(bill1.calcCharge());
                    }

                    else
                    {
                        MessageBox.Show("Date discharge can only be a future date", "Error");
                    }
                }
                else
                {//after they are admitted we make the bill, so date admit is always past
                    MessageBox.Show("Date admitted can only or past", "Error wrong date");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error exception" + exc.Message, "Error");
            }
                   

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             // insert put a validation ..
             BillClass bill1 = new BillClass(); 
                //doc.docId = textbox1.Text;
                

                //bill1.PatID = txtpaID1.Text;
                bill1.DaysAdmit = Convert.ToDateTime( dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                bill1.DaysDisch = Convert.ToDateTime( dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                bill1.Ward = comboBox1.Text;

                bill1.Room = txtroo.Text;

                bill1.BillTot =Convert.ToInt32( label18.Text);
                bill1.Charge= Convert.ToInt32( label17.Text);


                
                    


                bill1.addBill();
                MessageBox.Show("Data saved", "DONE");
                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
