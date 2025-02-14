using Lab250214_Northwind.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab250214_Northwind.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MyDbContext _context;


        public EmployeesController(MyDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.Employees = await _context.Employees.ToListAsync();
            return View();
        }
    }

}
