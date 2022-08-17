using AR.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Interfaces.Services
{
    public interface IEmployeeCLTService
    {
        Task Add(EmployeeCltDTO employee);
        Task<IEnumerable<EmployeeCltDTO>> GetAll();
        Task<EmployeeCltDTO> GetById(int id);
        Task<int> Delete(int id);
        Task<int> Update(EmployeeCltDTO employee);
    }
}
