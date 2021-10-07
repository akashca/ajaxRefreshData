using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudUsingAjax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudUsingAjax.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organisation> Organisation { get; set; }
    }
}

