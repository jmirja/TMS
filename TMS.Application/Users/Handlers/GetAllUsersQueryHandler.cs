using AutoMapper;
using MediatR;
using TMS.Application.DTOs;
using TMS.Application.Interfaces;
using TMS.Application.Users.Queries;

namespace TMS.Application.Users.Handlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _repo.GetAllUsersAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
