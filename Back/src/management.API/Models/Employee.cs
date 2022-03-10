namespace management.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ImagemURL { get; set; }
        public int RG { get; set; }
        public Department Departmento { get; set; }
        public int IdDepartamento { get; set; }
    }
}