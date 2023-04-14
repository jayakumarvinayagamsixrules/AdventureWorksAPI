using AdventureWorks.Application.Contracts.Persistence;
using AdventureWorks.Application.Features.Humanresources.Queries.Department;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Application.Features.Humanresources.Queries.Shift
{
    public class GetShiftListQueryHandle : IRequestHandler<GetShiftListQuery, List<ShiftVm>>
    {
        private readonly IMapper _mapper;
        private readonly IShiftRepository _shiftRepository;

        public GetShiftListQueryHandle(IMapper mapper, IShiftRepository shiftRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _shiftRepository = shiftRepository ?? throw new ArgumentNullException(nameof(shiftRepository));
        }

        public async Task<List<ShiftVm>> Handle(GetShiftListQuery request, CancellationToken cancellationToken)
        {
            var shiftList = await _shiftRepository.GetShift();
            return _mapper.Map<List<ShiftVm>>(shiftList);
        }
    }
}
