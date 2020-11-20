using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.ViewModels
{
    public class BlogViewModel
    {
        [Key]
        public int Blog_ID { get; set; }
        public string Title { get; set; } = "";
        public string body { get; set; } = "";
        public string Category { get; set; } = "";
        public IFormFile Image { get; set; } = null;
    }
}
