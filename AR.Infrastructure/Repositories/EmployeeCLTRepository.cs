using AR.Domain.Entities;
using AR.Domain.Interfaces.Repositories;
using AR.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AR.Infrastructure.Repositories
{
    public class EmployeeCLTRepository : IEmployeeCLTRepository
    {
        private readonly MainContext _db;

        public EmployeeCLTRepository(MainContext db)
        {
            _db = db;
        }

        public async Task AddEmployee(EmployeeCLT employeeCLT)
        {
            await _db.EmployeeCLT.AddAsync(employeeCLT);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeCLT>> GetAllEmployees()
        {
            return await _db.EmployeeCLT.AsNoTracking().ToListAsync();
        }

        public async Task<EmployeeCLT> GetEmployeeById(int id)
        {
            return await _db.EmployeeCLT.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> DeleteEmployee(EmployeeCLT employeeCLT)
        {
            _db.EmployeeCLT.Remove(employeeCLT);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> UpdateEmployee(EmployeeCLT employeeCLT)
        {
            _db.EmployeeCLT.Update(employeeCLT);
            return await _db.SaveChangesAsync();
        }
    }
}
