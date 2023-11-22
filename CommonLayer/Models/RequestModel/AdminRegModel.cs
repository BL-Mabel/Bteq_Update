using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class AdminRegModel
    {
        [Required(ErrorMessage = "{0} should not be empty")]
        [RegularExpression(@"^([7-9]{1})([0-9]{9})$", ErrorMessage = "PhoneNumber id is not valid")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "{0} should not be empty")]
        [StringLength(25, MinimumLength = 3)]
        [RegularExpression(@"^[A-Za-z]{1}[a-z]{2,}$", ErrorMessage = "First name is not valid")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required(ErrorMessage = "{0} should not be empty")]
        [RegularExpression(@"^[a-zA-Z0-9]{3,}([._+-][0-9a-zA-Z]{2,})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2})+[.]([a-zA-Z]{3})+$", ErrorMessage = "Email id is not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Role { get; set; }
        public bool isActive { get; set; }
    }
}
