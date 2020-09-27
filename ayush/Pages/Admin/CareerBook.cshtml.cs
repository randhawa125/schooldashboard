using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush.Pages.Admin
{
    public class CareerBookModel : PageModel
    {
        private IHostingEnvironment _environment;

        public CareerBookModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public IFormFile Upload { get; set; }
        public async Task OnPostAsync()
        {
            try
            {
                var file = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", "careersbook.pdf");
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    await Upload.CopyToAsync(fileStream);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
