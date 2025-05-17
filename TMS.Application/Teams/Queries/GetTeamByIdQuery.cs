using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Application.DTOs;

namespace TMS.Application.Teams.Queries
{
    public record GetTeamByIdQuery(Guid Id) : IRequest<TeamDto>;


}
