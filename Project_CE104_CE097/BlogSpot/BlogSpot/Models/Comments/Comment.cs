using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models.Comments
{
    public class Comment
    {
        public int Id { get; set; }
        public String Message { get; set; }
        public DateTime Created { get; set; }
    }
}
