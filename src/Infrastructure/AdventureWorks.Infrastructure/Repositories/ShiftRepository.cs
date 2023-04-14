using AdventureWorks.Application.Contracts.Persistence;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Infrastructure.Repositories
{
    public class ShiftRepository : RepositoryBase<Shift>, IShiftRepository
    {
        public ShiftRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Shift>> GetShift()
        {
            var shiftList = await _dbContext.Shifts.ToListAsync();
            return shiftList;
        }
    }
}
