using AutoMapper;
using MediatR;
using TMS.Application.DTOs;
using TMS.Application.Users.Queries;
using TMS.Domain.Interfaces;

namespace TMS.Application.Users.Handlers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto?>
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<UserDto?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserByIdAsync(request.Id);
            return user is null ? null : _mapper.Map<UserDto>(user);
        }
    }
}
