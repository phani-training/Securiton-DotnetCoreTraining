//using System.Data.SqlClient;
using Dapper;
using System.Data.SqlClient;

namespace SampleMvcCoreApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
    }

   public interface IEmployeeRepo
    {
        List<Employee> GetAll();
        Employee GetEmployee(int empId);
        void AddNewEmployee(Employee employee);
        void DeleteEmployee(int empId);
        void UpdateEmployee(Employee employee); 
    }

    public class EmployeeRepo : IEmployeeRepo
    {
        #region CONSTANTS
        const string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=SecuritonDB;Integrated Security=True;TrustServerCertificate=True";
        const string insertQuery = "Insert into EmployeeTable values(@name, @address, @salary)";
        const string deleteQuery = "Delete from EmployeeTable where EmpId = @id";
        const string updateQuery = "Update EmployeeTable Set EmpName = @name, EmpAddress = @address, EmpSalary = @salary where EmpId = @id";
        const string selectQuery = "select * from EmployeeTable";
        const string selectSingleEmployeeQuery = "select * from EmployeeTable where EmpId = @id";
        #endregion  
        public void AddNewEmployee(Employee employee)
        {
            using(var connection = new SqlConnection(strConnection))
            {
                connection.Open();
                connection.Execute(insertQuery, new { name = employee.EmpName, address = employee.EmpAddress, salary = employee.EmpSalary });
                connection.Close(); 
            }
        }

        public void DeleteEmployee(int empId)
        {
            using(var connection = new SqlConnection(strConnection))
            {
                connection.Open();
                connection.Execute(deleteQuery, new { id = empId });
                connection.Close(); 
            }
        }

        public List<Employee> GetAll()
        {
            using(var connection =new SqlConnection(strConnection))
            {
                connection.Open();
                var empList = connection.Query<Employee>(selectQuery);
                return empList.ToList();
            }
        }

        public Employee GetEmployee(int empId)
        {
            //selectSingleEmployeeQuery
            using (var connection = new SqlConnection(strConnection))
            {
                connection.Open();
                var employee = connection.QueryFirst<Employee>(selectSingleEmployeeQuery, new { id = empId });
                if (employee == null) throw new Exception("Failed to get the Employee");
                return employee;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var connection = new SqlConnection(strConnection))
            {
                connection.Open();
                connection.Execute(updateQuery, new { name = employee.EmpName, address = employee.EmpAddress, salary = employee.EmpSalary, id = employee.EmpId });
                connection.Close();
            }
        }
    }
}
