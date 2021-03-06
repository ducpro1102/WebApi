﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Provider
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            AuthRepository _repo = new AuthRepository();
            IdentityUser user = await _repo.FindUser(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }
            //IdentityUserRole
            var claims = await _repo.FindAllClaims(context.UserName, context.Password);
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("UserName", context.UserName));
            foreach(var claim in claims)
            {
                identity.AddClaim(new Claim(claim.Type, claim.Value));
            }
            var roles = await _repo.FindAllRoles(context.UserName, context.Password);
            foreach (var str in roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, str));
            }
            context.Validated(identity);

        }
    }
}