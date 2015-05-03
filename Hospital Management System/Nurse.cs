using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using System.ServiceModel;

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
            NurseService.NurseServiceClient client = new NurseService.NurseServiceClient();
            NurseService.Nurseclass nurse = null;
            try
            {
                nurse = new NurseService.Nurseclass();
              //  Nurseclass nur = new Nurseclass();
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for First Name","Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.Fname = textBox1.Text;
                }

                
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Last Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.Lname = textBox2.Text;
                }

                
                if (radioButton1.Checked == true)
                {
                    nurse.Gender = Convert.ToString(radioButton1.Tag);
                }

                else
                {
                    nurse.Gender = Convert.ToString(radioButton2.Tag);
                }

               
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Last Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.NurseId1 = textBox3.Text;
                }

                
                if (textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Salary", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.Salary = textBox4.Text;
                }

                nurse.Dob = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

                if (textBox6.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Qualifications", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.Qualif = textBox6.Text;
                }

                if (textBox7.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for Shift", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    nurse.Shift = textBox7.Text;
                }

                MessageBox.Show("Nurse Details are Saved Successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // nur.addNurse();     //call the addNurse method to save the data
                client.AddNurse(nurse);

            }

            catch (CommunicationException fx)
            {
                MessageBox.Show("Communication error: " + fx.Message, "cannot connect to the host computer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SendKeys.Send("%{F4}");
            }

            catch(Exception ex) 
            {
                MessageBox.Show("An Error in Process, Please Check again"+ex.Message,"Error Message",MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);


            }


            //finally
            //{
            //    MessageBox.Show("End of Process,Thank You", "Process End", MessageBoxButtons.OK);
            //}

        }


        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor2 doc3 = new Doctor2();
            doc3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Text = "";
           

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
                NurseService.NurseServiceClient client = new NurseService.NurseServiceClient();
                NurseService.Nurseclass nurse = new NurseService.Nurseclass();

                dataGridView1.DataSource = client.getNurse(textBox5.Text,textBox5.Text);
            }

            catch (CommunicationException fx)
            {
                MessageBox.Show("Communication error: " + fx.Message, "cannot connect to the host computer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SendKeys.Send("%{F4}");
            }
           
            catch(Exception ex)
            {
                MessageBox.Show("System Error" +ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Today.Date)
            {
                MessageBox.Show("DOB should be past value", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);           
                return;
            }

            else
            {
                int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
                label16.Text = age.ToString();
            }
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "FName";
            ws.Cells[1, 2] = "LName";
            ws.Cells[1, 3] = "Gender";
            ws.Cells[1, 4] = "Nurse ID";
            ws.Cells[1, 5] = "Salary";
            ws.Cells[1, 6] = "DOB";
            ws.Cells[1, 7] = "Qualifications";
            ws.Cells[1, 8] = "Shift";

            for (int j =  2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 8; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;

                }

            }
        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
    }
}

        