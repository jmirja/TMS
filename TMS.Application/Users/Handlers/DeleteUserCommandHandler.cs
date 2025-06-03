using MediatR;
using TMS.Application.Users.Command;
using TMS.Domain.Interfaces;

namespace TMS.Application.Users.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _repo;

        public DeleteUserCommandHandler(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteUserAsync(request.Id);
            return Unit.Value;
        }
    }
}
