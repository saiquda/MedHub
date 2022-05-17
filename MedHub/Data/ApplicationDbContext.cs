using MedHub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Quiz> Quizzes{ get; set; }
        public DbSet<Answer> Answers{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
