using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ayush.Models
{
    public class BaseUser : IdentityUser
    {
        public BaseUser()
        {
            UserInformations ??= new Collection<UserInformation>();
            Siblings ??= new Collection<UserSibling>();
        }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }
        public virtual ICollection<UserSibling> Siblings { get; set; }
    }
}
