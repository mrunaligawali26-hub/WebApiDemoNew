using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> str = new List<string> { "V1", "V2", "V3" };




        //list is for post and delete.
        //string[] str = {"V1","V2","V3" }; //--->For Get
        // GET api/values



        [HttpGet]
        public IEnumerable<string> Get()
        {

            // return new string[] { "value1", "value2","Value3","Value4" };
            return str;

        }



        [HttpGet]
        // GET api/values/5
        public string Get(int id)
        {
            // return str[id];
            return "value";
        }



        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            str.Add(value);

        }




        [HttpPut]
        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            str[id] = value;
        }



        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
            str.RemoveAt(id);
        }
    }
}

