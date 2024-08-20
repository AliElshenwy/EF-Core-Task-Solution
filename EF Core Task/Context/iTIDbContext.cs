using EF_Core_Task.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task.Context
{
    internal class iTIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-722BKMG; Database = ITIRouteTack  ; Trusted_Connection = True ;Encrypt = False ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
              new Department { Id = 3, Name = "C++", HiringDate = new DateTime(2000, 1, 1) }
             );

            modelBuilder.Entity<Student>()
                   .HasOne(s => s.Departments)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<Course>()
                   .HasOne(c => c.Departments)
                   .WithMany(d => d.Courses)
                   .HasForeignKey(c => c.DepartmentID);
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.ins_ID, ci.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_Id, sc.Course_Id });

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course_Inst> course_Insts {  get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }


    }
}
