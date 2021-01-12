using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("tblorder")]
    public class order
    {
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    
        public int orderId{ get; set; }
        public string orderdesc{ get; set; }
        public int quantity { get; set; }
        public product product { get; set; }


    }
}

//new changes from local
