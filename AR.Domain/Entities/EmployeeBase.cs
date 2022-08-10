using System.ComponentModel.DataAnnotations;

namespace AR.Domain.Entities
{
    public class EmployeeBase
    {
        public EmployeeBase(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
