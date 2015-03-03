using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class DoctorClass : PersonClass
    {
        private string docId;

        public string DocId
        {
            get { return docId; }
            set { docId = value; }
        }
        private string qualif;

        public string Qualif
        {
            get { return qualif; }
            set { qualif = value; }
        }
        private string speclty;

        public string Speclty
        {
            get { return speclty; }
            set { speclty = value; }
        }
        private int chnlfee;

        public int Chnlfee
        {
            get { return chnlfee; }
            set { chnlfee = value; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // to add to database
        public void addDoctor()
        {
            //execute sql and add
            ConnectDb condoc = new ConnectDb();
            condoc.openCon();   //call openCon method
            condoc.cmnd("INSERT INTO doctor(doc_id,F_Name,L_Name,Sex,NIC,Salary,DOB,Age,Qualification,Speciality,Channeling_Fee) VALUES(@docid,@fname,@lname,@sex,@nic,@sal,@dob,@age,@quali,@spe,@fee)");
            condoc.command.Parameters.AddWithValue("docid",docId);
            condoc.command.Parameters.AddWithValue("fname",Fname);
            condoc.command.Parameters.AddWithValue("lname",Lname);
            condoc.command.Parameters.AddWithValue("sex",Gender);
            condoc.command.Parameters.AddWithValue("nic", Nic);
            condoc.command.Parameters.AddWithValue("sal",salary);
            condoc.command.Parameters.AddWithValue("dob",Dob);
            condoc.command.Parameters.AddWithValue("age",Age);
             
            condoc.command.Parameters.AddWithValue("quali",qualif);   //variableto declare
            condoc.command.Parameters.AddWithValue("spe", speclty);     // first value should be the one in above values(@.....)
            condoc.command.Parameters.AddWithValue("fee", chnlfee);



            condoc.command.Connection = condoc.connDB;  //assing the connection to the command connection

            condoc.command.ExecuteNonQuery();   //to insert data we use this method
            condoc.closeCon();  //call closeCon method
        }

    }
}
