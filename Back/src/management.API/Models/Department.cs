using System.ComponentModel.DataAnnotations;

namespace management.API.Models
{
    public class Department
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}