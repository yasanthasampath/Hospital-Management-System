using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   //Include this in every form to use mysql namespace
using System.ServiceModel;

namespace Hospital_Management_System
{
    public partial class BillForm : Form
    {
     //   BillClass bill1;
        BillService.BillServiceClient client ;
        BillService.BillClass bill1 ;
       
        public BillForm()
        {
            InitializeComponent();
          //  bill1 = new BillClass();
         //   label16.Text = Convert.ToString(bill1.Channel);

            label16.Text = ""+500;
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
           // label17.Text = "0";
          //  label18.Text = Convert.ToString(BillClass.channel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker2.Value < DateTime.Today.Date)
            {
                MessageBox.Show("Discharge Date should be Future value", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);           
                return;
            }

            else
            {
            
                int daysStay = ((dateTimePicker2.Value).Date - (dateTimePicker1.Value).Date).Days;
                label17.Text = Convert.ToString  (500 * daysStay);
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
             client = new BillService.BillServiceClient();
             bill1 = new BillService.BillClass();
            
            try
            {
                //~~~~~~label18.text = label16.text+label17.text;
                // BillClass bill1 = new BillClass(); 

                bill1.DaysAdmit = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                bill1.DaysDisch = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd"));

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Ward", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    bill1.Ward = comboBox1.Text;
                }

                if (txtroo.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Room Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    bill1.Room = txtroo.Text;
                }

                bill1.BillTot = Convert.ToInt32(label18.Text);
                bill1.Charge = Convert.ToInt32(label17.Text);

                MessageBox.Show("Bill Details are Saved Successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                client.AddBill(bill1);
               // MessageBox.Show("Data saved", "DONE");
            }

            catch (CommunicationException fx)
            {
                MessageBox.Show("Communication error: " + fx.Message, "cannot connect to the host computer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SendKeys.Send("%{F4}");
            }

            catch(Exception ex)
            {
                MessageBox.Show("An Error in Process, Please Check again" + ex.Message, "Error Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
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

        private void label17_TextChanged(object sender, EventArgs e)
        {
            label18.Text = 0 + "";
            bill1 = new BillService.BillClass();
            
            bill1.BillTot = Convert.ToInt32(label16.Text) + Convert.ToInt32(label17.Text);
            label18.Text = bill1.BillTot + "";
        }
    }
}
