using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush
{
    public class notificationModel : PageModel
    {
        private ayushContext _context { get; set; }
        public List<NotificationViewModel> Notifications { get; set; }
        public notificationModel(ayushContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Notifications = GetNotifications();
        }

        public async Task<IActionResult> OnGetDelete(int id)
        {
            var notification = _context.Notifications.FirstOrDefault(x => x.Id == id);
            _context.Notifications.Remove(notification);
            await _context.SaveChangesAsync();

            return Redirect("~/Admin/blog");

        }

        private List<NotificationViewModel> GetNotifications()
        {
            return _context.Notifications.Select(x => new NotificationViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                CreatedByUserId = x.CreatedByUserId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                IsActive = x.IsActive,
                CreatedByUserFullName = _context.UserInformation.FirstOrDefault(u => u.UserId == x.CreatedByUserId).Firstname
                        + " " + _context.UserInformation.FirstOrDefault(u => u.UserId == x.CreatedByUserId).Lastname
            }).OrderBy(x => x.CreatedDate).ToList();
        }
    }
}