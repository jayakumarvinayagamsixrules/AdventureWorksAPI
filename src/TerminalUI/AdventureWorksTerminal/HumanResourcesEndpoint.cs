using AdventureWorks.Application.Features.Humanresources.Queries.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksTerminal
{
    public class HumanResourcesEndpoint
    {
        private readonly IMediator _mediator;

        public HumanResourcesEndpoint(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async void GetDepartmentList()
        {
            var query = new GetDepartmentListQuery();
            var departments = await _mediator.Send(query);
        }
    }
}
