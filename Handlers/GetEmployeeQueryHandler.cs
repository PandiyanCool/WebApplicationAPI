using MediatR;
using WebApplicationAPI.Models;
using WebApplicationAPI.Queries;

namespace WebApplicationAPI.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, EmployeeDto>
    {
        public Task<EmployeeDto> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employeeId = request.EmployeeId;
            var employee = RetrieveEmployeeFromDatabase(employeeId);
            return Task.FromResult(employee);
        }

        private EmployeeDto RetrieveEmployeeFromDatabase(int employeeId)
        {
            return new EmployeeDto()
            {
                Age = "22",
                Id = 101,
                Name = "Elon"
            };
        }
    }
}
