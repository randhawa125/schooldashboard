using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class roadmapsModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private ayushContext _context;
        public IdentityUser LoggedInUser { get; set; }
        public UserInformation UserInformation { get; set; }
        public String UserId = string.Empty;
        public roadmapsModel(UserManager<IdentityUser> userManager, ayushContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            UserId = Request.Query["id"];
            UserInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(UserId));
            return Page();
        }
    }
}