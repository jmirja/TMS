using MediatR;
using TMS.Domain.Enums;

namespace TMS.Application.Users.Command
{
    public record UpdateUserCommand(Guid Id, string FullName, string Email, UserRole Role) : IRequest;

}
