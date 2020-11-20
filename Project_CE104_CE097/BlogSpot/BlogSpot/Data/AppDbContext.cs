using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogSpot.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BlogSpot.Models.Comments;

namespace BlogSpot.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
    }
}
