using AR.Domain.DTO;
using AR.Domain.Entities;
using AR.Domain.Interfaces.Repositories;
using AR.Domain.Interfaces.Services;
using AutoMapper;

namespace AR.Domain.Services
{
    public class EmployeeCLTService : IEmployeeCLTService
    {
        private readonly IEmployeeCLTRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeCLTService(IEmployeeCLTRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(EmployeeCltDTO employee)
        {
            try
            {
                var employeeMapped = _mapper.Map<EmployeeCLT>(employee);
                await  _repository.AddEmployee(employeeMapped);
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        public async Task<IEnumerable<EmployeeCltDTO>> GetAll()
        {
            var employee = await _repository.GetAllEmployees();
            var employeeMapped = _mapper.Map<IEnumerable<EmployeeCltDTO>>(employee);
            return employeeMapped;
        }

        public async Task<EmployeeCltDTO> GetById(int id)
        {
            var employee = await _repository.GetEmployeeById(id);
            var employeeMapped = _mapper.Map<EmployeeCltDTO>(employee);
            return employeeMapped;
        }

        public async Task<int> Delete(int id)
        {
            var employee = await _repository.GetEmployeeById(id);
            if (employee == null)
                return 0;

            return await _repository.DeleteEmployee(employee);
        }

        public async Task<int> Update(EmployeeCltDTO employee)
        {
           var employeeExists = await _repository.GetEmployeeById(employee.Id);
            if (employeeExists == null)
                return 0;

            var employeeMapped = _mapper.Map<EmployeeCLT>(employee);
            return await _repository.UpdateEmployee(employeeMapped);
        }
    }
}
