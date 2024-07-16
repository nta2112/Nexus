using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Models;

namespace Nexus.Controllers.Admin
{

    public class AdminController : Controller
    {
        private readonly NexusContext _context;
        public AdminController(NexusContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TbEmployee()
        {
            var employees = _context.Employees.ToList();
            
            return View(employees);
        }

        //public async Task<IActionResult> EditEmployee(int employeeId)
        //{
        //    var employeeWithRole = await (from emp in _context.Employees
        //                                  join role in _context.Roles on emp.RoleId equals role.RoleId
        //                                  where emp.EmployeeId == employeeId
        //                                  select new EmployeeWithRoleViewModel
        //                                  {
        //                                      Id = emp.EmployeeId,
        //                                      Name = emp.Name,
        //                                      Email = emp.Email,
        //                                      Password = emp.Password,
        //                                      RoleName = role.RoleName
        //                                  }).FirstOrDefaultAsync();

        //    if (employeeWithRole == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employeeWithRole);
        //}
        //public async Task<IActionResult> Details(int id)
        //{
        //    var employeeWithRole = await (from emp in _context.Employees
        //                                  join role in _context.Roles on emp.RoleId equals role.Id
        //                                  where emp.Id == id
        //                                  select new EmployeeWithRoleViewModel
        //                                  {
        //                                      Id = emp.Id,
        //                                      Name = emp.Name,
        //                                      Email = emp.Email,
        //                                      Password = emp.Password,
        //                                      RoleName = role.RoleName
        //                                  }).FirstOrDefaultAsync();

        //    if (employeeWithRole == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employeeWithRole);
        //}

    }

    //public class EmployeeWithRoleViewModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //    public string RoleName { get; set; }
    //}
}
