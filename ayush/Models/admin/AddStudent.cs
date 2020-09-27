using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ayush.Models.admin
{
    public class AddStudent : IdentityUser
    {
        //this class is saving extra values of add_student
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class2 { get; set; }
        public string City { get; set; }
    }
}
