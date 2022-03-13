using System.ComponentModel.DataAnnotations;

namespace management.API.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}