using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models.Enums;

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
        private Int32? _employeeType;
        private String _employeeTypeString;
        private EmployeeType? _employeeTypeTest;

        //Properties
        public String Firstname
        {
            get { return _firstname; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("FirstName cannot be longer than 10 characters");
                }
                _firstname = value;
            }
        }

        [Required]
        [MaxLength(10, ErrorMessage = "Last Name cannot be longer 10 characters")]
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

        [Required]
        public string Address2 { get; set; }

        public Int32  EmployeeID { get; set; }

        public Int32? EmployeeType 
        {
            get { return _employeeType; }
            set
            {
                _employeeType = value;
            }
        }

        public String EmployeeTypeString
        {
            get { return _employeeTypeString; }
            set
            {
                _employeeTypeString = value;
            }
        }

        //Constructors
        public Employee()
        {

            Firstname = "Default FirstName";
            Lastname = "Default Lastname";
            Address1 = "Default Address 1";
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

    public interface IAnimal
    {
        void MakeSound();
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.Write("Woof");
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.Write("Meow");
        }
    }

    public class Main
    {
        public Main()
        {

        }

        public Main(IAnimal animal)
        {

        }

        public void DoSomething()
        {
            IAnimal animal = new Dog();
            IAnimal animal2 = new Cat();

            animal.MakeSound();
        }

        public void DoStuff(IAnimal animal)
        {
            animal.MakeSound();
        }
    }

    public class Foo
    {
        public void CalculateStuff()
        {
            Main obj = new Main();

            IAnimal dog = new Dog();
            obj.DoStuff(dog);

            IAnimal cat = new Cat();
            obj.DoStuff(cat);
        }
    }

    public interface IPerson
    {
        void CalculateSalary();
    }

    public class Male : IPerson
    {
        public void CalculateSalary()
        {
            Console.Write("100,000");
        }
    }

    public class Female : IPerson
    {
        public void CalculateSalary()
        {
            Console.Write("90,000");
        }
    }
}
