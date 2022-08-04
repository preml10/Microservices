using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
       // [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

       // public IEnumerable<Customer> Get()
        
            public List<Customer> ctlist = new List<Customer>() 
            {
                new Customer() {CustomerId=1,CustomerNo=12345678,CustomerName="Ashish",Adress="Pune"},
                new Customer() {CustomerId=2,CustomerNo=87654321,CustomerName="Sam",Adress="Nagpur"}
            };

            //return ctlist;

            
        // GET api/<CustomerController>/5
        [HttpGet]
        public List<Customer> Get()
        {
            return ctlist;

        }

        // POST api/<CustomerController>
        [HttpPost]
       // public void Post([FromBody] string value)
        //{
        //}
        public List<Customer> Post([FromBody]Customer obj)
        {
            ctlist.Add(obj);
            return ctlist;
                       
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}
        public List<Customer> Put(int id,[FromBody]Customer obj)
        {
            var objDelete = ctlist.Find(item => item.CustomerId == id);
            ctlist.Remove(objDelete);
            ctlist.Add(obj);
            return ctlist;
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
