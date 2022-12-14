using AR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Interfaces.Repositories
{
    public interface IEmployeePJRepository
    {
        Task AddEmployee(EmployeePJ employeePJ);
        Task<IEnumerable<EmployeePJ>> GetAllEmployees();
        Task<EmployeePJ> GetEmployeeById(int id);
        Task<int> DeleteEmployee(EmployeePJ employeePJ);
        Task<int> UpdateEmployee(EmployeePJ employeePJ);
    }
}
