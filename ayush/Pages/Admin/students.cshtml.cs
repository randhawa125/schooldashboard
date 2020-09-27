using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ayush.Data;
using ayush.Models;
using ayush.Models.admin;
using Microsoft.AspNetCore.Identity;

namespace ayush.Pages.Admin
{
    public class studentsModel : PageModel
    {
        ayushContext _Context;
        public studentsModel(ayushContext databasecontext)
        {
            _Context = databasecontext;
        }
        public List<StudentViewModel> StudentList { get; set; }
        public void OnGet()
        {
            var data = (from user in _Context.Users
                        join userRole in _Context.UserRoles on user.Id equals userRole.UserId
                        join role in _Context.Roles on userRole.RoleId equals role.Id
                        join userInfo in _Context.UserInformation on user.Id equals userInfo.UserId
                        where role.Name == "Student"
                        select new StudentViewModel()
                        { Firstname = userInfo.Firstname,
                        Lastname = userInfo.Lastname,
                        ClassName = userInfo.ClassName,
                        Address = userInfo.Address,
                        Plan = userInfo.Plan,
                        Id = userInfo.UserId
                        }).ToList();

            StudentList = data;
        }

        public async Task<IActionResult> OnPostUpdatePlan()
        {
            return new OkResult();
        }

        public class StudentViewModel
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Fullname
            {
                get
                {
                    return Firstname + " " + Lastname;
                }
            }
            public string ClassName { get; set; }
            public string Address { get; set; }
            public string Id { get; set; }
            public Plan Plan { get; set; }
        }
    }




  
}
