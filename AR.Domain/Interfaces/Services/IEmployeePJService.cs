using AR.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Interfaces.Services
{
    public interface IEmployeePJService
    {
        Task Add(EmployeePjDTO employee);
        Task<IEnumerable<EmployeePjDTO>> GetAll();
        Task<EmployeePjDTO> GetById(int id);
        Task<int> Delete(int id);
        Task<int> Update(EmployeePjDTO employee);
    }
}
