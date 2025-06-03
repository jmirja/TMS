using MediatR;
using TMS.Application.DTOs;

namespace TMS.Application.Users.Queries
{
    public record GetUserByIdQuery(Guid Id) : IRequest<UserDto?>;

}
