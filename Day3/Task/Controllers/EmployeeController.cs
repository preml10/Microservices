using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using System.Linq;
using System.Collections.Generic;



namespace WebApplication12.Controllers
{
    //[Route("api/Controller")]
    public class EmployeeController : Controller
    {
        IEmployeeRepo _repository;

        public EmployeeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Employee> emList = _repository.GetAllEmployee();
            return View(emList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _repository.AddEmployee(obj);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _repository.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _repository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}