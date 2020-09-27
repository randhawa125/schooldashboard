using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush
{
    public class edit_notificationModel : PageModel
    {
        private ayushContext _context { get; set; }
        public NotificationViewModel NotificationVM { get; set; }
        public edit_notificationModel(ayushContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                NotificationVM = _context.Notifications.Select(x => new NotificationViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    IsActive = x.IsActive,
                    CreatedByUserId = x.CreatedByUserId,
                    CreatedDate = x.CreatedDate,
                    Description = x.Description,
                    EndDate = x.EndDate
                }).FirstOrDefault();
            }
            else
            {
                NotificationVM = new NotificationViewModel() { EndDate = DateTime.Now };
            }
        }
        public async Task<IActionResult> OnPost(int? id, NotificationViewModel notificationVM)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.ToList().FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                if (id.HasValue)
                {
                    var dbNotification = _context.Notifications.FirstOrDefault(x => x.Id == id.Value);
                    dbNotification.Title = notificationVM.Title;
                    dbNotification.Description = notificationVM.Description;
                    dbNotification.IsActive = notificationVM.IsActive;
                    dbNotification.EndDate = notificationVM.EndDate;
                }
                else
                {
                    var notification = new Notification()
                    {
                        Title = notificationVM.Title,
                        Description = notificationVM.Description,
                        IsActive = notificationVM.IsActive,
                        CreatedByUserId = userId,
                        CreatedDate = DateTime.Now,
                        EndDate = notificationVM.EndDate
                    };

                    _context.Notifications.Add(notification);
                }

                await _context.SaveChangesAsync();

                return Redirect("~/admin/notification");
            }
            else
            {
                NotificationVM = notificationVM;
                return Page();
            }
        }
    }
}