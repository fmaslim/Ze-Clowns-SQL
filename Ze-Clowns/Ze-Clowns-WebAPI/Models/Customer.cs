using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models
{
    public class Customer:AbstractCustomer
    {
        //Variables
        private String _firstname;
        private String _middlename;
        private String _lastname;
        private Int32 _customerID;
        private String _address1;
        private String _address2;
        private String _sex;
        private Boolean? _status;
        private Boolean? _active;

        //Properties
        public String Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
            }
        }

        public String Middlename
        {
            get { return _middlename; }
            set
            {
                _middlename = value;
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

        public Int32 CustomerID
        {
            get { return _customerID; }
            set
            {
                _customerID = value;
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
        public String Address2
        {
            get { return _address2; }
            set
            {
                _address2 = value;
            }
        }
        public String Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
            }
        }
        public Boolean? Status
        {
            get { return _status; }
            set
            {
                _status = value;
            }
        }
        public Boolean? Active
        {
            get { return _active; }
            set
            {
                _active = value;
            }
        }

        //Constructors

        public Customer()
        {
            Firstname = "Default Firstname";
            Middlename = "Default Middlename";
            Lastname = "Default Lastname";
            CustomerID = 0;
            Address1 = "Default Address1";
            Address2 = "Default Address2";
        }

        public Customer(String firstname, String lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        
        public Customer(String firstname, String middlename, String lastname, String address1, String address2)
        {
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Address1 = address1;
            Address2 = address2;
        }

        //Method Override
        public override double GetDiscount()
        {
            throw new NotImplementedException("This is not done");
        }

        public override string GetShipping()
        {
            return "2-day shipping";
        }
    }

}
