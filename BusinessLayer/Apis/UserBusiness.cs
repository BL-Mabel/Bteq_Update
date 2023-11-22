﻿using CommonLayer.Models;
using RepoLayer;
using RepoLayer.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool IsPhoneNumberIdExist(string PhoneNumer)
        {
            return userRepo.IsPhoneNumberIdExist(PhoneNumer);
        }
    }
}