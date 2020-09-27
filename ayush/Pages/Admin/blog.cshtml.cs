using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush.Pages.Admin
{
    public class blogModel : PageModel
    {
        private ayushContext _context { get; set; }
        public List<BlogViewModel> Blogs { get; set; }

        public blogModel(ayushContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Blogs = GetBlogs();
        }

        public async Task<IActionResult> OnGetDelete(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();

            return Redirect("~/Admin/blog");

        }

        private List<BlogViewModel> GetBlogs()
        {
            return _context.Blogs.Select(x => new BlogViewModel()
            {
                Id = x.Id,
                IsActive = x.IsActive,
                ClassId = x.ClassId,
                Description = x.Description,
                Title = x.Title,
                SubmittedDate = x.SubmittedDate,
                SubmittedByUserId = x.SubmittedByUserId,
                SubmittedByUserFullName = _context.UserInformation.FirstOrDefault(u => u.UserId == x.SubmittedByUserId).Firstname
                        + " " + _context.UserInformation.FirstOrDefault(u => u.UserId == x.SubmittedByUserId).Lastname
            }).OrderBy(x => x.SubmittedDate).ToList();
        }
    }
}
