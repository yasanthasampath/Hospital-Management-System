using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class PatientClass : PersonClass //Inheritance 
    {
        private string patID;

        public string PatID
        {
            get { return patID; }
            set { patID = value; }
        }

        private string dateAdmit;

        public string DateAdmit
        {
            get { return dateAdmit; }
            set { dateAdmit = value; }
        }
        private string dateDisch;

        public string DateDisch
        {
            get { return dateDisch; }
            set { dateDisch = value; }
        }


        private string weight;

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string maritial;

        public string Maritial
        {
            get { return maritial; }
            set { maritial = value; }
        }
        private string bgroup;

        public string Bgroup
        {
            get { return bgroup; }
            set { bgroup = value; }
        }
        private string Country;

        public string Country1
        {
            get { return Country; }
            set { Country = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
       
       
      //here we can add only the special attributes, common always come in person class
        //this is why we draw the class diagram so it make it easier to come up with classes
         

        public void addPatient()
        {
            //execute sql and add
            ConnectDb conPat = new ConnectDb();
           //adding comment
            //123223
           conPat.openCon();    //call openCon method
            //we use this cmnd method and pass this insert statemtn as sql query
            conPat.cmnd("INSERT INTO patients(Pat_ID,F_Name,L_Name,Date_Adm,Date_Dis,NIC,Gender,DOB,Blood_Grp,Weight,Marital,Add1,Add2,Nationality,State,Tel_Num,Mob_Num) VALUES(@pi,@fn,@ln,@da,@dd,@nic,@gn,@db,@bg,@wei,@mar,@add1,@add2,@ctr,@stat,@tel,@mob)");
            conPat.command.Parameters.AddWithValue("pi", patID);
            conPat.command.Parameters.AddWithValue("fn", Fname);
            conPat.command.Parameters.AddWithValue("ln", Lname);
            conPat.command.Parameters.AddWithValue("da", dateAdmit);
            conPat.command.Parameters.AddWithValue("dd", dateDisch);
            conPat.command.Parameters.AddWithValue("nic", Nic);
            conPat.command.Parameters.AddWithValue("gn", Gender);
            conPat.command.Parameters.AddWithValue("db", Dob);
            conPat.command.Parameters.AddWithValue("bg", bgroup);
        
            conPat.command.Parameters.AddWithValue("wei", weight);
            conPat.command.Parameters.AddWithValue("mar", maritial);
            
            conPat.command.Parameters.AddWithValue("add1",Address1 );
            conPat.command.Parameters.AddWithValue("add2", Address2);
            conPat.command.Parameters.AddWithValue("tel", Telnum);
            conPat.command.Parameters.AddWithValue("mob", Mobnum);

            conPat.command.Parameters.AddWithValue("ctr", Country);
            conPat.command.Parameters.AddWithValue("stat", state);

            //The save code is not working because country and state you have to make 2 more fields in database table and put it in insert statement along with parameter.addwith value


            conPat.command.Connection = conPat.connDB; //assing the connection to the command connection
            
            conPat.command.ExecuteNonQuery(); //to insert data we use this method
            conPat.closeCon();  //call closeCon method
        }
        

    }
}
