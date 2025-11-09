using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace BasicHttpAuthentication
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    //Memonic : Handler for AuthenticationScheme
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
        {
            //Add this constructor
        }

        //you have to override this method - async method
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing Authorization header.");
            }

            try
            {
                var authHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"].ToString());
                var bytes = Convert.FromBase64String(authHeaderValue.Parameter);
                var credentials = Encoding.UTF8.GetString(bytes).Split(':');
                var uName = credentials[0];
                var password = credentials[1];
                //Bcoz its sent in the format username : password

                if (uName != "admin" && password != "admin123")
                {
                    return AuthenticateResult.Fail("Invalid username or password");
                }

                var claims = new[] { new Claim(ClaimTypes.Name, uName) };
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authentication Header");
            }

        }
    }
}
