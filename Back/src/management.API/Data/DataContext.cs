using management.API.Models;
using Microsoft.EntityFrameworkCore;

namespace management.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Employee> Funcionarios { get; set; }
        public DbSet<Department> Departamentos { get; set; }
    }
}