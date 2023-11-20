using System;
using System.Collections.Generic;
using System.Text;

namespace RepoLayer
{
    public class AuthenticateResponse
    {
        
            public UserEntity UserData { get; set; }
            public string Token { get; set; }
        
    }
}
