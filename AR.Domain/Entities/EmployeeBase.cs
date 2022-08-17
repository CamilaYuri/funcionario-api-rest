using System.ComponentModel.DataAnnotations;

namespace AR.Domain.Entities
{
    public abstract class EmployeeBase
    {
        public EmployeeBase(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public EmployeeBase()
        {}

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
