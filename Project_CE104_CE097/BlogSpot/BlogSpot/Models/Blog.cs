using BlogSpot.Models.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models
{
    public class Blog
    {
        [Key]
        public int Blog_ID { get; set; }
        public string Title { get; set; } = "";
        public string body { get; set; } = "";
        public string Image { get; set; } = "";
        public string Category { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
        public List<MainComment> MainComments { get; set; }
    }
}
