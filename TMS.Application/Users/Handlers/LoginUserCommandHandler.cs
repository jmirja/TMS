using MediatR;
using TMS.Application.Interfaces;
using TMS.Application.Users.Command;

namespace TMS.Application.Users.Handlers
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IUserRepository _repo;
        private readonly IJwtService _jwt;

        public LoginUserCommandHandler(IUserRepository repo, IJwtService jwt)
        {
            _repo = repo;
            _jwt = jwt;
        }

        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserByEmailAsync(request.Email);
            if (user is null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                throw new UnauthorizedAccessException();

            return _jwt.GenerateToken(user);
        }
    }
}
