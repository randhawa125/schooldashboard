using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ayush.Data;
using ayush.Models;
using ayush.Models.admin;

namespace ayush.Pages.Admin
{
    public class counsellorsModel : PageModel
    {
        ayushContext _Context;
        public counsellorsModel(ayushContext databasecontext)
        {
            _Context = databasecontext;
        }
        public List<AddCounsellor> CounsellorList { get; set; }
        public void OnGet()
        {
            var data = (from counsellorlist in _Context.AddCounsellor
                        select counsellorlist).ToList();

            CounsellorList = data;
        }
    }
}
