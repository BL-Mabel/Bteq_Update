using CommonLayer.Models;
using CommonLayer.Models.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLayer.RequestModel;

namespace RepoLayer.Apis
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }
     

        public UserEntity AdminRegister(AdminRegModel adminRegModel)
        {
            try
            {
                UserEntity signUpAdmin = new UserEntity();
                signUpAdmin.Phone_Number = "91" + adminRegModel.PhoneNumber;
                signUpAdmin.User_Name = adminRegModel.Username;
                signUpAdmin.Email = adminRegModel.Email;
                signUpAdmin.Role = adminRegModel.Role;
                signUpAdmin.Created_At = DateTime.Now;
                signUpAdmin.Updated_At = DateTime.Now;
                signUpAdmin.isActive = adminRegModel.isActive;
                _context.Add(signUpAdmin);
                _context.SaveChanges();
                if (signUpAdmin != null)
                {
                    return signUpAdmin;
                }
                else
                { throw new Exception("register was unsuccessful"); }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool IsPhoneNumberIdExist(string PhoneNumer)
        {
            var emailIds = _context.Users.Where(eu => eu.Phone_Number == "91" + PhoneNumer).Count();
            return emailIds > 0;
        }
        public string LoginAdmin(LoginRequest loginReq)
        {
            try
            {
                var PhNumber = _context.Users.Where(x => x.Phone_Number == "91" + loginReq.PhoneNumber).FirstOrDefault();
                if (PhNumber != null)
                {
                    return "1234 is sent as otp";
                }
                else
                    throw new Exception("Login was unsuccessful");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> SendOtpAsync(string phoneNumber)
        {
           
                //Send a fixed OTP value of "1234" in development mode
                var otp = "1234";
                var OtpMsg = otp + " is OTP to login to EJET BTEQ App.Valid for 5min.";
                //  var cacheOptions = new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5) };
                //var cacheKey = configuration["Redis:cacheKey"];

                // await distributedCache.SetStringAsync(Redis_Env, otp, cacheOptions);
                return OtpMsg;
        }
        public async Task<AuthenticateResponse> AuthenticateOTP(AuthenticateReqModel authenticateReq)
        {
            AuthenticateResponse response = new AuthenticateResponse();
            //Checking If The PhoneNumber Or Otp Is Null or Empty
            if (string.IsNullOrEmpty(authenticateReq.PhoneNumber) || string.IsNullOrEmpty(authenticateReq.Otp))
            {
                throw new Exception("Phone number or OTP were Empty");
            }
            else
            {
                var generateJwt = _context.Users.Where(x => x.Phone_Number == "91" + authenticateReq.PhoneNumber).FirstOrDefault();
                if (generateJwt != null)
                {
                    if ("1234" == authenticateReq.Otp)
                    {
                        return response;
                    }
                    else
                    {
                        throw new Exception("error in sending otp");
                    }
                }
                else throw new Exception("phone number doesnt exists");
            }
        }
    }
}
