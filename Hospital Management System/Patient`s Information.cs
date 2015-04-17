
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Include this in every form to use mysql namespace
using Microsoft.Office.Interop.Excel;


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
            System.Data.DataTable source = new System.Data.DataTable();     //getting the data
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
                   string.IsNullOrEmpty(this.textBox3.Text))
                    
                    
                {
                    MessageBox.Show("Please make sure you filled all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    patient = new PatientService.PatientClass(); 
                    //PatientClass pc = new PatientClass();

                    patient.PatID = textBox1.Text;
                    patient.Fname = textBox2.Text;
                    patient.Lname = textBox3.Text;

                    if (textBox7.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for NIC", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Nic = textBox7.Text;
                    }

                    patient.Dob = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    if (textBox8.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for Weight", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Weight = textBox8.Text;
                    }

                    
                    if (textBox4.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for Address1", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Address1 = textBox4.Text;
                    }

                    if (textBox9.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for Address2", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Address2 = textBox9.Text;
                    }


                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a Country", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Country1 = comboBox1.Text;
                    }


                    if (comboBox4.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a State", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.State = comboBox4.Text;
                    }
                    
                    patient.DateAdmit = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    patient.DateDisch = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                    patient.Bgroup = comboBox2.Text;

                    if (comboBox3.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a Marital State", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Maritial = comboBox3.Text;
                    }


                    if (radioButton1.Checked == true)
                    {

                        patient.Gender = Convert.ToString(radioButton1.Text);
                    }
                    else
                    {
                        patient.Gender = Convert.ToString(radioButton2.Text);
                    }

                    
                    if (maskedTextBox4.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for Tel Num", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Telnum = maskedTextBox4.Text;
                    }

                    
                    if (maskedTextBox3.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for Mob Num", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        patient.Mobnum = maskedTextBox3.Text;
                    }



                    MessageBox.Show("Patient Details are Saved Successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // pc.addPatient();        //call the addPatient method to save the data

                    client.AddPatient(patient);
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error in Process, Please Check again" + ex.Message, "Error Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
            }

            
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > DateTime.Today.Date)
            {
                MessageBox.Show("DOB should be past value", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            else
            {
                //to calculate age
                int age = DateTime.Today.Year - dateTimePicker2.Value.Year;     //Current year - birth year
                label13.Text = age.ToString();
            }
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Patient ID";
            ws.Cells[1, 2] = "FName";
            ws.Cells[1, 3] = "LName";
            ws.Cells[1, 4] = "Date_Adm";
            ws.Cells[1, 5] = "Date_Dis";
            ws.Cells[1, 6] = "NIC";
            ws.Cells[1, 7] = "Gender";
            ws.Cells[1, 8] = "DOB";
            ws.Cells[1, 9] = "Blood_Grp";
            ws.Cells[1, 10] = "Weight";
            ws.Cells[1, 11] = "Marital";
            ws.Cells[1, 12] = "Add1";
            ws.Cells[1, 13] = "Add2";
            ws.Cells[1, 14] = "Nationality";
            ws.Cells[1, 15] = "State";
            ws.Cells[1, 16] = "Tel_Num";
            ws.Cells[1, 17] = "Mob_Num";

            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 2; i <= 17; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;

                }

            }
        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker3.Value < DateTime.Today.Date)
            {
                MessageBox.Show("Date Discharge should be a future value", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);           
                return;
            }

           
        }

      

        }

        
        }
        
    

