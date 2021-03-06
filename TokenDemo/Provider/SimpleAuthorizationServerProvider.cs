using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TokenDemo
{
    internal class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        // second comment
        // third comment
        //public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        //{
        //    context.Validated();
        //}

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.Validated(new ClaimsIdentity(context.Options.AuthenticationType));
        }
    }
}