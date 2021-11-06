using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ze_Clowns_WebAPI.Models;

namespace Ze_Clowns_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultConstructorTest()
        {
            Employee employee = new Employee();

            const string ExpectedFirstname = "David";
            Assert.AreEqual(ExpectedFirstname, employee.Firstname);

            const string ExpectedLastname = "Maslim";
            Assert.AreEqual(ExpectedLastname, employee.Lastname);

            const string ExpectedAddress1 = "Jl. Singosari No. 9C";
            Assert.AreEqual(ExpectedAddress1, employee.Address1);

            const string ExpectedAddress2 = "Medan - Sumut";
            Assert.AreEqual(ExpectedAddress2, employee.Address2);

            const Int32 ExpectedEmployeeID = 12345;
            Assert.AreEqual(ExpectedEmployeeID, employee.EmployeeID);
        }

        [TestMethod]
        public void Overloaded_Firstname_Lastname_ConstructorTest()
        {
            Employee employee = new Employee("ABC","DEF");

            const string ExpectedFirstname = "ABC";
            Assert.AreEqual(ExpectedFirstname, employee.Firstname);

            const string ExpectedLastname = "DEF";
            Assert.AreEqual(ExpectedLastname, employee.Lastname);
        }

        [TestMethod]
        public void Overloaded_All_Constructor_Test()
        {
            Employee employee = new Employee("XYZ", "UVW", "123 Victory St", "Atlanta, Ga 30000", 00000);
            
            const string ExpectedFirstname = "XYZ";
            Assert.AreEqual(ExpectedFirstname, employee.Firstname);

            const string ExpectedLastname = "UVW";
            Assert.AreEqual(ExpectedLastname, employee.Lastname);

            const string ExpectedAddress1 = "123 Victory St";
            Assert.AreEqual(ExpectedAddress1, employee.Address1);

            const string ExpectedAddress2 = "Atlanta, Ga 30000";
            Assert.AreEqual(ExpectedAddress2, employee.Address2);

            const Int32 ExpectedEmployeeID = 00000;
            Assert.AreEqual(ExpectedEmployeeID, employee.EmployeeID);

        }
    }
}
