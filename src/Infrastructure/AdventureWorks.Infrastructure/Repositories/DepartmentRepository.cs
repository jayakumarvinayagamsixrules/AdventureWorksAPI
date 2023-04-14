using AdventureWorks.Application.Contracts.Persistence;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Infrastructure.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {  
        public DepartmentRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Department>> GetDepartment()
        {
            var orderList = await _dbContext.Departments.ToListAsync();
            return orderList;

        }
    }
}
