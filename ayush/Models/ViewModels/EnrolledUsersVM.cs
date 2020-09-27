using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class EnrolledUsersVM
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? PlanPurchaseDate { get; set; }
    }
}
