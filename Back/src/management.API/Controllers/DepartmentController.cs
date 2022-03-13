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
    public class DepartmentController : ControllerBase
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Departamento> GetAll()
        {
            return _context.Departamentos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Departamento> Get(int id)
        {
            return _context.Departamentos.Where(department => department.Id == id);
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
