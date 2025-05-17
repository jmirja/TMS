using MediatR;
using TMS.Application.Interfaces;
using TMS.Application.Users.Command;
using TMS.Domain.Enums;

namespace TMS.Application.Users.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _repo;

        public UpdateUserCommandHandler(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserByIdAsync(request.Id);
            if (user is null) throw new KeyNotFoundException("User not found.");

            user.FullName = request.FullName;
            user.Email = request.Email;
            user.Role = request.Role;

            await _repo.UpdateUserAsync(user);
            return Unit.Value;
        }
    }

}
