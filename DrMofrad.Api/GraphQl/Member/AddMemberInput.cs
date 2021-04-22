using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrMofrad.Api.GraphQl.Member
{
    public record AddMemberInput(string FullName, string UserName, string Password, string Email);
}
