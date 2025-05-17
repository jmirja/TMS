using MediatR;

namespace TMS.Application.Users.Command
{
    public record DeleteUserCommand(Guid Id) : IRequest;

}
