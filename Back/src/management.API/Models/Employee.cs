using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management.API.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ImagemURL { get; set; }
        public int RG { get; set; }
        public Department Department { get; set; }
        public int IdDepartamento { get; set; }
    }
}