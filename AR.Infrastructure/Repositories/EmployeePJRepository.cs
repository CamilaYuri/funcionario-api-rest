using AR.Domain.Entities;
using AR.Domain.Interfaces.Repositories;
using AR.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AR.Infrastructure.Repositories
{
    public class EmployeePJRepository : IEmployeePJRepository
    {
        private readonly MainContext _db;

        public EmployeePJRepository(MainContext db)
        {
            _db = db;
        }

        public async Task AddEmployee(EmployeePJ employeePJ)
        {
            await _db.EmployeePJ.AddAsync(employeePJ);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeePJ>> GetAllEmployees()
        {
            return await _db.EmployeePJ.AsNoTracking().ToListAsync();
        }

        public async Task<EmployeePJ> GetEmployeeById(int id)
        {
            return await _db.EmployeePJ.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> DeleteEmployee(EmployeePJ employeePJ)
        {
            _db.EmployeePJ.Remove(employeePJ);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> UpdateEmployee(EmployeePJ employeePJ)
        {
            _db.EmployeePJ.Update(employeePJ);
            return await _db.SaveChangesAsync();
        }
    }
}
