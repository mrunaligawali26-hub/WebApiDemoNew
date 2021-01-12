using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class DBdataController : ApiController
    {
        ProjectContexclst P = new ProjectContexclst();
        [HttpGet]
            public IEnumerable<product>Get()
        {
            return P.products.ToList();
        }
        [HttpGet]
        public product Get(int Id)
        {
            return P.products.FirstOrDefault(x =>x.productid == Id);

        }
        [HttpPost]
        public string Post([FromBody]product products)
        {
            P.products.Add(products);
            P.SaveChanges();
            return "1 row inserted";
        }
        [HttpPut]
        public string Put(int id,[FromBody]product products)
        {
            //the below line is same as select *from product where productid=1
            var prod = P.products.FirstOrDefault(x => x.productid == id);
            prod.productname = products.productname;
            prod.price = products.price;
            P.SaveChanges();
            return "updated";
        }
        [HttpDelete]
        public string Delete(int id)
        {
            var prod = P.products.FirstOrDefault(x => x.productid == id);
            P.products.Remove(prod);
            P.SaveChanges();
            return "1 row deleted";
        }
            
    }
}
