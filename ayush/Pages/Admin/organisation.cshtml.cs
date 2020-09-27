using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.admin;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush.Pages.Admin
{
    public class organisationModel : PageModel
    {
        private readonly ayushContext _context;
        public bool ShowSuccess = false;
        public organisationModel(ayushContext databasecontext)
        {
            _context = databasecontext;
        }
        public List<SystemInformation> SystemInformation { get; set; }

        public void OnGet()
        {
            SystemInformation = _context.SystemInformation.ToList();
        }


        public ActionResult OnPost()
        {
            SaveData(Request);

            ShowSuccess = true;

            SystemInformation = _context.SystemInformation.ToList();

            return Page();
            //return Redirect("~/Admin/Dashboard");
        }

        private void SaveData(HttpRequest request)
        {
            foreach (var property in _context.SystemInformation)
            {
                property.PropertyValue = request.Form[property.PropertyName];
            }
            _context.SaveChanges();
        }
    }
}
