using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models
{
    public class Employee
    {
        //Variables
        private String  _firstname;
        private String  _lastname;
        private String  _address1;
        private String  _address2;
        private Int32   _employeeID;

        //Properties
        public String Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
            }
        }

        public String Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
            }
        }

        public String Address1
        {
            get { return _address1; }
            set
            {
                _address1 = value;
            }
        }

        public String Address2 {get;set;}

        public Int32  EmployeeID { get; set; }

        //Constructors
        public Employee()
        {

            Firstname = "Default FirstName";
            Lastname = "Default Lastname";
            Address1 = "Default Address1";
            Address2 = "Default Address 2";
            EmployeeID = 12345;
        }

        //Constructor Overloading
        public Employee(String firstname, String lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Employee(String firstname, String lastname, String address1, String address2, Int32 employeeID)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address1 = address1;
            Address2 = address2;
            EmployeeID = employeeID;
        }


        //Methods

        public String GetFullname()
        {

            //Return Firstname Lastname
            String fullname = Firstname + " " + Lastname;

            return fullname;
        }

        public String GetFullname(String firstname, String lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
            String fullname = Firstname + " " + Lastname;

            return fullname;
        }

    }


}
