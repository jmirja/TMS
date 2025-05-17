using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Application.Teams.Commands
{
    public record UpdateTeamCommand(Guid Id, string Name, string? Description) : IRequest;


}
