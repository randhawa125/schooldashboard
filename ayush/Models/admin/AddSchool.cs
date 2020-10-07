using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ayush.Models.admin
{
    public class AddSchool:IdentityUser
    {
        [Required]
        [Display(Name = "School Id")]
        public int SchoolID { get; set; }
        [Required]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }
        public string Address { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public Int64 PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Name (POC)")]
        public string Name_POC { get; set; }
        [Required]
        [Display(Name = "Phone Number (POC)")]
        public Int64 PhoneNumber_POC { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email (POC)")]
        public string Email_POC { get; set; }
        [Required]
        [Display(Name = "Address (POC)")]
        public string Address_POC { get; set; }

        [Required]
        [Display(Name = "High Qualification (POC)")]

        public string HighQualification_POC { get; set; }
        [Required]
        [Display(Name = "Designation (POC)")]
        public string Designation_POC { get; set; }
        [Display(Name = "Upload Certification (POC)")]
        public string UploadCertifications_POC { get; set; }
        [Display(Name = "Upload CV (POC)")]
        public string UploadCv_POC { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
