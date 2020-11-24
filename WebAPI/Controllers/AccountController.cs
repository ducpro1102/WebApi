using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebModel;
using WebModels;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private AuthRepository _repo = null;

        public AccountController()
        {
            _repo = new AuthRepository();
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            MgsResult objMgsResult = new MgsResult();
            if (!ModelState.IsValid)
            {
                objMgsResult.state = 3;
                objMgsResult.message = "Bạn phải nhập đầy đủ thông tin";
                return Json(objMgsResult);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);

            objMgsResult = GetErrorResult(result);

            if (objMgsResult.state != null && objMgsResult.state != 1)
            {
                return Json(objMgsResult);
            }
            return Json(objMgsResult);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }
        
        private MgsResult GetErrorResult(IdentityResult result)
        {
            MgsResult objMgsResult = new MgsResult();
            if (result == null)
            {
                objMgsResult.state = 2;
                objMgsResult.message = "InternalServerError";
                return objMgsResult;
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                        objMgsResult.message = objMgsResult.message + ". " + error;
                    }
                }
                objMgsResult.state = 2;
                return objMgsResult;
            }

            objMgsResult.state = 1;
            objMgsResult.message = "Ok";
            return objMgsResult;
        }
    }
}
