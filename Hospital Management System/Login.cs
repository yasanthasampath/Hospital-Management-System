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
    public partial class Login : Form
    {
        //string ConnectionString = "server=localhost;User Id=root;database=hospital_system";
        //MySqlCommand comnd;
        //MySqlDataAdapter mysqlda;
        //DataSet ds;
        //string sqlstring;

        //----for time
        private int hr, min, sec;

        //--

        public Login()
        {
            InitializeComponent();
            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       


        private void label4_Click(object sender, EventArgs e)
        {
          


        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {



            //string query2 = "SELECT user,Password FROM login";
            //MySqlDataAdapter dAdapter2 = new MySqlDataAdapter(query2, ConnectionString);
            //DataTable source2 = new DataTable();
            //dAdapter2.Fill(source2);
            //comboBox1.DataSource = source2;

            //comboBox1.DisplayMember = "user";
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter  Password..!!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";


            }
            else
            {
                //bool login = client.login(comboBox1.Text,textBox1.Text);
                bool login = client.login(textBox2.Text, textBox1.Text);

                if (login)
                {

                    MessageBox.Show("Login Success", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Main menu = new Main();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


                //MySqlConnection con = new MySqlConnection(ConnectionString);
                //con.Open();
                //sqlstring = "select count(*) from login where user='" + comboBox1.Text.Trim() + "' and password='" + textBox1.Text.Trim() + "'"; //Trim() is to remove white spaces
                //comnd = new MySqlCommand(sqlstring, con);
                //mysqlda = new MySqlDataAdapter(comnd);
                //ds = new DataSet();
                //mysqlda.Fill(ds, "login");
                //long x;
                //x = Convert.ToInt64(comnd.ExecuteScalar());
                //if (x == 1)
                //{
                //    int y = 0;
                //    progressBar1.Visible = true;
                //    progressBar1.Minimum = 1;
                //    progressBar1.Maximum = 1000;
                //    progressBar1.Value = 1;
                //    progressBar1.Step = 1;
                //    for (y = 1; y <= 1000; y++)
                //    {
                //        progressBar1.PerformStep();
                //    }
                //    //this is code to open login form to main menu form
                //    Main menu = new Main();
                //    menu.Show();
                //    this.Hide();
                //    //----
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Password..! Try Again..!", "Invalid Login");
            //        textBox1.Text = "";
            //    }
            //    con.Close();
            }
            
        
        }

        private void timerLogin_Tick(object sender, EventArgs e)
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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

         


       

        }



    }

        



            
               