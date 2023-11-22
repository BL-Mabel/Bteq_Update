using CommonLayer.Models;
using RepoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Apis
{
    public interface IUserBusiness
    {
        public UserEntity AdminRegister(AdminRegModel adminRegModel);
        public bool IsPhoneNumberIdExist(string PhoneNumer);
    }
}
