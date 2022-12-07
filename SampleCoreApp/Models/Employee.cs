//Members of a class in C# 11 allows to create them as nullable => These members will be initialized to null value if not set.All reference types could be set to nullable to avoid the warnings. 

namespace SampleCoreApp
{
    class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; } 
        public string? EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public override string ToString()
        {
            return $"The Name: {EmpName} from {EmpAddress} with Salary of {EmpSalary:C}";
        }

        ///<summary>
        ///Helper Function to copy the data of the other object into the Current object
        ///</summary> 
        public void DeepCopy(Employee other){
            this.EmpName = other.EmpName;
            this.EmpAddress = other.EmpAddress;
            this.EmpSalary =other.EmpSalary;
            this.DateOfBirth = other.DateOfBirth;
        }
    }
}