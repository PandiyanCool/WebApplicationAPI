using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Queries;
using WebApplicationAPI.Commands;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        private readonly IMediator _mediator;
        public EmployeeController(IEmployeeService employeeService, IMediator mediator)
        {
            _employeeService = employeeService;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand command)
        {
            var employeeId = await _mediator.Send(command);
            return Ok(employeeId);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var query = new GetEmployeeQuery { EmployeeId = id };
            var employee = await _mediator.Send(query);
            return Ok(employee);
        }
    }
}
