using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;

namespace ayush.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private ayushContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public StudentController(ayushContext context, UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("updateStudentPersonalInfo")]
        public async Task<IActionResult> UpdateStudentPersonalInfo(StudentPersonalInfoVM studentPersonalInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            //check if email or phone already exist in the DB    
                            bool duplicateEmail = await _context.Users.AnyAsync(u => u.Id != studentPersonalInfo.userId && u.Email == studentPersonalInfo.email);
                            bool duplicatePhone = await _context.Users.AnyAsync(u => u.Id != studentPersonalInfo.userId && u.PhoneNumber == studentPersonalInfo.phoneNumber);

                            if(duplicateEmail && duplicatePhone)
                            {
                                throw new Exception("Ëmail address and Phone number both already exist!");
                            }
                            else if(duplicateEmail)
                            {
                                throw new Exception("Ëmail address already exist!");
                            }
                            else if(duplicatePhone)
                            {
                                throw new Exception("Phone number both already exist!");
                            }

                            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == studentPersonalInfo.userId);
                            user.Email = studentPersonalInfo.email;
                            user.PhoneNumber = studentPersonalInfo.phoneNumber;
                            await _context.SaveChangesAsync();

                            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(u => u.UserId == studentPersonalInfo.userId);
                            userInfo.Firstname = studentPersonalInfo.firstName;
                            userInfo.Lastname = studentPersonalInfo.lastName;
                            userInfo.DateOfBirth = studentPersonalInfo.dateOfBirth;
                            userInfo.Gender = studentPersonalInfo.gender;
                            userInfo.Address = studentPersonalInfo.address;

                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return Ok();
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return StatusCode(500, ex.Message);
                        }
                    }
                }
                else
                {
                    return StatusCode(500, "Invalid data!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        [Route("updateStudentEducationInfo")]
        public async Task<IActionResult> UpdateStudentEducationInfo(StudentEducationInfoVM studentEducationInfo)
        {
            //Transaction is not really needed on other sections as all the data is getting saved in the same table.
            //Still keeping it in case, in future we might want to plugh in some other table data, so transaction would already be there.
            try
            {
                if (ModelState.IsValid)
                {
                    using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(u => u.UserId == studentEducationInfo.userId);
                            userInfo.ClassName = studentEducationInfo.studentClass;
                            userInfo.Subject1 = studentEducationInfo.subject1;
                            userInfo.Subject2 = studentEducationInfo.subject2;
                            userInfo.Subject3 = studentEducationInfo.subject3;
                            userInfo.Subject4 = studentEducationInfo.subject4;
                            userInfo.Subject5 = studentEducationInfo.subject5;
                            userInfo.SchoolName = studentEducationInfo.schoolName;

                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return Ok();
                        }

                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return StatusCode(500, ex.Message);
                        }
                    }
                }
                else
                {
                    return StatusCode(500, "Invalid data!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        [Route("updateStudentFamilyInfo")]
        public async Task<IActionResult> UpdateStudentFamilyInfo(StudentFamilyInfoVM studentFamilyInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(u => u.UserId == studentFamilyInfo.userId);
                            userInfo.FatherName = studentFamilyInfo.fatherName;
                            userInfo.MotherName = studentFamilyInfo.motherName;
                            userInfo.FatherQualification = studentFamilyInfo.fatherQualification;
                            userInfo.MotherQualification = studentFamilyInfo.motherQualification;
                            userInfo.FatherProfession = studentFamilyInfo.fatherProfession;
                            userInfo.MotherProfession = studentFamilyInfo.motherProfession;

                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return Ok();
                        }

                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return StatusCode(500, ex.Message);
                        }
                    }
                }
                else
                {
                    return StatusCode(500, "Invalid data!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost]
        [Route("updateStudentPI")]
        public async Task<IActionResult> UpdateStudentPI(StudentPIVM studentPIVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(u => u.UserId == studentPIVM.userId);
                            userInfo.FatherName = studentPIVM.fatherName;
                            userInfo.MotherName = studentPIVM.motherName;
                            userInfo.FatherQualification = studentPIVM.fatherQualification;
                            userInfo.MotherQualification = studentPIVM.motherQualification;
                            userInfo.FatherProfession = studentPIVM.fatherProfession;
                            userInfo.MotherProfession = studentPIVM.motherProfession;
                            userInfo.Siblings = studentPIVM.siblings;
                            userInfo.ElderorYounger = studentPIVM.elderYounger;
                            userInfo.FamilyIncome = studentPIVM.familyIncome;
                            userInfo.FamilyType = studentPIVM.familyType;
                            userInfo.Grades = studentPIVM.grades;
                            userInfo.FavoriteSubject = studentPIVM.favouriteSubject;
                            userInfo.Achievements = studentPIVM.achievements;
                            userInfo.PositionOfResponsibility = studentPIVM.positionOfResponsibility;
                            userInfo.Facebook = studentPIVM.facebook;
                            userInfo.Instagram = studentPIVM.instagram;
                            userInfo.Linkedin = studentPIVM.linkedIn;
                            userInfo.Twitter = studentPIVM.twitter;
                            userInfo.HowManyFriends = studentPIVM.numberofFriends;
                            userInfo.BestVacation = studentPIVM.bestVacation;
                            userInfo.DreamCareer1 = studentPIVM.dreamCareer1;
                            userInfo.DreamCareer2 = studentPIVM.dreamCareer2;
                            userInfo.WhatMotivatesYou = studentPIVM.motivation;
                            userInfo.WhyThisCareer = studentPIVM.whyThisCareer;
                            userInfo.DifferentlyAbled = studentPIVM.differentlyAbled;
                            userInfo.ExpectationsFromUpclass = studentPIVM.expectationFromUpclass;
                            userInfo.HowYourFriendsDescribeYou = studentPIVM.howYourFriendsDescribeYou;
                            userInfo.HowYourParentsDecribeYou = studentPIVM.howYourParentsDescribeYou;

                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return Ok();
                        }

                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return StatusCode(500, ex.Message);
                        }
                    }
                }
                else
                {
                    return StatusCode(500, "Invalid data!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet]
        [Route("removeProfilePicture")]
        public async Task<bool> RemoveProfilePicture()
        {
            try
            {
                var LoggedInUser = await _userManager.GetUserAsync(User);
                var userInfo = _context.UserInformation.FirstOrDefault(u => u.UserId == LoggedInUser.Id);
                userInfo.ProfilePictureFilePath = null;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        [Route("RegisteredUsers")]
        public async Task<IActionResult> RegisteredUsers(string userId)
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            //var customerData = (from tempcustomer in context.Customers select tempcustomer);
            var LoggedInUser = await _userManager.GetUserAsync(User);
            var userInfo = (from u in _context.UserInformation
                            join u2 in _context.Users on u.UserId equals u2.Id
                            where u.InvitedByUserId == LoggedInUser.Id
                            orderby u.Firstname + " " + u.Lastname
                            select new RegisteredUsersVM
                            {
                                FullName = u.Firstname + " " + u.Lastname,
                                Email = u2.Email,
                                CreatedOn = u.CreatedOn
                            });

            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            //{
            //    userInfo = userInfo.OrderBy(sortColumn + " " + sortColumnDirection);
            //}
            if (!string.IsNullOrEmpty(searchValue))
            {
                userInfo = userInfo.Where(m => m.FullName.Contains(searchValue)
                                            || m.Email.Contains(searchValue));
            }
            recordsTotal = userInfo.Count();
            var data = userInfo.Skip(skip).Take(pageSize).ToList();
            var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return Ok(jsonData);
        }

        [HttpPost]
        [Route("EnrolledUsers")]
        public async Task<IActionResult> EnrolledUsers(string userId)
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            //var customerData = (from tempcustomer in context.Customers select tempcustomer);
            var LoggedInUser = await _userManager.GetUserAsync(User);
            var userInfo = (from u in _context.UserInformation
                            join u2 in _context.Users on u.UserId equals u2.Id
                            where u.InvitedByUserId == LoggedInUser.Id && (u.PlanId != null || u.PlanId != 0)
                            orderby u.Firstname + " " + u.Lastname
                            select new EnrolledUsersVM
                            {
                                FullName = u.Firstname + " " + u.Lastname,
                                Email = u2.Email,
                                PlanPurchaseDate = u.PlanPurchaseDate
                            });

            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            //{
            //    userInfo = userInfo.OrderBy(sortColumn + " " + sortColumnDirection);
            //}
            if (!string.IsNullOrEmpty(searchValue))
            {
                userInfo = userInfo.Where(m => m.FullName.Contains(searchValue)
                                            || m.Email.Contains(searchValue));
            }
            recordsTotal = userInfo.Count();
            var data = userInfo.Skip(skip).Take(pageSize).ToList();
            var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return Ok(jsonData);
        }

        [HttpPost]
        [Route("CaseStudies")]
        public async Task<IActionResult> CaseStudies(string userId)
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            var LoggedInUser = await _userManager.GetUserAsync(User);
            var caseStudy = (from u in _context.CaseStudy
                             where u.UploadedByStudent == false
                             orderby u.UploadedOn descending
                             select new CaseStudyVM
                             {
                                 Id = u.Id,
                                 CaseTitle = u.CaseTitle,
                                 CaseDescription = u.CaseDescription,
                                 UploadedBy = u.UploadedBy,
                                 UploadedOn = u.UploadedOn,
                                 FileName = _configuration.GetValue<string>("WebsiteURL") + "/uploads/" + u.FileName
                             });

            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            //{
            //    caseStudy = caseStudy.OrderBy(sortColumn + " " + sortColumnDirection);
            //}
            if (!string.IsNullOrEmpty(searchValue))
            {
                caseStudy = caseStudy.Where(m => m.CaseTitle.Contains(searchValue)
                                            || m.CaseDescription.Contains(searchValue));
            }
            recordsTotal = caseStudy.Count();
            var data = caseStudy.Skip(skip).Take(pageSize).ToList();
            for (int i = 0; i < data.Count(); i++)
            {
                data[i].SrNo = skip + 1;
                skip = skip + 1;
            }
            var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return Ok(jsonData);
        }

        [HttpPost]
        [Route("studentCaseStudies")]
        public async Task<IActionResult> StudentCaseStudies(string userId)
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            var LoggedInUser = await _userManager.GetUserAsync(User);
            var caseStudy = (from c in _context.CaseStudy
                             join u in _context.UserInformation on c.UploadedBy equals u.UserId
                             where c.UploadedByStudent == true
                             orderby c.UploadedOn descending
                             select new StudentCaseStudy
                             {
                                 Id = c.Id,
                                 StudentName = u.Firstname + " " + u.Lastname,
                                 UploadedOn = c.UploadedOn,
                                 FileName = _configuration.GetValue<string>("WebsiteURL") + "/uploads/" + c.FileName
                             });

            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            //{
            //    caseStudy = caseStudy.OrderBy(sortColumn + " " + sortColumnDirection);
            //}
            if (!string.IsNullOrEmpty(searchValue))
            {
                caseStudy = caseStudy.Where(m => m.StudentName.Contains(searchValue));
            }
            recordsTotal = caseStudy.Count();
            var data = caseStudy.Skip(skip).Take(pageSize).ToList();
            for (int i = 0; i < data.Count(); i++)
            {
                data[i].SrNo = skip + 1;
                skip = skip + 1;
            }
            var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return Ok(jsonData);
        }

        [HttpGet]
        [Route("removeCaseStudy")]
        public async Task<bool> RemoveCaseStudy(int id)
        {
            try
            {
                var LoggedInUser = await _userManager.GetUserAsync(User);
                var CS = _context.CaseStudy.FirstOrDefault(c => c.Id == Convert.ToInt32(id));
                _context.CaseStudy.Remove(CS);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
