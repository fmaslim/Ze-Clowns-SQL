using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ze_Clowns_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        // GET: api/<CollectionController>
        [HttpGet]
        public IEnumerable<int> Get()
        {
            int[] emptyArrray = new int[5];
            emptyArrray[0] = 1;
            emptyArrray[1] = 2;
            emptyArrray[2] = 3;
            emptyArrray[3] = 4;
            emptyArrray[4] = 5;

            //return emptyArrray;

            string[] populatedArray = { "David", "Franky", "Andrew" };
            //return populatedArray;

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);   
            numbers.Add(3);
            numbers.Add(4);

            return numbers;
        }

        // GET api/<CollectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollectionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CollectionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
