using MediatR;
using TMS.Domain.Enums;

namespace TMS.Application.Users.Command
{
    public record CreateUserCommand(string FullName, string Email, UserRole Role) : IRequest<Guid>;

}
