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
     //   BillClass bill1;

       
        public BillForm()
        {
            InitializeComponent();
          //  bill1 = new BillClass();
         //   label16.Text = Convert.ToString(bill1.Channel);

            label16.Text = ""+500;
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            label17.Text = "0";
            label18.Text = Convert.ToString(BillClass.channel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
    ///check        bill1.BillTot = bill1.Channel + bill1.calcCharge();
   /// check        label18.Text = Convert.ToString(bill1.BillTot);
   

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(dateTimePicker1.Value > DateTime.Today.Date)) //date admit should only be past or today
                {
                    if (dateTimePicker2.Value > DateTime.Today)
                    {

                ///check       bill1.DaysAdmit = dateTimePicker1.Value;
                ///check        bill1.DaysDisch = dateTimePicker2.Value;
                    ///check    label17.Text = Convert.ToString(bill1.calcCharge());
                        int daysStay = (dateTimePicker1.Value).Date.Day - (dateTimePicker2.Value).Date.Day;
                        label17.Text = Convert.ToString  (500 * daysStay);
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
            BillService.BillServiceClient client = new BillService.BillServiceClient();
            BillService.BillClass bill1 = new BillService.BillClass();
            
            try
            {
                //~~~~~~label18.text = label16.text+label17.text;
                // BillClass bill1 = new BillClass(); 

                bill1.DaysAdmit = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                bill1.DaysDisch = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                bill1.Ward = comboBox1.Text;

                bill1.Room = txtroo.Text;

                bill1.BillTot = Convert.ToInt32(label18.Text);
                bill1.Charge = Convert.ToInt32(label17.Text);


                client.AddBill(bill1);
               // MessageBox.Show("Data saved", "DONE");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error, Please check" + ex.Message);
            }
            
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
