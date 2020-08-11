using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5_task2
{
    public class product
    {
        public product(String name,String category,Double price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public String name
        {
            get;
            set;
        }
        public String category
        {
            get;
            set;
        }
        public Double price
        {
            get;
            set;
        }
    }
}