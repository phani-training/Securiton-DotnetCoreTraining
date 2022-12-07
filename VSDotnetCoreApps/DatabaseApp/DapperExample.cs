using System;
using Dapper;
using Microsoft.Data.SqlClient;
/*
* Dapper is a framework with Extension methods for IDBConnection interface to perform CRUD Operations on the databases in light weight manner. Unlike EF or any other ORMs, U dont need a heavy infra. 
* It cannot be used for CODE-FIRST Approach. 
*/
namespace DatabaseApp
{
    class RepoClass
    {
        const string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=SecuritonDB;Integrated Security=True;TrustServerCertificate=True";
        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>(); 
            using(var connection = new SqlConnection(strConnection))
            {
                connection.Open();
                list = connection.Query<Employee>("Select * from EmployeeTable").ToList();
                connection.Close();
            }
            return list;
        }

        public void UpdateEmployee(int id, Employee employee)
        {

        }
        public void AddNewEmployee(Employee employee)
        {
            using(var con = new SqlConnection(strConnection)) 
            {
                con.Open();
                var rowsAffected = con.Execute("Insert into EmployeeTable values(@name, @address, @salary)", new { name = employee.EmpName, address = employee.EmpAddress, salary = employee.EmpSalary });
                if(rowsAffected == 1)
                {
                    Console.WriteLine("Inserted Successfully");
                }
            }
        }   
        public Employee GetEmployeeById(int id) 
        {
            using(var connection = new SqlConnection(strConnection)) 
            {
                connection.Open();
                Employee rec = connection.QueryFirst<Employee>("SELECT * FROM EMPLOYEETABLE WHERE EMPID  = @id", new { id = id });
                return rec;
            }
        }
    }
    internal class DapperExample
    {
        static void Main(string[] args)
        {
            var repo = new RepoClass();
            repo.AddNewEmployee(new Employee { EmpName = "TestName", EmpSalary = 56000, EmpAddress = "TestAddress" });
            //var rec = repo.GetEmployeeById(1);
            //Console.WriteLine(rec.EmpName);
            var list = repo.GetAllEmployees();
            foreach (var emp in list)
            {
                Console.WriteLine(emp.EmpName);
            }
        }
    }
}
/*
 * Implement the IEmployeeRepo interface using Dapper and use the class in the Menu Driven Main program. 
 */