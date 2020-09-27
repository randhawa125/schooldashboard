using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class student_sessionsModel : PageModel
    {
        private ayushContext _context { get; set; }
        public List<StudentSlotViewModel> StudentSlots { get; set; }

        public student_sessionsModel(ayushContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            StudentSlots = GetStudentSlots();
        }

        public List<StudentSlotViewModel> GetStudentSlots()
        {
            return _context.StudentSlots.Include(x => x.Session).Select(x => new StudentSlotViewModel()
            {
                Id = x.Id,
                Date = x.Date,
                EndTime = x.EndTime,
                StartTime = x.StartTime,
                UserId = x.UserId,
                IsBooked = x.Session != null,
                Firstname = _context.UserInformation.FirstOrDefault(u => u.UserId == x.UserId).Firstname,
                Lastname = _context.UserInformation.FirstOrDefault(u => u.UserId == x.UserId).Lastname,
            }).ToList();
        }

        public class StudentSlotViewModel
        {
            public int Id { get; set; }
            public string UserId { get; set; }
            public bool IsBooked { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Fullname
            {
                get
                {
                    return Firstname + " " + Lastname;
                }
            }
        }
    }
}