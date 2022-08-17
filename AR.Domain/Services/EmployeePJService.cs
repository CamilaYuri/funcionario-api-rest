using AR.Domain.DTO;
using AR.Domain.Entities;
using AR.Domain.Interfaces.Repositories;
using AR.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain.Services
{
    public class EmployeePJService : IEmployeePJService
    {
        private readonly IEmployeePJRepository _repository;
        private readonly IMapper _mapper;

        public EmployeePJService(IEmployeePJRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(EmployeePjDTO employee)
        {
            try
            {
                var employeeMapped = _mapper.Map<EmployeePJ>(employee);
                await _repository.AddEmployee(employeeMapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<EmployeePjDTO>> GetAll()
        {
            var employee = await _repository.GetAllEmployees();
            var employeeMapped = _mapper.Map<IEnumerable<EmployeePjDTO>>(employee);
            return employeeMapped;
        }

        public async Task<EmployeePjDTO> GetById(int id)
        {
            var employee = await _repository.GetEmployeeById(id);
            var employeeMapped = _mapper.Map<EmployeePjDTO>(employee);
            return employeeMapped;
        }

        public async Task<int> Delete(int id)
        {
            var employee = await _repository.GetEmployeeById(id);
            if (employee == null)
                return 0;

            return await _repository.DeleteEmployee(employee);
        }

        public async Task<int> Update(EmployeePjDTO employee)
        {
            var employeeExists = await _repository.GetEmployeeById(employee.Id);
            if (employeeExists == null)
                return 0;

            var employeeMapped = _mapper.Map<EmployeePJ>(employee);
            return await _repository.UpdateEmployee(employeeMapped); 
        }
    }
}
