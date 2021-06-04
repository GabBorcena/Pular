using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class UserAuthentication
    { 
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string isActive { get; set; }
        public string LoginFailedCount { get; set; }

    }
}