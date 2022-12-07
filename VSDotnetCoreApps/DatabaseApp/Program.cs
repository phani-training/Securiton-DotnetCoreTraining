//Connect to the database using Code First Approach and build the Application. 
namespace DatabaseApp
{
    internal class Program
    {

        static void addEmployeeExample(string name, string address, double salary)
        {
            //create the DBContext instance
            var context = new EmployeeDBContext();
            //create the Employee object
            var emp = new Employee { EmpName = name, EmpAddress= address, EmpSalary = salary }; 
            //add the Employee to the Contextt collection
            context.Employees.Add(emp);
            //update the database
            context.SaveChanges();
        }

        static void displayAll()
        {
            var context = new EmployeeDBContext();
            var records = context.Employees.ToList();
            foreach (var emp in records) { Console.WriteLine(emp.EmpName); }
        }

        static void updateRec(int id, string name, string address, double salary)
        {
            var context = new EmployeeDBContext();
            var rec = context.Employees.Find(id);
            if (rec != null)
            {
                rec.EmpName = name;
                rec.EmpAddress = address;
                rec.EmpSalary = salary;
            }
            else
            {
                Console.WriteLine("No record found to update");
            }
            context.SaveChanges();
        }
        static void deleteRec(int id)
        {
            var context = new EmployeeDBContext();
            var rec = context.Employees.Find(id);
            if (rec != null)
                context.Employees.Remove(rec);
            context.SaveChanges();
        }
        static void Main(string[] args)
        {
            //updateRec(1, "Phaniraj B.N.", "Bengaluru", 60000);
            //addEmployeeExample("Rajesh", "Noida", 65000);
            displayAll();
        }
    }
}