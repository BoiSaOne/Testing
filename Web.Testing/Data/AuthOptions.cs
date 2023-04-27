using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Web.Testing.Data
{
    public static class AuthOptions
    {
        public const string ISSUER = nameof(Testing);
        public const string AUDIENCE = "WebClient";
        private const string KEY = "3bqnlASI76HqEs6HgwG33isy7";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
