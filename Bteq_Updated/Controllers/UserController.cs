using BusinessLayer.Apis;
using CommonLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
