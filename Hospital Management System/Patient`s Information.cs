
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Include this in every form to use mysql namespace

namespace Hospital_Management_System 
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //To exit the form
        }

        private void button1_Click(object sender, EventArgs e)
        {

                    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //selecting blood grup from database
            string ConnectionString = "server=localhost;User Id=root;database=hospital_system";
            string query = "SELECT * FROM blood_group";
            MySqlDataAdapter dAdapter = new MySqlDataAdapter(query, ConnectionString); //MysqlDataAdapter is a helper class  which represent SqlCommand, SqlConnection
            DataTable source = new DataTable();     //getting the data
            dAdapter.Fill(source);
            comboBox2.DataSource = source;


            comboBox2.DisplayMember = "type";       //show data in "type" colum


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                PatientService.PatientServiceClient client = new PatientService.PatientServiceClient();
                PatientService.PatientClass patient = new PatientService.PatientClass();

                dataGridView1.DataSource = client.getPatient(textBox5.Text, textBox5.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button1_Click_1(object sender, EventArgs e)    //This is to save the patient details
        {
            PatientService.PatientServiceClient client = new PatientService.PatientServiceClient();
            PatientService.PatientClass patient = null;
            
            try
            {
                

                if (string.IsNullOrEmpty(this.textBox1.Text) ||
                   string.IsNullOrEmpty(this.textBox2.Text) ||
                    string.IsNullOrEmpty(this.textBox3.Text) ||
                    string.IsNullOrEmpty(this.textBox4.Text))
                    
                {
                    MessageBox.Show("Please make sure you filled all fields","error");
                }
                else
                {
                    patient = new PatientService.PatientClass(); 
                    //PatientClass pc = new PatientClass();
                    patient.PatID = textBox1.Text;
                    patient.Fname = textBox2.Text;
                    patient.Lname = textBox3.Text;
                    patient.Nic = textBox7.Text;
                    patient.Dob = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    patient.Weight = textBox8.Text;
                    patient.Address1 = textBox4.Text;
                    patient.Address2 = textBox9.Text;
                    patient.Country1 = comboBox1.Text;
                    patient.State = comboBox4.Text;

                    
                    patient.DateAdmit = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    patient.DateDisch = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                    patient.Bgroup = comboBox2.Text;
                    patient.Maritial = comboBox3.Text;

                    if (radioButton1.Checked == true)
                    {

                        patient.Gender = Convert.ToString(radioButton1.Text);
                    }
                    else
                    {
                        patient.Gender = Convert.ToString(radioButton2.Text);
                    }
                    patient.Telnum = maskedTextBox4.Text;
                    patient.Mobnum = maskedTextBox3.Text;

                    

                   
                    MessageBox.Show("Details are saved", "Saved");
                   // pc.addPatient();        //call the addPatient method to save the data

                    client.AddPatient(patient);
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Error : "+ex.Message);
            }

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //there is no code here foreach (Control c in this.Controls)
             foreach (Control c in this.Controls)
                if (c is TextBox)

                    (c as TextBox).Clear();

            foreach (Control d in this.Controls)

                if (d is MaskedTextBox)

                    (d as MaskedTextBox).Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            //to calculate age
            int age = DateTime.Today.Year - dateTimePicker2.Value.Year;     //Current year - birth year
            label13.Text = age.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      

        }

        
        }
        
    

