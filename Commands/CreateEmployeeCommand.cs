using MediatR;

namespace WebApplicationAPI.Commands
{
    public class CreateEmployeeCommand: IRequest<int>
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
