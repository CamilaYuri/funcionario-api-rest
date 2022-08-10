namespace AR.Domain.Entities
{
    public class EmployeePJ : EmployeeBase
    {
        public EmployeePJ(int id, string name, string email, string cnpj) 
            : base (id, name, email)
        {
            CNPJ = cnpj;
        }

        public decimal Salario { get; private set; }
        public string CNPJ { get; set; }

        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }
    }
}
