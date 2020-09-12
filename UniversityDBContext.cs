using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShakilUniversity
{
    class UniversityDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O84LAFN;Database=ShakilUniversity;Trusted_Connection=True;");
        }

        public DbSet<FullTimeStudent> FullTimeStudents { get; set; }
        public DbSet<UnderGradStudent> UnderGradStudents { get; set; }
    }
}
