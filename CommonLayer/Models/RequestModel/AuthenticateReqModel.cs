using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class AuthenticateReqModel
    {
        public string PhoneNumber { get; set; }
        public string Otp { get; set; }
    }
}
