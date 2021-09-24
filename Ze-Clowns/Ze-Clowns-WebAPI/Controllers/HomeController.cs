using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    public class HomeController : ControllerBase
    {/**/
        // GET: api/<HomeController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Anonymous object
                //var message = new { Message = "Default Parameterless API method" };
                var emp = new Employee();
                emp.Firstname = "Lanhut";
                emp.Lastname = "Simatupang";
                emp.Address1 = "Jl. Singosari 9C";
                emp.Address2 = "Medan - SUMUT";
                emp.EmployeeID = 12345;

                return Ok(emp);
            }
            catch(Exception ex)
            {
                return BadRequest("Lancau error");
            }
        }

        // http://localhost:12345/api/Home?id=5&firstName=John&lastName=Doe
        // http://localhost:12345/api/Home/5/John/Doe
        // public string Get([FromQuery] string id, string firstName, string lastName)
        // GET api/<HomeController>/5
        [HttpGet]
        [Route("WithParam")]
        // http://localhost:12345/api/Home/WithParam?id=5
        public string Get([FromQuery] string id)
        {
            return "lancau lancau: " + id;
        }

        // JSON Serialization: from object to string
        // JSON De-Serialization: from string to object

        // Refactoring
        // http://localhost:12345/api/home/david/maslim\
        // http://localhost:12345/api/employee/5
        [HttpGet("{firstName}/{lastName}")]
        public string Get(string firstName, string lastName)
        {
            //return "Name: " + firstName + " " + lastName;
            //return Ok("Name: " + firstName + " " + lastName);

            Employee emp = new Employee();
            emp.Firstname = firstName;
            emp.Lastname = lastName;
            Employee obj = JsonConvert.DeserializeObject<Employee>("{\"FirstName\": \"David\"}");
            // TODO
            return JsonConvert.SerializeObject(emp);
        }

        // POST api/<HomeController>
        [HttpPost]
        public string Post([FromBody]Employee employee) // auto-mapping
        {
            return "Post - Name: " + employee.Firstname + " " + employee.Lastname;
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
