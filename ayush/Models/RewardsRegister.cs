using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
    public class RewardsRegister
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RegisteredUserEmail { get; set; }
        public int? RewardPoints { get; set; }
        public DateTime RewardDate { get; set; }
    }
}
