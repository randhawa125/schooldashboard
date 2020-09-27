using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class studentsmodel : PageModel
    {
        private ayushContext _context;
        public List<SessionViewModel> Sessions;

        public studentsmodel(ayushContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Sessions = _context.Sessions.Include(x => x.StudentSlot).Include(x => x.Slot).Select(x => new SessionViewModel()
            {
                Date = x.Slot.Date,
                EndTime = x.Slot.EndTime,
                StartTime = x.Slot.StartTime,
                StudentName = _context.UserInformation.FirstOrDefault(y => y.UserId == x.StudentSlot.UserId).Firstname + " " +
                                    _context.UserInformation.FirstOrDefault(y => y.UserId == x.StudentSlot.UserId).Lastname
            }).ToList();
        }

        public class SessionViewModel
        {
            public string StudentName { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
        }
        private string GetStudentName(string userId)
        {
            var userInfo = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
            return userInfo.Firstname + " " + userInfo.Lastname;
        }
    }
}