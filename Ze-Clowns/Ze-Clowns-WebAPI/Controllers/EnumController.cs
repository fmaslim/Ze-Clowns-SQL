
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models;
using Ze_Clowns_WebAPI.Models.Enums;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ze_Clowns_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        // GET: api/<EnumController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> lstEmployees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Firstname = "David";
            employee1.Lastname = "Maslim";
            employee1.EmployeeID = 001;
            employee1.Address1 = "Jl. Singosari No. 9C";
            employee1.Address2 = "Medan - Sumut";
            employee1.EmployeeType = (int)EmployeeType.CEO;
            employee1.EmployeeTypeString = EmployeeType.CEO.ToString();
            lstEmployees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Firstname = "Franky";
            employee2.Lastname = "Maslim";
            employee2.EmployeeID = 002;
            employee2.Address1 = "Jl. Singosari No. 9C";
            employee2.Address2 = "Medan - Sumut";
            employee2.EmployeeType = (int)EmployeeType.CIO;
            employee2.EmployeeTypeString = EmployeeType.CIO.ToString();
            lstEmployees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.Firstname = "Andrew";
            employee3.Lastname = "Maslim";
            employee3.EmployeeID = 003;
            employee3.Address1 = "Jl. Singosari No. 9C";
            employee3.Address2 = "Medan - Sumut";
            employee3.EmployeeType = (int)EmployeeType.Director;
            employee3.EmployeeTypeString = EmployeeType.Director.ToString();
            lstEmployees.Add(employee3);

            return lstEmployees;

        }

        // GET api/<EnumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnumController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EnumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
