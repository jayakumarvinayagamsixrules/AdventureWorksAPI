using AdventureWorks.Application.Features.Humanresources.Queries.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Application.Features.Humanresources.Queries.Shift
{
    public class GetShiftListQuery: IRequest<List<ShiftVm>>
    {
        public GetShiftListQuery()
        {
        }
    }
}
