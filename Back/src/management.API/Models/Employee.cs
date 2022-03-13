using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management.API.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ImagemURL { get; set; }
        public int RG { get; set; }
        public int? IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
    }
}