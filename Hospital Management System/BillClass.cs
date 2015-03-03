using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    public class BillClass
    {
        private string patID;

        public string PatID
        {
            get { return patID; }
            set { patID = value; }
        }
        public static int channel = 1500;

        public int Channel
        {
            get { return channel; }
            set { channel = value; }
        }
        private int rate = 500;  //right click> refactor> encapsulate field>OK

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private DateTime daysAdmit;

        public DateTime DaysAdmit
        {
            get { return daysAdmit; }
            set { daysAdmit = value; }
        }
        private DateTime daysDisch;

        public DateTime DaysDisch
        {
            get { return daysDisch; }
            set { daysDisch = value; }
        }
        private String ward;

        public String Ward
        {
            get { return ward; }
            set { ward = value; }
        }
        private String room;

        public String Room
        {
            get { return room; }
            set { room = value; }
        }
        private int billTot;

        public int BillTot
        {
            get { return billTot; }
            set { billTot = value; }
        }
        private int charge;

        public int Charge
        {
            get { return charge; }
            set { charge = value; }
        }
        

        
        public int calcCharge()
        {
            int daysStay = daysDisch.Date.Day - daysAdmit.Date.Day;
            return (rate * daysStay);

        }

        //this method is to add the bill to database
        public void addBill()
        {
            //execute sql and add
            ConnectDb conPat = new ConnectDb();

            conPat.openCon();   //call openCon method
            //we use this cmnd method and pass this insert statemtn as sql query
            conPat.cmnd("INSERT INTO bill(dateadmited,datedis,ward,room,total) VALUES(@da,@dd,@ward,@room,@total)");
            //conPat.command.Parameters.AddWithValue("pi", patID);
            conPat.command.Parameters.AddWithValue("da", daysAdmit);
            conPat.command.Parameters.AddWithValue("dd", daysDisch);
            conPat.command.Parameters.AddWithValue("ward", ward);
            conPat.command.Parameters.AddWithValue("room", room);
        
            conPat.command.Parameters.AddWithValue("total", billTot);





            conPat.command.Connection = conPat.connDB;  //assing the connection to the command connection

            conPat.command.ExecuteNonQuery();   //to insert data we use this method
            conPat.closeCon();  //call closeCon method

        }


    }
}
