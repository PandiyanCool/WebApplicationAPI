using MediatR;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Queries
{
    public class GetEmployeeQuery:IRequest<EmployeeDto>
    {
        public int EmployeeId { get; set; }
    }
}
