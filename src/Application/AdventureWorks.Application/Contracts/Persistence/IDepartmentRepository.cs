using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Application.Contracts.Persistence
{
    public interface IDepartmentRepository : IAsyncRepository<Department>
    {
        Task<IEnumerable<Department>> GetDepartment();
    }
}
