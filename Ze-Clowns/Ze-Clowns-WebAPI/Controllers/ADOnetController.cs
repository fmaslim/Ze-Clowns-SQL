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
    public class ADOnetController : ControllerBase
    {
        // GET: api/<ADOnetController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> people = new List<Person>();


            String connectionString = @"Server=LAPTOP-ML140T5S\SQLEXPRESS;Database=AdventureWorks2019;Trusted_Connection=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select top 10 * from person.person";
                command.CommandType = System.Data.CommandType.Text;

                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.BusinessEntityID = (int)reader[PersonEnum.BusinessEntityID.ToString()];
                            person.PersonType = reader["PersonType"].ToString();
                            person.NameStyle = (Boolean)reader["NameStyle"];
                            person.Title = reader["Title"].ToString();
                            person.FirstName = reader["FirstName"].ToString();
                            person.MiddleName = reader["MiddleName"].ToString();
                            person.LastName = reader["LastName"].ToString();
                            person.Suffix = reader["Suffix"].ToString();
                            person.EmailPromotion = (int)reader["EmailPromotion"];
                            person.AdditionalContactInfo = reader[PersonEnum.AdditionalContactInfo.ToString()].ToString();
                            person.Demographics = reader[PersonEnum.Demographics.ToString()].ToString();
                            person.Rowguid = new Guid(reader[PersonEnum.Rowguid.ToString()].ToString());
                            person.ModifiedDate = (DateTime)reader[PersonEnum.ModifiedDate.ToString()];

                            person.FullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                            person.BusinessEntityType = ((int)reader[PersonEnum.BusinessEntityID.ToString()]).ToString() + ". " + PersonEnum.BusinessEntityID.ToString();

                            people.Add(person);

                        }
                    }
                }

                // ICollection<person> collection = new LIst<Person>();

                // Lambda expression
                List<Person> filteredPeople = people.Where(a => a.BusinessEntityID <= 5).ToList();
                return filteredPeople;


            }
            catch (Exception ex)
            {
                int i = 0;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private Boolean FilterPerson(Person obj)
        {
            return obj.BusinessEntityID <= 5;
        }

        private Boolean FilterPersonB(Person a) => a.BusinessEntityID <= 5;

        // GET api/<ADOnetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ADOnetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ADOnetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ADOnetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
