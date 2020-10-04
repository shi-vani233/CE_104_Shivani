using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab10.Models
{
    public class Customer
    {
        [Key]
        public int Cust_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long MobileNO { get; set; }
    }
}
