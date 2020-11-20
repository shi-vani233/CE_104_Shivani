using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public int BlogId { get; set; }
        [Required]
        public int MainCommentId { get; set; }
        [Required]
        public string Message { get; set; }
    }
}