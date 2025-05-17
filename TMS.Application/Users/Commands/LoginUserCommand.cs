using MediatR;

namespace TMS.Application.Users.Command
{
    public record LoginUserCommand(string Email, string Password) : IRequest<string>;


}
