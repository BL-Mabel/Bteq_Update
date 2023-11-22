using BusinessLayer.Apis;
using CommonLayer.Models;
using CommonLayer.Models.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilityLayer.RequestModel;

namespace Bteq_Updated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }
        [HttpPost]
        public IActionResult SignUp(AdminRegModel adminRegModel)
        {
            try
            {
                var ifPhoneExist = userBusiness.IsPhoneNumberIdExist(adminRegModel.PhoneNumber);
                if (ifPhoneExist)
                {
                    return NotFound(new { success = false, message = "The PhoneNumber Already Exist" });
                }
                var result = userBusiness.AdminRegister(adminRegModel);
                if (result != null)
                {
                    return this.Ok(new { success = true, message = "Registration Successfully", data = result });

                }
                else
                {
                    return this.NotFound(new { success = false, message = "Registration Failed, please Check phonenumber" });
                }
            }
            catch (Exception ex)
            {
                
                return NotFound(ex);
            }

        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            try
            {
                var result = userBusiness.LoginAdmin(loginRequest);
                if (result != null)
                {
                    return this.Ok(new { success = true, message = "Login Successfully", data = result });

                }
                else
                {
                    return this.NotFound(new { success = false, message = "Login Failed Check phonenumber" });
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
            [HttpPost("authenticate")]
            public IActionResult VerifyOtp(AuthenticateReqModel reqModel)
            {
            try
            {
                var res = userBusiness.AuthenticateOTP(reqModel);
                if (res.Result == null)
                {
                    return NotFound(new { success = false, message = "otp verification failed", data = res.Result });
                }
                else
                {
                    return Ok(new { success = true, message = "otp verified successfully", data = res.Result });
                }
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex);
            }
            }
        
    }
}
