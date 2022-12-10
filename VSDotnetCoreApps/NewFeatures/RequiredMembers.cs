using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//required makes the caller forcefully set the values at the initialization level. 
//Use required with init setters. 
//rquired cannot be used for static property or field as they created assigned at object initialization scope. 
//cannot be applied on private members as they are invisble to the caller
//it cannot be applied to readonly members. 
namespace NewFeatures
{
    class Customer
    {
        public required int CustomerID { get; init; }

        public string? CustomerName { get; set; }
    }
    internal class RequiredMembersExample
    {
        int val = 123;
        static void Main(string[] args)
        {
            //usingRequiredMembers();
            //usingStringLiterals();
            var comp = new RequiredMembersExample();
            comp.staticAnonymousFunctions();
        }

        private static void InvokeFunc(Action<int> action)
        {
            Console.WriteLine("Enter the value");
            int value = int.Parse(Console.ReadLine());
            action(value);
        }
        private void staticAnonymousFunctions()
        {
            InvokeFunc((val) =>
            {
                val += 123;
                Console.WriteLine("The value passed by the source is " + val);
            });
            Console.WriteLine(val);
            InvokeFunc(static val =>
            {
                Console.WriteLine("The Value passed is " + val);
            });
    }


        private static void usingStringLiterals()
        {
            string data = "Some Text";
            string newLiteral = $$"""
                This content will display 
                with \n and other 
                \t and 
                {{{data}}}
                """;
            Console.WriteLine($"The Value of {nameof(newLiteral)} is {newLiteral}");
        }

        private static void usingRequiredMembers()
        {
            var cst = new Customer() { CustomerID = 123, CustomerName = "Test Name" };
            cst.CustomerName = "Changed value";
            Console.WriteLine(cst);
        }
    }
}
