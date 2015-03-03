using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;   //Include this in every form to use mysql namespace

namespace Hospital_Management_System
{
    class ConnectDb
    {
        string conString;
        public MySqlConnection connDB;      //MySqlConnection is a inbuilt class
        public MySqlCommand command;
        public MySqlDataAdapter dAdapter;
        public MySqlDataReader dRead;
       
        


        public ConnectDb() //constructor    //start the connection
        {
            conString = "server=localhost;User Id=root;database=hospital_system";
            connDB = new MySqlConnection(conString);
        }
        // open connection
        //separate connect and cmnd here
        public void openCon()
        {
            connDB.Open();
            
        }

        public void cmnd(string sqlQry)     //execute sql commands
        {
            command = new MySqlCommand(sqlQry, connDB);
        }
        //this is to close connection
        public void closeCon()
        {
            if (connDB != null)
            {

                connDB.Close();
            }
        }
        //***
        public void setdAdapter(string query)   //get the data from DB
        {
            dAdapter = new MySqlDataAdapter(query, connDB);
        }


        public void finalize()  //this is used to remove the connection to database after program is off
        {
            connDB.Dispose();
        }
        //***
    }
}
