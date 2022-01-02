using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ze_Clowns_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanResourcesController : ControllerBase
    {
        // GET: api/<HumanResources>
        [HttpGet]
        [Route("Departments")]
        public IEnumerable<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            String connectionString = @"Server=LAPTOP-ML140T5S\SQLEXPRESS;Database=AdventureWorks2019;Trusted_Connection=True";

            //1. Create SQL connection object
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                //2. Create SQL Command Object
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select top 10 * from HumanResources.Department";
                command.CommandType = System.Data.CommandType.Text;

                //3. Open Connection
                command.Connection.Open();

                //4. Read using SQLDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //5. Check if reader has data
                    if (reader.HasRows)
                    {
                        //6. Loop thru data
                        while(reader.Read())
                        {
                            //7. Create new object
                            Department department = new Department();
                            department.DepartmentID = (Int16)reader[DepartmentEnum.DepartmentID.ToString()];
                            department.Name = reader[DepartmentEnum.Name.ToString()].ToString();
                            department.GroupName = reader[DepartmentEnum.GroupName.ToString()].ToString();
                            department.ModifiedDate = (DateTime)reader[DepartmentEnum.ModifiedDate.ToString()];

                            //8.Add to Collection
                            departments.Add(department);
                        }
                    }
                }

                //9. return Collection
                return departments;


            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                
                connection.Close();
                
            }
        }

        // GET api/<HumanResources>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HumanResources>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HumanResources>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HumanResources>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
