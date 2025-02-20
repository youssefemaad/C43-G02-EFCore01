using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignement_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignement_1.DdContext
{
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext(): base()
        {
            
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        // public DbSet<Student_Course> Student_Courses { get; set; }
        // public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YOUSSEF\\SQLSERVER;Database=iti;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    // filepath: /d:/Youssef/Projects/Routes_Course/Entity Framwork/Ass_1/C43-G02-EFCore01/Assignement_1/Models/Department.cs
    // filepath: /d:/Youssef/Projects/Routes_Course/Entity Framwork/Ass_1/C43-G02-EFCore01/Assignement_1/Models/Department.cs




}