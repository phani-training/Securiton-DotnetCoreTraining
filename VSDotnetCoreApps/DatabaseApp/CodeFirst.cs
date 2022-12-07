using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    //Entity Class for the Tables:
    [Table("EmployeeTable")]
    public class Employee
    {
        public Employee()
        {
            EmpName = "";
            EmpAddress = "";
        }
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
    }

    //In EF, we need a connector to the database called Context Object. 
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        {

        }

        public DbSet<Employee> Employees { get; set; }//This is the Collection Object on which CRUD operations are performed. 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=SecuritonDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
