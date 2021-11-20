using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ze_Clowns_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoopController : ControllerBase
    {
        //GET: api/<LoopController>
        [HttpGet("{firstName}")]
        //[Route("firstName")]

        public IEnumerable<Employee> Get(String firstName)
        {
            // 1. Create a List collection of employee
            // 2. Make API accept a string value
            // 3. Loop through collection and add the parameter to the firstName property
            // 4. Return the collection

            List<Employee> lstEmployees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Firstname = "David";
            employee1.Lastname = "Maslim";
            employee1.EmployeeID = 001;
            employee1.Address1 = "Jl. Singosari No. 9C";
            employee1.Address2 = "Medan - Sumut";
            lstEmployees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Firstname = "Franky";
            employee2.Lastname = "Maslim";
            employee2.EmployeeID = 002;
            employee2.Address1 = "Jl. Singosari No. 9C";
            employee2.Address2 = "Medan - Sumut";
            lstEmployees.Add(employee2);

            for (int i = 0; i < lstEmployees.Count; i++)
            {
                //lstEmployees[i].Firstname = lstEmployees[i].Firstname + firstName;
                lstEmployees[i].Firstname += " " + firstName;
            }

            return lstEmployees;

            //return new string[] { "value1", "value2" };


        }

        [HttpGet("{firstName}/{lastName}")]
        //[Route("lastName")]
        public List<Employee> Get(String lastName, String firstName)
        {
            // 1. Create a List collection of employee
            // 2. Make API accept a string value
            // 3. Loop through collection and replace the lastName property
            // 4. Return the collection

            List<Employee> lstEmployee = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Firstname = "David";
            employee1.Lastname = "test";
            employee1.EmployeeID = 001;
            lstEmployee.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Firstname = "Franky";
            employee2.Lastname = "test";
            employee2.EmployeeID = 002;
            lstEmployee.Add(employee2);

            for (int i = 0; i < lstEmployee.Count; i++)
            {
                lstEmployee[i].Lastname = lastName;
            }

            return lstEmployee;

        }
        // GET api/<LoopController>/5
       //// [HttpGet]
       // public string Get1(int id)
       // {
       //     return "value" + id.ToString();
       // }

        // POST api/<LoopController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoopController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoopController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
