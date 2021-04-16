using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicMVCWebsite.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext()
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}