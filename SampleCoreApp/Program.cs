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
            creatingEmployeeHelper();
            return true;
        case 2:
            deleteEmployeeHelper();
            return true;
        case 3:
            System.Console.WriteLine("Not implemented in the current version");
            return true;
        case 4:
            findEmployeeHelper();
            return true;
        case 5:
            displayEmployeesHelper();
            return true;
        default:
            return false;
    }
}

void displayEmployeesHelper()
{
    var empList = repo.GetAllEmployees();
    foreach (var emp in empList) System.Console.WriteLine(emp);
}

void findEmployeeHelper()
{
    try
    {
        var no = Util.GetNumber("Enter the ID of the Employee to find");
        var emp = repo.GetEmployee(no);
        System.Console.WriteLine(emp);
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

void deleteEmployeeHelper()
{
    try
    {
        var no = Util.GetNumber("Enter the ID of the Employee to delete");
        repo.DeleteEmployee(no);
        System.Console.WriteLine("Employee Deleted Successfully");
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

void creatingEmployeeHelper()
{
    //var id = Util.GetNumber("Enter the ID of the Employee");
    var name = Util.GetString("Enter the Name");
    var address = Util.GetString("Enter the Address of the Employee");
    var salary = Util.GetDouble("Enter the salary of the Employee");
    var dob = Util.GetDate();
    var emp =  new Employee{
         EmpAddress = address,EmpName = name, EmpSalary = salary, DateOfBirth = dob   
    };
    repo.AddNewEmployee(emp);
    System.Console.WriteLine("Employee added successfully");
}