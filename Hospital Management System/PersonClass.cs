using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace Hospital_Management_System
{
    abstract class PersonClass
    {//inherited by child classes

        // make this abstract, 
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        //public DateTime dob;
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string address1;

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        private string address2;

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
       private string telnum;

       public string Telnum
       {
           get { return telnum; }
           set { telnum = value; }
       }
       private string mobnum;

       public string Mobnum
       {
           get { return mobnum; }
           set { mobnum = value; }
       }
        private string nic;

        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        

    }
}
