using Microsoft.AspNetCore.Identity;
using System;

namespace ayush.Models
{
    public class UserSibling
    {        
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual BaseUser IdentityUser { get; set; }
    }
}
