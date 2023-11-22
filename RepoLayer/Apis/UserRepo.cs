using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
