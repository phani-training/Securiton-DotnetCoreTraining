using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleMvcCoreApp.Models;

namespace SampleMvcCoreApp.Controllers
{

    [Authorize]
    public class EmployeeController : Controller
    {
        private IEmployeeRepo? _repo = null;

        public EmployeeController(IEmployeeRepo? repo)
        {
            _repo = repo;
        }
        public IActionResult Error()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            
            //create the model based on UR Requirement
            var data = _repo.GetAll();
            //Inject the model into the View. 
            //REturn the View. ViewName is same as the Function(Action) Name 
            return View(data);
        }

        public string Hello() => $"Hello Messenger";

        public Employee GetMe() => new Employee { EmpAddress = "Bangalore", EmpSalary = 50000, EmpName = "Test Name", EmpId = 111 };

        //HTTP GET Version
        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(Employee emp)
        {
            _repo.AddNewEmployee(emp);
            return RedirectToAction("Index");
        }

        //HTTP GET Operation
        public IActionResult Edit(int id)
        {
            var emp = _repo.GetEmployee(id);
            return View("AddNew", emp);
        }
        //HTTPPost to Submit
        [HttpPost]
        public IActionResult Edit(Employee postedData)
        {
            _repo.UpdateEmployee(postedData);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            _repo.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}
