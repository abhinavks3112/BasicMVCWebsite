using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicMVCWebsite.Models
{
    public class Employee
    {  
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name="Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }

        [Range(22, 60)]
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