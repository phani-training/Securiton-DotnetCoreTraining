using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class EmployeeVM
    {
        public EmployeeVM()
        {
            EmpName= string.Empty;
            EmpAddress= string.Empty;
        }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        public void Copy(Employee employee)
        {
            EmpName = employee.EmpName;
            EmpAddress = employee.EmpAddress;
            EmpSalary= employee.EmpSalary;
        }
    }
}
