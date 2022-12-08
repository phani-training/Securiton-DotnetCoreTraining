using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    internal class LINQExample
    {
        static List<Employee>? employees = null;
        static LINQExample()
        {
            string jsonData = File.ReadAllText("../../../data.json");
            employees = JsonConvert.DeserializeObject<List<Employee>>(jsonData);
            if (employees == null)
            {
                return;
            }
        }
        static void Main(string[] args)
        {
            selectExample();            

        }

        private static void selectExample()
        {
            //query
           var results = from emp in employees
                         select emp.EmpName;//SElECT EMpName FROM employees
            //execution
            foreach (var res in results) { Console.WriteLine(res); }
        }
    }
}
