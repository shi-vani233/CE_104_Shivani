using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab10.Models
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }
        public int Cust_ID { get; set; }
        public int P_ID { get; set; }
        public double Amount { get; set; }
        public DateTime Order_DateTime { get; set; }
        public Product product { get; set; }
        public Customer customer { get; set; }
    }
}
