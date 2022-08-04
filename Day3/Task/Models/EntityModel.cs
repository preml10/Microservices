using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


using System.ComponentModel.DataAnnotations;
namespace WebApplication12.Models
{
        
        public class Employee
        {
            [Key]
            public int Eid { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public float Salary { get; set; }
            public string Address { get; set; }
        }
        public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {

        }

    }
    
}
