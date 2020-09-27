using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class StudentInfoViewModel
    {
    }

    public class StudentPersonalInfoVM
    {
        [required]
        public string userId { get; set; }
        [required]
        public string firstName { get; set; }
        public string lastName { get; set; }
        [required]
        public string phoneNumber { get; set; }
        [required]
        //[RegularExpression(@"/^([a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+(\.[a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+)*|"((([ \t] *\r\n)?[ \t] +)?([\x01 -\x08\x0b\x0c\x0e -\x1f\x7f\x21\x23 -\x5b\x5d -\x7e\u00A0-\uD7FF\uF900 -\uFDCF\uFDF0 -\uFFEF]|\\[\x01-\x09\x0b\x0c\x0d-\x7f\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))*(([ \t]*\r\n)?[ \t]+)?")@(([a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.)+([a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.?$/i")]
        public string email { get; set; }
        [required]
        public DateTime dateOfBirth { get; set; }
        [required]
        public string gender { get; set; }
        [required]
        public string address { get; set; }
    }


    public class StudentEducationInfoVM
    {
        [required]
        public string userId { get; set; }
        [required]
        public string studentClass { get; set; }
        public string subject1 { get; set; }
        public string subject2 { get; set; }
        public string subject3 { get; set; }
        public string subject4 { get; set; }
        public string subject5 { get; set; }
        [required]
        public string schoolName { get; set; }
    }

    public class StudentFamilyInfoVM
    {
        [required]
        public string userId { get; set; }
        [required]
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string fatherQualification { get; set; }
        public string motherQualification { get; set; }
        public string fatherProfession { get; set; }
        public string motherProfession { get; set; }
    }

    public class StudentPIVM
    {
        [required]
        public string userId { get; set; }
        //***********************Duplicating this information as these fields are required here***********************
        [required]
        public string fatherName { get; set; }
        [required]
        public string motherName { get; set; }
        [required]
        public string fatherQualification { get; set; }
        [required]
        public string motherQualification { get; set; }
        [required]
        public string fatherProfession { get; set; }
        [required]
        public string motherProfession { get; set; }
        //***********************Duplicating this information as these fields are required here***********************
        [required]
        public string siblings { get; set; }
        public string elderYounger { get; set; }
        public string familyIncome { get; set; }
        public string familyType { get; set; }
        [required]
        public string grades { get; set; }
        public string favouriteSubject { get; set; }
        public string achievements { get; set; }
        public string positionOfResponsibility { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string linkedIn { get; set; }
        public string twitter { get; set; }
        public string numberofFriends { get; set; }
        [required]
        public string bestVacation { get; set; }
        [required]
        public string dreamCareer1 { get; set; }
        [required]
        public string dreamCareer2 { get; set; }
        [required]
        public string motivation { get; set; }
        [required]
        public string whyThisCareer { get; set; }
        [required]
        public string differentlyAbled { get; set; }
        [required]
        public string expectationFromUpclass { get; set; }
        [required]
        public string howYourFriendsDescribeYou { get; set; }
        [required]
        public string howYourParentsDescribeYou { get; set; }
    }
}
