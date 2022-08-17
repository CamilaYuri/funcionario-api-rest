using AR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Interfaces.Repositories
{
    public interface IEmployeeCLTRepository
    {
        Task AddEmployee(EmployeeCLT employeeCLT);
        Task<IEnumerable<EmployeeCLT>> GetAllEmployees();
        Task<EmployeeCLT> GetEmployeeById(int id);
        Task<int> DeleteEmployee(EmployeeCLT employeeCLT);
        Task<int> UpdateEmployee(EmployeeCLT employeeCLT);
    }
}
