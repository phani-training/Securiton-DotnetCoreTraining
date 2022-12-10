using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C# allows to create declarations of functions pointers using delegate* syntax. 
//Sometimes, Classes need data that are passed by reference. These types can be created as Reference type fields sot that any change U make in the calling method on the object will be reflected on the reference  fields that U have set. 
//While creating these ref fields and return types, U should mark with ref keyword and associate with any object with ref keyword again.
//
namespace NewFeatures
{

    class RefClass
    {
        int[] data = { 12, 23, 45, 6, 78, 99, 7, 7 };
        public ref int GetNumber(int location)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= location)
                    return ref data[i];
            }
            return ref data[0];
        }

        public override string ToString() => string.Join(" ", data);
        
    }
    class TestClass
    {
        public int Code => getAllRecords();

        public static void MathFunc(int v1, int v2, ref int res1, ref int res2)
        {
            res1 = v1 + v2;
            res2 = v1 - v2;
        }
        private int getAllRecords() =>  123;
    }
    unsafe class SampleClass
    {
        public static void TestFunc(Action<int> action, delegate* <int, void> func)
        {
            action(123);
            func(32);
        }
    }
    unsafe internal class FunctionPointers
    {
        static void testFunc(int v)
        {
            Console.WriteLine("Test Func with v as "+ v);
        }

        public static ref Employee CreateEmployee(int id, string name)
        {
             Employee employee = new Employee {  EmpId = 123, EmpName= name };
            return ref employee; ;
        }
        static void Main(string[] args)
        {
            //delegate*<int, void> ptr2 = &FunctionPointers.testFunc;
            //SampleClass.TestFunc((i) => Console.WriteLine("THe value of I: " + i), ptr2);
            //int res1 = 0, res2 = 0;
            //TestClass.MathFunc(123, 234, ref res1, ref res2);
            //Console.WriteLine($"THe Added: {res1} and Subtracted: {res2}");

            //ref Employee emp = ref CreateEmployee(123, "SampleName");
            //Console.WriteLine("The Emp: " + emp);

            var data = new RefClass();
            Console.WriteLine($"The Original data: :{data.ToString()}");

            int number = 16;
            ref var result = ref data.GetNumber(number);
            result += 123;
           
            Console.WriteLine($"The New data: :{data.ToString()}");
        }
    }
}
