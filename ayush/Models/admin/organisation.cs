using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.admin
{
    [Table("org_info")]
    public class Organisation
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Organisation Name")]
        public string name_org { get; set; }
        [Required(ErrorMessage = "Enter Address")]
        public string Address_org { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Phone Number")]
        public string Phone1 { get; set; }
       
        public string phone2 { get; set; }
    }
}
