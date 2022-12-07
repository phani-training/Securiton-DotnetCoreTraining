//Repository Pattern allows the programmers to encapsulate the Persistance layer of the Application and expose APIs for the users to interact. 
using SampleCoreApp;
//It is a good design pattern to create an interface and implement a class for that interface and expose the interface object. Dont expose the implementor class.
interface IEmployeeRepo
{
    List<Employee> GetAllEmployees();
    Employee GetEmployee(int id);
    void AddNewEmployee(Employee emp);
    void DeleteEmployee(int id);
    void UpdateEmployee(int id, Employee updatedEmp);
}

class EmployeeRepo : IEmployeeRepo
{
    private List<Employee> _empList = new List<Employee>();
    public void AddNewEmployee(Employee emp)
    {
        _empList.Add(emp);
    }
//mailTo: phani.blrtraining@gmail.com
    public void DeleteEmployee(int id)
    {
        //find the matching record using the Find method
        var rec = _empList.Find((e)=>e.EmpId == id);
        //throw an Exception if the record is not found
        if(rec == null) throw new Exception($"Employee with ID {id} not found");
        //delete the record if found
        _empList.Remove(rec);
    }

    public List<Employee> GetAllEmployees() => _empList;
    

    public Employee GetEmployee(int id) {
        var rec = _empList.Find((e)=>e.EmpId == id);
        //throw an Exception if the record is not found
        if(rec == null) throw new Exception($"Employee with ID {id} not found");
        //return the record if found
        return rec;
    }

    public void UpdateEmployee(int id, Employee updatedEmp)
    {
        var rec = _empList.Find((e)=>e.EmpId == id);
        //throw an Exception if the record is not found
        if(rec == null) throw new Exception($"Employee with ID {id} not found");
        //update the record if found
        rec.DeepCopy(updatedEmp);
    }
}