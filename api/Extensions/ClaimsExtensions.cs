using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace api.Extensions
{
    public static class ClaimsExtensions
    {
    public static string GetUsername(this ClaimsPrincipal user)
{
    var claim = user.Claims.SingleOrDefault(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"));
    if (claim == null)
    {
        Console.WriteLine("Available claims:");
        foreach (var c in user.Claims)
        {
            Console.WriteLine($"Type: {c.Type}, Value: {c.Value}");
        }
        throw new Exception("The username claim is missing from the token.");
    }
    return claim.Value;
}
    }
}