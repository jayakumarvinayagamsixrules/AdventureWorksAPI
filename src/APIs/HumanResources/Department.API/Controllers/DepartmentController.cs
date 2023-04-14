using AdventureWorks.Application.Features.Humanresources.Queries.Department;
using AdventureWorks.Application.Features.Humanresources.Queries.Shift;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Department.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public DepartmentController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet(Name = "GetDepartment")]
        [ProducesResponseType(typeof(IEnumerable<DepartmentVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DepartmentVm>>> GetDepartmentName()
        {
            var query = new GetDepartmentListQuery();
            var departments = await _mediator.Send(query);
            return Ok(departments);
        }

        [Route("[action]/", Name = "GetShift")]
        [HttpGet]
        [ProducesResponseType(typeof(ShiftVm), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ShiftVm>>> GetShift()
        {
            var query = new GetShiftListQuery();
            var shifts = await _mediator.Send(query);
            return Ok(shifts);
        }
    }
}
