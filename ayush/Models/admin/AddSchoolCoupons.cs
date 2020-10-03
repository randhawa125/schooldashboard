using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.admin
{
    public class AddSchoolCoupons
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Id")]
        public int ID { get; set; }
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "School Id")]
        public string SchoolID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Number Of Coupons")]
        public int NumberOfCoupons { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Issue date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime IssueDate { get; set; }
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "Coupon Number")]
        public string CouponNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
