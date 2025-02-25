using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-VE3NF6U\\SQLEXPRESS;Database=CSharp;Integrated Security=True;TrustServerCertificate=True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseStudent>()
                .HasKey((x) => new { x.StudentId, x.CourseId });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasIndex(x => x.Name);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
