
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
/*
 * New Features of .NET Framework. 
 * - Using var keyword. 
 * - Using Lambda Expressions
 * - Using Extension methods.
 * - Using LINQ.
 * ASP.NET Core Environment
 * - What we can do in ASP.NET Core App.
 * - Understanding the appSettings.json file. 
 * - Adding middleware.
 * - Commonly used Middleware. 
 * ASP.NET MVC Application. 
 * Web API Development using .NET CORE.
 */


namespace DatabaseApp
{
    delegate void SampleFunc();
    delegate double MathFunc(double v1, double v2);


    static class MyExtensions
    {
        //Extension methods are static methods. Its first parameter will be a this operator followed by the class instance that U want to extend this method. It can be followed by 
        //Functions to be static. 
        public static int GetNoOfWords(this string arg)
        {
            var words = arg.Split(',', ' ', ';', '-');
            return words.Length;
        }
    }

    static class FunctionInvoker
    {
        public static void InvokeVoidFunc(SampleFunc func)
        {
            Console.WriteLine("Do some job....");
            func();//Calling the method that is passed as argument..
        }

        public static void ArithematicInvoke(Func<double, double, double> operation)
        {
            Console.WriteLine("Enter the First Value");
            var v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Value");
            var v2 = double.Parse(Console.ReadLine());

            var result = operation(v1, v2);
            Console.WriteLine($"The Result is {result}");
        }
        public static void MathFuncInvoker(MathFunc function)
        {
            Console.WriteLine("Enter the First Value");
            var v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Value");
            var v2 = double.Parse(Console.ReadLine());

            var result = function(v1, v2);
            Console.WriteLine($"The Result is {result}");
        }
    }
    internal class NewFeatures
    {
        static void Main(string[] args)
        {
            //usingVarKeyword();
            //FunctionInvoker.InvokeVoidFunc(usingDelegate);
            //FunctionInvoker.MathFuncInvoker(addOperation);
            //FunctionInvoker.MathFuncInvoker((v1, v2) => v1 + v2);
            //FunctionInvoker.ArithematicInvoke((d1, d2) => d1 * d2);

            usingExtenionMethods();
        }

        static void usingExtenionMethods()
        {
            var stringData = "Apple in the tree fell on the ground to know about gravity";
            int count = stringData.GetNoOfWords();
            
            Console.WriteLine("The total no is " + count);
        }
        static double addOperation(double v1, double v2)
        {
            return v1 + v2;
        }

        private static void usingDelegate()
        {
            /*
             * Delegate is a reference type in .NET that can be used to create reference variables to functions. 
             * Using delegate keyword we declare a delegate with a specific Method signature. 
             */
            Console.WriteLine("Testing the code by pasing this function as arg");
        }

        private static void usingVarKeyword()
        {
            //We use var to define local variables. It is convinient way of declaring the variables. 
            //U should assign the variable with a value before U move further. This assignment defines the data type of the var. 
            //It is implicit typed variable => This variable will hold the type based on the value U assign it  during declaration. Hense forth, it will follow the norms of the typical data type of .NET. 
            // var is convinient to be used in LINQ Expressions, Lamdba Expressions and Anonymous types which are all the new features introduced in .NET 3.0. 
            var data = 123;//Now data is int.
            data += 123;
            Console.WriteLine("The Current value: " + data);
        }
    }
}
