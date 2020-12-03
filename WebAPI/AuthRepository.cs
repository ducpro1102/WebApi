using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using WebModels;

namespace WebAPI
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if(userModel.FullName!=null)
                await _userManager.AddClaimAsync(user.Id, new Claim("FullName", userModel.FullName));
            if (userModel.Address != null)
                await _userManager.AddClaimAsync(user.Id, new Claim("Address", userModel.Address));
            if(userModel.RoleName !=null)
                await _userManager.AddClaimAsync(user.Id, new Claim("Role", userModel.RoleName));
            if (userModel.RoleName != null)
                await _userManager.AddToRoleAsync(user.Id, userModel.RoleName);
            else
                await _userManager.AddToRoleAsync(user.Id, "Customer");
            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }
        public async Task<IList<Claim>> FindAllClaims(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);
            var lstClaim = await _userManager.GetClaimsAsync(user.Id);
            return lstClaim;
        }
        public async Task<IList<string>> FindAllRoles(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);
            var lst = await _userManager.GetRolesAsync(user.Id);
            return lst;
        }
        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }

    }
}