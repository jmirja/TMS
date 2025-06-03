using MediatR;
using TMS.Application.DTOs;

namespace TMS.Application.Users.Queries
{
    public record GetAllUsersQuery() : IRequest<IEnumerable<UserDto>>;

}
