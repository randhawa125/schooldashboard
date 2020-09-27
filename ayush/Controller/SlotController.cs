using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Helper;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ayush.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private ayushContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        public SlotController(ayushContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("GetSlot")]
        public async Task<IActionResult> GetSlot(string date)
        {
            var user = await _userManager.GetUserAsync(User);

            var slots = SlotHelper.GetAllSlots();

            var counselorSlots = _context.Slots.Where(x => x.BaseUserId == user.Id && x.Date == DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture)).ToList();

            foreach (var slot in slots)
            {
                if(counselorSlots.Any(x => x.StartTime == slot.StartTime && x.EndTime == slot.EndTime))
                {
                    slot.IsAvailable = false;
                }
            }
            
            return Ok(slots);
        }

        [HttpPost]
        [Route("SaveSlots")]
        public async Task<IActionResult> SaveSlots([FromQuery]string date, [FromBody]List<string> slots)
        {
            var user = await _userManager.GetUserAsync(User);

            var counselorSlots = _context.Slots.Where(x => x.BaseUserId == user.Id && x.Date == DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture)).ToList();

            var newSlots = new List<Slot>();

            slots.ForEach(x =>
            {
                newSlots.Add(GetSlotObj(x));
            });

            //var slotsToDelete = counselorSlots.Where(x => newSlots.Any(slot => slot.StartTime == x.StartTime && slot.EndTime == x.EndTime) == false);

            foreach (var slot in slots)
            {
                Slot newSlot = GetSlotObj(slot);
                newSlot.BaseUserId = user.Id;
                newSlot.Date = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                if(counselorSlots.Any(x => x.StartTime == newSlot.StartTime && x.EndTime == newSlot.EndTime) == false)
                {
                    _context.Slots.Add(newSlot);
                }
            }

            //_context.Slots.RemoveRange(slotsToDelete);

            _context.SaveChanges();

            return Ok("Saved Sucessfully");
        }

        [HttpGet]
        [Route("GetStudentSlots")]
        public async Task<IActionResult> GetStudentSlots(string date)
        {
            var checkDate = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            var slots = await (from slot in _context.Slots
                         join studentslot in _context.StudentSlots on 
                         new { slot.Date, slot.StartTime, slot.EndTime } equals new { studentslot.Date, studentslot.StartTime, studentslot.EndTime} into joined
                         from joinedRecord in joined.DefaultIfEmpty()
                         where slot.Date == checkDate && joinedRecord == null
                         select new SlotViewModel()
                         {
                             IsAvailable = true,
                             EndTime = slot.EndTime,
                             StartTime = slot.StartTime
                         }).Distinct().ToListAsync();

            return Ok(slots);
        }

        [HttpPost]
        [Route("BookStudentSession")]
        public async Task<IActionResult> BookStudentSession(string date, string time)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var slotTime = time.Split('-');
                var startTime = DateTime.ParseExact(slotTime[0].Trim(), "hh:mm tt", CultureInfo.InvariantCulture);
                var endTime = DateTime.ParseExact(slotTime[1].Trim(), "hh:mm tt", CultureInfo.InvariantCulture);

                var parsedDate = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                var parsedStartTime = startTime.TimeOfDay;
                var parsedEndTime = endTime.TimeOfDay;

                var studentSlot = new StudentSlot()
                {
                    Date = parsedDate,
                    StartTime = parsedStartTime,
                    EndTime = parsedEndTime,
                    UserId = user.Id
                };

                _context.StudentSlots.Add(studentSlot);
                await _context.SaveChangesAsync();

                var availableCounsellors = await GetAvailableCounsellors(parsedDate, parsedStartTime, parsedEndTime);

                if (availableCounsellors.Any())
                {
                    await BookSession(availableCounsellors.FirstOrDefault().Id, studentSlot.Id);
                }
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("GetAvailableCounsellors")]
        public async Task<IActionResult> GetAvailableCounsellors(string date, string startTime, string endTime)
        {
            var parsedDate = DateTime.Parse(date);
            var parsedStartTime = DateTime.Parse(startTime).TimeOfDay;
            var parsedEndTime = DateTime.Parse(endTime).TimeOfDay;

            var counsellors = await GetAvailableCounsellors(parsedDate, parsedStartTime, parsedEndTime);

            var counsellorVM = counsellors.Select(x => new CounsellorSlotViewModel()
            {
                Id = x.Id,
                Name = x.BaseUser.UserInformations.FirstOrDefault().Firstname + x.BaseUser.UserInformations.FirstOrDefault().Lastname
            }).ToList();

            return Ok(counsellors);
        }

        [HttpPost]
        [Route("SelectCounsellor")]
        public async Task<IActionResult> SelectCounsellor(int counsellorSlotId, int studentSlotId)
        {
            await BookSession(counsellorSlotId, studentSlotId);

            return Ok();
        }

        private async Task BookSession(int counsellorSlotId, int studentSlotId)
        {
            var session = new Session()
            {
                SlotId = counsellorSlotId,
                StudentSlotId = studentSlotId
            };

            await _context.Sessions.AddAsync(session);

            await _context.SaveChangesAsync();
        }

        private static Slot GetSlotObj(string slot)
        {
            var time = slot.Split('-');
            var startTime = DateTime.ParseExact(time[0].Trim(), "hh:mm tt", CultureInfo.InvariantCulture);
            var endTime = DateTime.ParseExact(time[1].Trim(), "hh:mm tt", CultureInfo.InvariantCulture);
            var newSlot = new Slot()
            {
                StartTime = startTime.TimeOfDay,
                EndTime = endTime.TimeOfDay
            };
            return newSlot;
        }

        private async Task<List<Slot>> GetAvailableCounsellors(DateTime parsedDate, TimeSpan parsedStartTime, TimeSpan parsedEndTime)
        {
            var slots = await _context.Slots.Include(x => x.BaseUser).Include(x => x.BaseUser.UserInformations).Include(x => x.BaseUser.Sessions).Include(x => x.Session).Where(x => x.Session == null && x.Date.Date == parsedDate.Date && x.StartTime == parsedStartTime && x.EndTime == parsedEndTime).OrderBy(x => x.BaseUser.Sessions.Count())
                .ToListAsync();

            return slots;
        }

        private string GetName(string userId)
        {
            var userInfo = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
            return userInfo.Firstname + " " + userInfo.Lastname;
        }

        public class CounsellorSlotViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}