using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceMonolith.Core.Services.Jwt
{
    internal interface IJwtService
    {
        string GenerateToken(string userId, string email);

    }
}
