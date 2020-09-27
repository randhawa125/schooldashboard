using System;
using System.ComponentModel.DataAnnotations;

namespace ayush.Resource
{
    public class EditUserProfile
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Class name is required")]
        public string ClassName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "School name is required")]
        public string SchoolName { get; set; }


      

       // [Required(AllowEmptyStrings = false, ErrorMessage = "Father name is required")]
        public string FatherName { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Mother name is required")]
        public string MotherName { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Father profession is required")]
        public string FatherProfession { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Mother profession is required")]
        public string MotherProfession { get; set; }

       // [Required(AllowEmptyStrings = false, ErrorMessage = "Father qualification is required")]
        public string FatherQualification { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Mother qalification is required")]
        public string MotherQualification { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public string Subject4 { get; set; }
        public string Subject5 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Dream Career 1 required")]
        public string DreamCareer1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Dream Career 2 required")]
        public string DreamCareer2 { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "What motivates you field is required")]
        public string WhatMotivatesYou { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Siblings required")]
        public string Siblings { get; set; }

       
        public string ElderorYounger { get; set; }

       
        public string FamilyIncome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Family type required")]
        public string FamilyType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Grades required")]
        public string Grades { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Favorite Subject or interests required")]
        public string FavoriteSubject { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Achievements required")]
        public string Achievements { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Position of responsibility required")]
        public string PositionOfResponsibility { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "How many number of friends you have required")]
        public string HowManyFriends { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tell us about your best vacation")]
        public string BestVacation { get; set; }




        [Required(AllowEmptyStrings = false, ErrorMessage = "Why do you like this career required")]
        public string WhyThisCareer { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Are you differently abled required")]
        public string DifferentlyAbled { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Expectations From Upclass required")]
        public string ExpectationsFromUpclass { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "How would your friends describe you required")]
        public string HowYourFriendsDescribeYou { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "How would your parents decribe you required")]
        public string HowYourParentsDecribeYou { get; set; }
    }
}
