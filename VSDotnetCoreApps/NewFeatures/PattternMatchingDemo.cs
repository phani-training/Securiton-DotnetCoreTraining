using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pattern matching is used to test for certain valus and conditions. We used to use the switch and if claues for this purpose. With C# 11, we can achive this as expressions. 
//Makes the code more robust and easy to understand. 
//Null patterns, Const patterns, property patterns, Nagating Patterns, Type patterns are some of the pattern matchings we do in C# 9.0

/*
 * Now integers can have range and size compliant to the word size on the CPU architecture. This is helpful for interop services where the data will be 32 bit values. If the software is running on a 32 Bit platform, it will be 32 bit in size and range.  We can use new data types called nint for achieving this feature. 
nint is called as native integer. It behaves like int but takes the size basd on the CPU the App executes.  
 */
namespace NewFeatures
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public override string ToString()
        {
            return $"{EmpName} with ID {EmpId}";
        }
    }
    internal class PattternMatchingDemo
    {
        static void Main(string[] args)
        {
            //PatternMatching();
            nativeSizedIntegers();
        }

        private static void nativeSizedIntegers()
        {
            Console.WriteLine($"The size of int = {sizeof(int)}");
            unsafe
            {
                Console.WriteLine($"The size of nint = {sizeof(nint)}");
            }
        }

        private static void PatternMatching()
        {
            var emp = new Employee { EmpId = 0, EmpName = "Phaniraj" };
            if (emp.EmpId is 0)//Constant pattern...
            {
                Console.WriteLine($"{emp.EmpId} cannot have Zero");
            }

            var nullEmp = new Employee { EmpId = 1, EmpName = "TestName" };
            if (nullEmp.EmpName is not null)
            {
                Console.WriteLine("Shold not be null");
            }
            //Type pattern.
            if (emp is Employee temp)//If the nullEmp is of the type Employee, then create a new object called temp and set the values to it. 
            {
                Console.WriteLine("The Temp's Name is " + temp.EmpName);
            }
            //Property pattern...
            if (emp is { EmpId: <= 100 })
            {
                Console.WriteLine("He is same");

            }
            var text = emp is not null && emp is { EmpName: "Phaniraj" } ? "Welcome to Training" : "Welcome to Sessions";
            Console.WriteLine(text);

            var text1 = emp?.EmpName == "Phaniraj" ? "Welcome to Training" : "Welcome to Sessions";
        }
    }
}
