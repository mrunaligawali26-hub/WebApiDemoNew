using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("tblproduct")]
    public class product
    {
        [Key]
        public int productid { get; set; }
        public string productname { get; set; }
        public int price{ get; set; }

    }
}