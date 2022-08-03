using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country_Details> ctList = new List<Country_Details>()
        { 
        
            new Country_Details() {id=1,Name="India",Capital="Delhi"},
            new Country_Details() {id=1,Name="Afganistan",Capital="Kabul"},
            new Country_Details() {id=1,Name="Pakistan",Capital="Karachi"},

        };

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(ctList);
        }

        public IHttpActionResult Get(int id)
        {
            Country_Details obj = ctList.Find(item => item.id == id);
            if(obj!=null)
            {
                return Ok(obj);
            }
            return NotFound();
        }

        [HttpPut]
        public IHttpActionResult Put (int id , [FromBody] Country_Details obj)
        {
            if(ctList[id-1]!=null)
            {
                ctList[id - 1] = obj;
                return Ok(obj);
            }
            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Country_Details obj)
        {
            ctList.Add(obj);
            return Ok(ctList);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Country_Details obj = ctList.Find(item => item.id == id);
            if (obj != null)
            {
                bool Isremoved = ctList.Remove(obj);
                if (Isremoved) return Ok(obj);
            }
            return NotFound();
        }
    }
}
