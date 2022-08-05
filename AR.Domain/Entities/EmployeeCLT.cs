namespace AR.Domain.Entities
{
    public class EmployeeCLT : EmployeeBase
    {
        public EmployeeCLT(Guid id, string name, string email, string cpf) 
            : base(id, name, email)
        {
            CPF = cpf;
        }

        public decimal Salario { get; private set; }
        public string CPF { get; set; }

        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }
    }
}
