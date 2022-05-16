using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<StudentEntityModel> Students { get; set; }

        public DbSet<SubjectEntityModel> Subjects { get; set; }

        public DbSet<ClassEntityModel> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolContext;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
