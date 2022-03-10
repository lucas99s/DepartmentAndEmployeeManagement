using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using management.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace management.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        public IEnumerable<Employee> _employee = new Employee[]
        {
            new Employee() {
                Id = 1,
                Nome = "Lucas",
                RG = 379782364
            },
            new Employee() {
                Id = 1,
                Nome = "Lucas",
                RG = 379782364
            }
        };
        public EmployeeController()
        {
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employee;
        }

        [HttpGet("{id}")]
        public IEnumerable<Employee> GetId(int id)
        {
            return _employee.Where(employee => employee.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete = {id}";
        }

    }
}
