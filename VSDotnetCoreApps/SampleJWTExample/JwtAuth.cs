using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SampleJWTExample
{
    public interface IJwtAuth
    {
        string Authenticate(string username, string password);
    }
    public class JwtAuth : IJwtAuth
    {
        private readonly string _username = "phaniraj";
        private readonly string _password = "Apple123";
        private readonly string key;

        public JwtAuth(string key)
        {
            this.key = key;
        }
        public string Authenticate(string username, string password)
        {
            if(!username.Equals(_username, StringComparison.CurrentCultureIgnoreCase))
            {
                return "User is not validated";
            }
            var tokenHandler = new JwtSecurityTokenHandler();

            //Key to encrypt..
            var tokenKey = Encoding.ASCII.GetBytes(key);

            //Get the JWT descriptor
            var tokenDesc = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[] { new Claim(ClaimTypes.Name, username) }),
                    Expires= DateTime.UtcNow.AddMinutes(3),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDesc);
            return tokenHandler.WriteToken(token);
        }
    }
}
