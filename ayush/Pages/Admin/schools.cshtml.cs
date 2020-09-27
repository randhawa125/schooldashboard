using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Models.admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ayush.Models;
using ayush.Data;

namespace ayush.Pages.Admin
{
    public class schoolsModel : PageModel
    {
        ayushContext _Context;
        public schoolsModel(ayushContext databasecontext)
        {
            _Context = databasecontext;
        }
        public List<AddSchool> SchoolList { get; set; }
        public void OnGet()
        {
            var data = (from schoollist in _Context.AddSchool
                        select schoollist).ToList();

            SchoolList = data;
        }
    }
}
