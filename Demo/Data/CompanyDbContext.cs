using Demo.Data.Models;
using EFCSession02FluentAPIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class CompanyDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

           => optionsBuilder.UseSqlServer("Server=.;Database=CompanyG02;Trusted_Connection=True;trustservercertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        //=> modelBuilder.Entity<Employee>()
        //        .Property<string>("Address")
        //        .HasColumnType("varchar")
        //        .HasMaxLength(50)
        //        .IsRequired();

        {
            modelBuilder.Entity<Department>()
                       .HasKey(d => d.DeptId);
            modelBuilder.Entity<Department>()
                .Property(p => p.DeptId).UseIdentityColumn(10, 10);
            modelBuilder.Entity<Department>()
                .Property(D => D.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .IsRequired();
            modelBuilder.Entity<Department>()
                .Property(D => D.CreationDate)
                .HasDefaultValueSql("getdate()");


        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}

