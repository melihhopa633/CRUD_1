using Microsoft.AspNetCore.Mvc;
using test_proje_1.Models;

namespace test_proje_1.Controllers
{
    public class EmployeesController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Employees.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Employee emp = new Employee();
            return PartialView("_EmployeeModelPartial", emp);
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return PartialView("_EmployeeModelPartial", emp);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_EditEmployeeModelPartial", emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
            return PartialView("_EditEmployeeModelPartial", emp);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_DeleteEmployeeModelPartial", emp);
        }
        [HttpPost]
        public IActionResult Delete(Employee emp)
        {
            var employee = _context.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return PartialView("_DeleteEmployeeModelPartial", employee);
        }
    }
}
