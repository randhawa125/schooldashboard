using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
    public class AddSchoolInfo
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
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [Column(TypeName = "varchar(max)")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Name (POC)")]
        [Column(TypeName = "varchar(max)")]
        public string Name_POC { get; set; }
        [Required]
        [Display(Name = "Phone Number (POC)")]
        [Column(TypeName = "varchar(max)")]
        public string PhoneNumber_POC { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email (POC)")]
        [Column(TypeName = "varchar(max)")]
        public string Email_POC { get; set; }
        [Required]
        [Display(Name = "Address (POC)")]
        [Column(TypeName = "varchar(max)")]
        public string Address_POC { get; set; }

        [Required]
        [Display(Name = "High Qualification (POC)")]
        [Column(TypeName = "varchar(max)")]

        public string HighQualification_POC { get; set; }
        [Required]
        [Display(Name = "Designation (POC)")]
        [Column(TypeName = "varchar(max)")]
        public string Designation_POC { get; set; }
        [Display(Name = "Upload Certification (POC)")]
        [Column(TypeName = "nvarchar(max)")]
        public string UploadCertifications_POC { get; set; }
        [Display(Name = "Upload CV (POC)")]
        [Column(TypeName = "nvarchar(max)")]
        public string UploadCv_POC { get; set; }
        [Column(TypeName = "Date")]
        [Display(Name ="Reg.Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime RegisteredDate { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Column(TypeName = "varchar(15)")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Column(TypeName = "varchar(15)")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }
    }
    public class SchoolCertificate
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Id")]
        public int SchoolID { get; set; }
        [Display(Name = "Upload Certification (POC)")]
        [Column(TypeName = "nvarchar(max)")]
        public string UploadCertifications_POC { get; set; }
        [Display(Name = "Upload CV (POC)")]
        [Column(TypeName = "nvarchar(max)")]
        public string UploadCv_POC { get; set; }
        public virtual int ID { get; set; }
        [ForeignKey("ID")]
        public virtual AddSchoolInfo AddSchoolInfo { get; set; }



    }
}
