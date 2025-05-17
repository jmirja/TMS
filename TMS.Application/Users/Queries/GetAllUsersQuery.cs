using MediatR;
using TMS.Application.DTOs;
using TMS.Domain.Entities;

namespace TMS.Application.Users.Queries
{
    public record GetAllUsersQuery() : IRequest<IEnumerable<UserDto>>;

}
