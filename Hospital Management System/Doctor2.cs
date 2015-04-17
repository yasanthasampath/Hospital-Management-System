using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Hospital_Management_System
{
    public partial class Doctor2 : Form
    {
        public Doctor2()
        {
            InitializeComponent();
          
        }



        private void Doctor2_Load(object sender, EventArgs e)
        {
            //DoctorService.DoctorServiceClient client = new DoctorService.DoctorServiceClient();
            //DoctorService.DoctorClass doctor = new DoctorService.DoctorClass();

           // dataGridView1.DataSource = client.getDoctorPriceDetails();
            //this.comboBox1.DataSource = client.getDoctorPriceDetails();
            //this.comboBox1.DisplayMember = "FULL";
            //this.comboBox1.ValueMember = "doc_id";
            //textBox10.Text = doctor.Speclty;
            //textBox11.Text = doctor.Chnlfee.ToString();


           // doctor = client.getDoctorPriceDetails();
          //  comboBox1.DataSource = doctor.fullName;
            //textBox10.Text = doctor.Speclty;
            //textBox11.Text = doctor.Chnlfee.ToString();
           

            //This is to display the doctor details onto the combobox and textboxes
            //ConnectDb dbcon = new ConnectDb();
            //try
            //{
               
            //    dbcon.openCon();
            //    //join the first name and last name from doctor table then use it to display full name in combobox
            //    string query = "SELECT doc_id,Speciality,Channeling_Fee,CONCAT(F_Name,\" \", L_Name)AS FULL FROM doctor";
            //    //dbcon.dAdapter = new MySqlDataAdapter(query, dbcon.connDB);

            //    dbcon.setdAdapter(query);
            //    DataSet ds = new DataSet();
            //    dbcon.dAdapter.Fill(ds);
            //    this.comboBox1.DataSource = ds.Tables[0];
            //    this.comboBox1.DisplayMember = "FULL";


            //    this.comboBox1.ValueMember = "doc_id";
                
            //    dbcon.cmnd(query);
            //    dbcon.dRead = dbcon.command.ExecuteReader();
            //    if (dbcon.dRead.Read())
            //    {

            //        textBox10.Text = dbcon.dRead["Speciality"].ToString();

            //        textBox11.Text = dbcon.dRead["Channeling_Fee"].ToString();
            //    }

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Exception Error :" + exc, "Error");
            //}
            //finally
            //{
            //    dbcon.finalize();//this is used to remove the connection to database after program is off
            //}

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    //if  change any option in comboBox this code will change the textboxes accordingly
            //    ConnectDb dbcon = new ConnectDb();
            //    dbcon.openCon();
            //    string query = "SELECT * FROM doctor WHERE doc_id='" + comboBox1.SelectedValue + "'";
            //    dbcon.cmnd(query);
            //    dbcon.dRead = dbcon.command.ExecuteReader();
            //    if (dbcon.dRead.Read())
            //    {
            //        textBox10.Text = dbcon.dRead["Speciality"].ToString();
            //        textBox11.Text = dbcon.dRead["Channeling_Fee"].ToString();

            //    }

            //}
            //catch(Exception exc){
            //    MessageBox.Show("error" + exc.Message, "Error");
            //}


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //to calculate age
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            lblAge.Text = age.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //to Search from database
                //to use classes
                
                ConnectDb dbcon = new ConnectDb();
                
                dbcon.openCon();
               
                dbcon.cmnd("SELECT * FROM doctor WHERE doc_id LIKE '%" + textBox5.Text + "%' OR L_Name LIKE '%" + textBox5.Text + "%' OR F_Name LIKE '%" + textBox5.Text + "%'");
               
                dbcon.command.Connection = dbcon.connDB;
                dbcon.dAdapter.SelectCommand = dbcon.command;

                System.Data.DataTable dt = new System.Data.DataTable(); //getting the data
                dbcon.dAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code to exit
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox9.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls)

            //    if (c is TextBox)

            //        (c as TextBox).Clear();

            foreach (Control d in this.Controls)

                if (d is MaskedTextBox)

                    (d as MaskedTextBox).Clear();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox2.Text = ""; 
            //txtNic.Text = "";
            //textBox4.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //textBox9.Text = "";
        }

        

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls)

            //    if (c is TextBox)

            //        (c as TextBox).Clear();

            foreach (Control d in this.Controls)

                if (d is MaskedTextBox)

                    (d as MaskedTextBox).Clear();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                DoctorService.DoctorServiceClient client = new DoctorService.DoctorServiceClient();
                DoctorService.DoctorClass doctor = new DoctorService.DoctorClass();

                dataGridView1.DataSource = client.getDoctor(textBox5.Text,textBox5.Text);
               
               // ConnectDb condb = new ConnectDb();
               // string qry = "SELECT *FROM doctor WHERE F_Name LIKE '%" + textBox5.Text + "%' OR L_Name LIKE '%" + textBox5.Text + "%'";
             
               // condb.cmnd(qry);
               // condb.command.Connection = condb.connDB;

               
               // condb.setdAdapter(qry);
               //condb.dAdapter.SelectCommand = condb.command;

               // DataTable dt = new DataTable();
               // condb.dAdapter.Fill(dt);

               // dataGridView1.DataSource = dt;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An Error in Process, Please Check again" + ex.Message, "Error Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
            }

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {// insert put a validation ..
                DoctorService.DoctorServiceClient client = new DoctorService.DoctorServiceClient();
                DoctorService.DoctorClass doctor = null;
                
                //DoctorClass doc = new DoctorClass();

                doctor = new DoctorService.DoctorClass();

                doctor.Fname = textBox1.Text;
                doctor.Lname = textBox2.Text;

                if (radioButton1.Checked == true)
                {
                    doctor.Gender = Convert.ToString(radioButton1.Tag);
                }
                else
                {
                    doctor.Gender = Convert.ToString(radioButton2.Tag);

                }
                doctor.Nic = txtNic.Text;
                doctor.Salary = Convert.ToDouble(textBox4.Text);
                doctor.Age = Convert.ToInt32(lblAge.Text);
                doctor.Dob = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                doctor.Qualif = textBox6.Text;
                doctor.Speclty = textBox7.Text;
                doctor.Chnlfee = Convert.ToInt32(textBox9.Text);

                MessageBox.Show("Doctor Details are Saved Successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //doc.addDoctor();    //call the addDoctor method to save the data

                client.AddDoctor(doctor);           
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("An Error in Process, Please Check again" + ex.Message, "Error Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
            }

            


                
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //if (dateTimePicker1.Value > DateTime.Today.Date)
            //{
            //    MessageBox.Show("DOB should be past value", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    return;
            //}

            //else
            //{
                int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
                lblAge.Text = age.ToString();
            //}
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Doctor ID";
            ws.Cells[1, 2] = "FName";
            ws.Cells[1, 3] = "LName";
            ws.Cells[1, 4] = "Gender";
            ws.Cells[1, 5] = "NIC";
            ws.Cells[1, 6] = "Salary";
            ws.Cells[1, 7] = "DOB";
            ws.Cells[1, 8] = "Age";
            ws.Cells[1, 9] = "Qualifications";
            ws.Cells[1, 10] = "Speciality";
            ws.Cells[1, 11] = "Channeling_Fee";

            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 2; i <= 11; i++)
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