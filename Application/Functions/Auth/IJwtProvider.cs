using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth
{
    public interface IJwtProvider
    {
        string Generate(ApplicationUser user);
    }
}
