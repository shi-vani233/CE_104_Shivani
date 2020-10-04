using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab10.Models
{
    public class Product
    {
        [Key]
        public int P_ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
    }
}
