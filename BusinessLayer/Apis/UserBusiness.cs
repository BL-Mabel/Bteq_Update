using CommonLayer.Models;
using CommonLayer.Models.RequestModel;
using RepoLayer;
using RepoLayer.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLayer.RequestModel;

namespace BusinessLayer.Apis
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo userRepo;
        public UserBusiness(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        public UserEntity AdminRegister(AdminRegModel adminRegModel)
        {
              return userRepo.AdminRegister(adminRegModel);
        }

        public Task<AuthenticateResponse> AuthenticateOTP(AuthenticateReqModel authenticateReq)
        {
           return userRepo.AuthenticateOTP(authenticateReq);
        }

        public bool IsPhoneNumberIdExist(string PhoneNumer)
        {
            return userRepo.IsPhoneNumberIdExist(PhoneNumer);
        }

        public string LoginAdmin(LoginRequest loginReq)
        {
            return userRepo.LoginAdmin(loginReq);
        }

        public Task<string> SendOtpAsync(string phoneNumber)
        {
            return userRepo.SendOtpAsync(phoneNumber);
        }
    }
}
