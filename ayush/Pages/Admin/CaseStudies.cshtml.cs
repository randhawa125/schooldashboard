using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace ayush.Pages.Admin
{
    public class CaseStudiesModel : PageModel
    {
        private ayushContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        public CaseStudy CaseStudy { get; set; }
        private IHostingEnvironment _environment;
        public bool isSuccessful = false;

        [BindProperty]
        public IFormFile Upload { get; set; }

        public CaseStudiesModel(IHostingEnvironment environment, ayushContext context, UserManager<IdentityUser> userManager)
        {
            _environment = environment;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task OnPost(CaseStudy caseStudy)
        {
            using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    if (Upload.FileName.ToLower().EndsWith(".pdf"))
                    {
                        var user = await _userManager.GetUserAsync(User);
                        String fileName = System.Guid.NewGuid().ToString() + ".pdf";
                        var file = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", fileName);
                        using (var fileStream = new FileStream(file, FileMode.Create))
                        {
                            await Upload.CopyToAsync(fileStream);
                        }

                        var cStudy = new CaseStudy()
                        {
                            CaseTitle = caseStudy.CaseTitle,
                            CaseDescription = caseStudy.CaseDescription,
                            UploadedBy = user.Id,
                            UploadedByStudent = false,
                            FileName = fileName,
                            UploadedOn = DateTime.Now
                        };
                        _context.Entry(cStudy).State = EntityState.Added;
                        await _context.SaveChangesAsync();

                        await transaction.CommitAsync();

                        ModelState.Clear();

                        isSuccessful = true;
                    }
                    else
                    {
                        ModelState.Clear();
                    }
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }
        }
    }
}
