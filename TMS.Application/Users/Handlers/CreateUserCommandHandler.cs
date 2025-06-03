using MediatR;
using TMS.Application.Users.Command;
using TMS.Domain.Entities;
using TMS.Domain.Interfaces;

namespace TMS.Application.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _repo;

        public CreateUserCommandHandler(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                FullName = request.FullName,
                Email = request.Email,
                Role = request.Role
            };

            await _repo.AddUserAsync(user);
            return user.Id;
        }
    }
}
