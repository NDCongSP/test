using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learn.Models
{
    public class LoginModel
    {
        [Required]
        public string userName { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
        public string newPassword { get; set; }
        public string reNewPass { get; set; }
    }
}