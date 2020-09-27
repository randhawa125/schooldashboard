using System;
using System.ComponentModel.DataAnnotations;

namespace ayush.Models
{
    public class UserInformation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ProfilePictureFilePath { get; set; }
        public string Address { get; set; }
        public string ClassName { get; set; }
        public string SchoolName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherProfession { get; set; }
        public string MotherProfession { get; set; }
        public string FatherQualification { get; set; }
        public string MotherQualification { get; set; }
        public int? FirstCareerId { get; set; }
        public virtual Career FirstCareer { get; set; }
        public int? SecondCareerId { get; set; }
        public virtual Career SecondCareer { get; set; }
        public int? ThirdCareerId { get; set; }
        public virtual Career ThirdCareer { get; set; }
        public int? FirstPassiveCareerId { get; set; }
        public int? SecondPassiveCareerId { get; set; }
        public int? ThirdPassiveCareerId { get; set; }
        public bool IsPlanPurchased { get; set; }
        public string LastTest { get; set; }
        public int? PlanId { get; set; }
        public DateTime? PlanPurchaseDate { get; set; }
        public virtual Plan Plan { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CodeSentOn { get; set; }
        public string Code { get; set; }
        public bool? IscodeUsed { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public string Subject4 { get; set; }
        public string Subject5 { get; set; }

        public string DreamCareer1 { get; set; }
        public string DreamCareer2 { get; set; }
        public string WhatMotivatesYou { get; set; }


        public string InvitedByUserId { get; set; }
        public virtual BaseUser IdentityUser { get; set; }



        public string Siblings { get; set; }
        public string ElderorYounger { get; set; }
        public string FamilyIncome { get; set; }
        public string FamilyType { get; set; }
        public string Grades { get; set; }
        public string FavoriteSubject { get; set; }
        public string Achievements { get; set; }
        public string PositionOfResponsibility { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }

        public string HowManyFriends { get; set; }
        public string BestVacation { get; set; }
        public string WhyThisCareer { get; set; }
        public string DifferentlyAbled { get; set; }
        public string ExpectationsFromUpclass { get; set; }
        public string HowYourFriendsDescribeYou { get; set; }
        public string HowYourParentsDecribeYou { get; set; }
        public string CareerPathOne1 { get; set; }
        public string CareerPathOne2 { get; set; }
        public string CareerPathOne3 { get; set; }
        public string CareerPathOne4 { get; set; }
        public string CareerPathOne5 { get; set; }
        public string CareerPathTwo1 { get; set; }
        public string CareerPathTwo2 { get; set; }
        public string CareerPathTwo3 { get; set; }
        public string CareerPathTwo4 { get; set; }
        public string CareerPathTwo5 { get; set; }
        public string CareerPathThree1 { get; set; }
        public string CareerPathThree2 { get; set; }
        public string CareerPathThree3 { get; set; }
        public string CareerPathThree4 { get; set; }
        public string CareerPathThree5 { get; set; }
    }
}
