﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.demo.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.demo.DAL.Data.Contexts
{
    internal class CompanyDpContext:DbContext
    {
        public CompanyDpContext() : base(){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= Shimaa123; Database = CompanyG04; Trusted_Connection= True ;TrustServerCertificate=True");
        }
        public DbSet<Department> Department { get; set; }   
    }
}
