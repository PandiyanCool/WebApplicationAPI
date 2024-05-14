using MediatR;
using WebApplicationAPI.Commands;

namespace WebApplicationAPI.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        public Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var id = 22;
            return Task.FromResult(id);
        }

        private int CreateEmployeeInDatabase()
        {
            return 12;
        }
    }
}
