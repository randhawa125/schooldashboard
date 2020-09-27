using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ayush.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadmapController : ControllerBase
    {
        private ayushContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        public IdentityUser LoggedInUser { get; set; }
        //public UserInformation UserInformation { get; set; }

        public RoadmapController(ayushContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("updateRoadmap")]
        public async Task<IActionResult> UpdateRoadmap(RoadmapViewModel roadmap)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(u => u.UserId == roadmap.UserId);

                            userInfo.CareerPathOne1 = roadmap.CareerPathOne1;
                            userInfo.CareerPathOne2 = roadmap.CareerPathOne2;
                            userInfo.CareerPathOne3 = roadmap.CareerPathOne3;
                            userInfo.CareerPathOne4 = roadmap.CareerPathOne4;
                            userInfo.CareerPathOne5 = roadmap.CareerPathOne5;

                            userInfo.CareerPathTwo1 = roadmap.CareerPathTwo1;
                            userInfo.CareerPathTwo2 = roadmap.CareerPathTwo2;
                            userInfo.CareerPathTwo3 = roadmap.CareerPathTwo3;
                            userInfo.CareerPathTwo4 = roadmap.CareerPathTwo4;
                            userInfo.CareerPathTwo5 = roadmap.CareerPathTwo5;

                            userInfo.CareerPathThree1 = roadmap.CareerPathThree1;
                            userInfo.CareerPathThree2 = roadmap.CareerPathThree2;
                            userInfo.CareerPathThree3 = roadmap.CareerPathThree3;
                            userInfo.CareerPathThree4 = roadmap.CareerPathThree4;
                            userInfo.CareerPathThree5 = roadmap.CareerPathThree5;

                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return Ok();
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return StatusCode(500, ex.Message);
                        }
                    }
                }
                else
                {
                    return StatusCode(500, "Invalid data!");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Invalid data!");
            }
        }
    }
}
