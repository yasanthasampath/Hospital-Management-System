using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Nurseclass nur = new Nurseclass();
                nur.Fname = textBox1.Text;
                nur.Lname = textBox2.Text;

                if (radioButton1.Checked == true)
                {
                    nur.Gender = Convert.ToString(radioButton1.Tag);
                }

                else
                {
                    nur.Gender = Convert.ToString(radioButton2.Tag);
                }

                nur.NurseId1 = textBox3.Text;
                nur.Salary = textBox4.Text;
                nur.Dob = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                nur.Qualif = textBox6.Text;
                nur.Shift = textBox7.Text;

                MessageBox.Show("Data is Saved", "Save");
                nur.addNurse();     //call the addNurse method to save the data
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Error" + ex.Message);

            }

        }


        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor2 doc3 = new Doctor2();
            doc3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //code to clear all the textboxes in the form
            foreach (Control c in tabPage1.Controls)

                if (c is TextBox)

                    (c as TextBox).Clear();

           

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //  

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPatient patientForm = new frmPatient();
            patientForm.Show();
            BillForm billForm = new BillForm();
            billForm.Show();
        }

        private void doctorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {//double click and event created then put the code
            Doctor2 docForm = new Doctor2();
            docForm.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;User Id=root;database=hospital_system";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM nurse WHERE F_Name LIKE '%" + textBox5.Text + "%' OR L_Name LIKE '%" + textBox5.Text + "%'";
                cmd.Connection = con;

                MySqlDataAdapter adp = new MySqlDataAdapter(); //MysqlDataAdapter is a helper class  which represent SqlCommand, SqlConnection
                adp.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
            }
           
            catch(Exception ex)
            {
                MessageBox.Show("System Error" +ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            label16.Text=age.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Nurse_Load(object sender, EventArgs e)
        {

        }
    }
}

        