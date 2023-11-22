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
    public interface IUserRepo
    {
        public UserEntity AdminRegister(AdminRegModel adminRegModel);
        public bool IsPhoneNumberIdExist(string PhoneNumer);
        public string LoginAdmin(LoginRequest loginReq);
         Task<string> SendOtpAsync(string phoneNumber);
        Task<AuthenticateResponse> AuthenticateOTP(AuthenticateReqModel authenticateReq);
    }
}
