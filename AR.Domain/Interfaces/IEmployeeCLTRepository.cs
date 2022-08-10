using AR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Interfaces
{
    public interface IEmployeeCLTRepository
    {
        Task AddEmployee(EmployeeCLT employeePJ);
        Task<IEnumerable<EmployeeCLT>> GetAllEmployees();
        Task<EmployeeCLT> GetEmployeeById(int id);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(EmployeeCLT employeeCLT);
    }
}
