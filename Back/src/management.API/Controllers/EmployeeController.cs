using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using management.API.Data;
using management.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace management.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Funcionarios;
        }

        [HttpGet("{id}")]
        public IEnumerable<Employee> GetId(int id)
        {
            return _context.Funcionarios.Where(employee => employee.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete = {id}";
        }

    }
}
