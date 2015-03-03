using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class Nurseclass : PersonClass
    {
        private string NurseId;

        public string NurseId1
        {
            get { return NurseId; }
            set { NurseId = value; }
        }
        private string qualif;

        public string Qualif
        {
            get { return qualif; }
            set { qualif = value; }
        }
        private string shift;

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        private string salary;

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        

        //code to add nurse to database
        public void addNurse()
        {
            //execute sql and add
            ConnectDb connurse = new ConnectDb();
            connurse.openCon(); //call openCon method
            connurse.cmnd("INSERT INTO nurse(F_Name,L_Name,sex,Nurse_Id,Salary,DOB,Quli,Shift) VALUES(@fn,@ln,@sex,@nid,@sal,@dob,@quli,@shif)"); //here add all the database nurse fields and then all the values for the variables
            //we use this cmnd method and pass this insert statemtn as sql query
            connurse.command.Parameters.AddWithValue("fn", Fname);
            connurse.command.Parameters.AddWithValue("ln", Lname);
            connurse.command.Parameters.AddWithValue("sex", Gender);
                    
            connurse.command.Parameters.AddWithValue("nid", NurseId);
            connurse.command.Parameters.AddWithValue("sal", salary);
            connurse.command.Parameters.AddWithValue("dob", Dob);
            connurse.command.Parameters.AddWithValue("quli", qualif);
           
            connurse.command.Parameters.AddWithValue("shif", shift);

            connurse.command.Connection = connurse.connDB;  //assing the connection to the command connection
            connurse.command.ExecuteNonQuery(); //to insert data we use this method
            connurse.closeCon();    //call closeCon method

        }
    }
}