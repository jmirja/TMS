using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Application.DTOs;
using TMS.Application.Interfaces;
using TMS.Application.Teams.Queries;

namespace TMS.Application.Teams.Handlers
{
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, IEnumerable<TeamDto>>
    {
        private readonly ITeamRepository _repo;

        public GetAllTeamsQueryHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<TeamDto>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            var teams = await _repo.GetAllAsync();

            return teams.Select(team => new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description
            });
        }
    }

}
