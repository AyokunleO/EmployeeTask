using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session3.Models;
using Session3.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Session3.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeService employeeService;

        public HomeController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employees = employeeService.GetEmployees();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            Employee employee1 = new Employee
            {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Department = employee.Department,
            Salary = employee.Salary
        };
            employeeService.AddEmployee(employee1);
            return RedirectToAction("Index");
        }
        public IActionResult Employee(int id)
        {
            Employee info = employeeService.GetEmployee(id);
            return View(info);
        }
        public IActionResult Confirm(int id)
        {
            Employee confirmEmployee = employeeService.GetEmployee(id);
            confirmEmployee.Confirmed = true;
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
