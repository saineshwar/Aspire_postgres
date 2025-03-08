using AspireApp3.ApiService.Data;
using AspireApp3.ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspireApp3.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly DataDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EmployeesController(DataDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var listodEmployees = await _context.Employees.ToListAsync();
            return Ok(listodEmployees);
        }

        [HttpPost]
        public async Task<bool> AddEmployees([FromBody] Employee employees)
        {
            try
            {
                await _context.Employees.AddAsync(employees);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return true;
        }
    }
}
