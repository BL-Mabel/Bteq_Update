using RepositoryLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Models.ResponseModel
{
    public class LoginResponse
    {
        public List<NavBarOption> NavBarOptions { get; set; }
        public string Otp { get; set; }
    }
}
