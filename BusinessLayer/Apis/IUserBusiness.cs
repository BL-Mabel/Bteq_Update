using CommonLayer.Models;
using CommonLayer.Models.RequestModel;
using RepoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLayer.RequestModel;

namespace BusinessLayer.Apis
{
    public interface IUserBusiness
    {
        public UserEntity AdminRegister(AdminRegModel adminRegModel);
        public bool IsPhoneNumberIdExist(string PhoneNumer);
        public string LoginAdmin(LoginRequest loginReq);
        Task<string> SendOtpAsync(string phoneNumber);
        Task<AuthenticateResponse> AuthenticateOTP(AuthenticateReqModel authenticateReq);
    }
}
