using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class RegisteredUsersVM
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
