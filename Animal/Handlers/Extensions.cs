using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Animal.Handlers
{
    public static class Extensions
    {
        public static string GetSpecificClaim(this ClaimsIdentity claimsIdentity)
        {
            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.Name);


            return claim?.Value ?? string.Empty;
        }
        
    }
}
