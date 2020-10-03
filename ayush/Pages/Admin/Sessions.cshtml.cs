using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models.admin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ayush.Pages.Admin
{
    public class SessionsModel : PageModel
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<add_adminModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ayushContext _db;

        [Obsolete]
        public SessionsModel(ayushContext db,
            IHostingEnvironment hostingEnvironment,
   UserManager<IdentityUser> userManager,
   SignInManager<IdentityUser> signInManager,
   ILogger<add_adminModel> logger,
   IEmailSender emailSender)
        {
            _db = db;
            webHostEnvironment = (IWebHostEnvironment)hostingEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }
        [BindProperty]
        public Sessions Sessions { get; set; }
        [BindProperty]
        public List<IFormFile> Upload_Images { get; set; }

        public List<SessionImng> Imngs { get; set; }


        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }
        private string UploadedFile(int ID)
        {
            string uniqueFileName = null;
            if (Upload_Images != null)
            {
                SessionImng SessionsImg = new SessionImng();
                var schooldata = _db.adminsessions.Where(s => s.ID == ID).FirstOrDefault();
                if (Upload_Images != null && Upload_Images.Count != 0)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "SchoolFiles/Session_Images");
                    foreach (IFormFile formfile in Upload_Images)
                    {
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + formfile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            formfile.CopyTo(fileStream);
                        }
                        //SessionsImg.ImgID = 0;

                        SessionsImg.ImgID = 0;
                        SessionsImg.Images = formfile.FileName;
                        SessionsImg.ID = ID;
                        _db.sessionImngs.Add(SessionsImg);
                        _db.SaveChanges();
                    }
                }
            }
            return uniqueFileName;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                //string UploadCertifications_POC = UploadedFile(asi);
               
                    var users = new Sessions
                    {
                     ID=Sessions.ID,
                     Tittle=Sessions.Tittle,
                     Description=Sessions.Description,
                     Images=Sessions.Images
                    };
                    _db.adminsessions.Add(users);
                    _db.SaveChanges();
                    UploadedFile(users.ID);
               

            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}