using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models.RequestModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "{0} should not be empty")]
        [RegularExpression(@"^([7-9]{1})([0-9]{9})$", ErrorMessage = "PhoneNumber id is not valid")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
