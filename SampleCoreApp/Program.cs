// See https://aka.ms/new-console-template for more information
using SampleCoreApp;
using System;

// Console.WriteLine("Hello, World!");

// Console.WriteLine("Testing the new piece of code");
// createInstanceExample();

// void createInstanceExample(){
//     var obj = new Employee{ EmpId = 1, EmpName = "Phaniraj", EmpAddress="Bangalore", EmpSalary = 65000, DateOfBirth = DateTime.Parse("01/12/1976") };
//     Console.WriteLine(obj);
// }
string file = "Menu.txt";
IEmployeeRepo repo = new EmployeeRepo();
string menu = File.ReadAllText(file);
var processing = true;
do
{
    System.Console.WriteLine(menu);
    int choice = Convert.ToInt32(Console.ReadLine());
    processing = processMenu(choice);
} while (processing);

bool processMenu(int choice)
{
    switch (choice)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            return true;
        default:
            return false;
    }
}