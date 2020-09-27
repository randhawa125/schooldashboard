using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using ayush.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ayush.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudenModuleMarksController : ControllerBase
	{
		private ayushContext _context { get; set; }
		private readonly UserManager<IdentityUser> _userManager;
		private CareerService _careerService { get; set; }
		private PassiveCareerService _passiveCareerService { get; set; }
		private readonly IMapper _mapper;

		public StudenModuleMarksController(ayushContext context, UserManager<IdentityUser> userManager, CareerService careerService, IMapper mapper, PassiveCareerService passiveCareerService)
		{
			_context = context;
			_userManager = userManager;
			_careerService = careerService;
			_mapper = mapper;
			_passiveCareerService = passiveCareerService;
		}

		[HttpPost]
		[Route("addModuleOneMarks")]
		public async Task<IActionResult> AddModuleOneMarks(StudentModuleOneMarksVM userSkills)
		{
			try
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
				{
					if (_context.StudentModuleOneMarks.Any(x => x.UserId == user.Id))
					{
						return BadRequest("Student has already attempted the test!");
					}
					else
					{
						var studentModuleOneMarks = _mapper.Map<StudentModuleOneMarks>(userSkills);
						studentModuleOneMarks.UserId = user.Id;

						_context.StudentModuleOneMarks.Add(studentModuleOneMarks);

						foreach (var career in userSkills.Question6Careers)
						{
							var interestModuleQuestion6UserCareer = new InterestModuleQuestion6UserCareer()
							{
								CareerDataId = career.Data_Id,
								CareerName = career.Name
							};
							interestModuleQuestion6UserCareer.UserId = user.Id;
							_context.InterestModuleQuestion6UserCareers.Add(interestModuleQuestion6UserCareer);
						}

						foreach (var career in userSkills.Question7Careers)
						{
							var interestModuleQuestion7UserCareer = new InterestModuleQuestion7UserCareer()
							{
								CareerDataId = career.Data_Id,
								CareerName = career.Name
							};
							interestModuleQuestion7UserCareer.UserId = user.Id;
							_context.InterestModuleQuestion7UserCareers.Add(interestModuleQuestion7UserCareer);
						}

						foreach (var career in userSkills.Question8Careers)
						{
							var interestModuleQuestion8UserCareer = new InterestModuleQuestion8UserCareer()
							{
								CareerDataId = career.Data_Id,
								CareerName = career.Name
							};
							interestModuleQuestion8UserCareer.UserId = user.Id;
							_context.InterestModuleQuestion8UserCareers.Add(interestModuleQuestion8UserCareer);
						}

						if ((await _context.SaveChangesAsync()) > 0)
						{
							//_careerService.SaveCareers(user.Id);
							//_passiveCareerService.SaveCareers(user.Id);
							return Ok();
						}
						else
						{
							return StatusCode(500, "Error occured while saving data. Please resubmit your response!");
						}
					}
				}

				return Unauthorized();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("addModuleTwoMarks")]
		public async Task<IActionResult> AddModuleTwoMarks(StudentModuleTwoMarks userSkills)
		{
			try
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
				{
					if (_context.StudentModuleTwoMarks.Any(x => x.UserId == user.Id))
					{
						return BadRequest("Student has already attempted the test!");
					}
					else
					{
						userSkills.UserId = user.Id;
						_context.StudentModuleTwoMarks.Add(userSkills);

						if ((await _context.SaveChangesAsync()) > 0)
						{
							return Ok();
						}
						else
						{
							return StatusCode(500, "Error occured while saving data. Please try to submit your changes again!");
						}
					}
				}

				return Unauthorized();
			}
			catch(Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}


		[HttpPost]
		[Route("addModuleThreeMarks")]
		public async Task<IActionResult> AddModuleThreeMarks(StudentModuleThreeMarks userSkills)
		{
			try
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
				{
					if (_context.StudentModuleThreeMarks.Any(x => x.UserId == user.Id))
					{
						return BadRequest("Student has already attempted the test!");
					}
					else
					{
						userSkills.UserId = user.Id;
						_context.StudentModuleThreeMarks.Add(userSkills);

						if ((await _context.SaveChangesAsync()) > 0)
						{
							return Ok();
						}
						else
						{
							return StatusCode(500, "Error occured while saving data. Please try to submit your changes again!");
						}
					}
				}

				return Unauthorized();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}


		[HttpPost]
		[Route("addModuleFourMarks")]
		public async Task<IActionResult> AddModuleFourMarks(StudentModuleFourMarks userSkills)
		{
			//var user = await _userManager.GetUserAsync(User);
			//if (user != null)
			//{
			//    if (_context.StudentModuleFourMarks.Any(x => x.UserId == user.Id))
			//    {
			//        return BadRequest("Student has already attempted the test");
			//    }
			//    else
			//    {
			//        //userSkills.UserId = user.Id;
			//        _context.StudentModuleFourMarks.Add(userSkills);

			//        if ((await _context.SaveChangesAsync()) > 0)
			//        {
			//            return Ok();
			//        }
			//        else
			//        {
			//            return StatusCode(500);
			//        }
			//    }
			//}

			return Unauthorized();
		}


		[HttpPost]
		[Route("addModuleFiveMarks")]
		public async Task<IActionResult> AddModuleFiveMarks(StudentModuleFiveMarks userSkills)
		{
			try
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
				{
					if (_context.StudentModuleFiveMarks.Any(x => x.UserId == user.Id))
					{
						return BadRequest("Student has already attempted the test!");
					}
					else
					{
						userSkills.UserId = user.Id;
						_context.StudentModuleFiveMarks.Add(userSkills);

						if ((await _context.SaveChangesAsync()) > 0)
						{
							return Ok();
						}
						else
						{
							return StatusCode(500, "Error occured while saving data. Please try to resubmit your response!");
						}
					}
				}

				return Unauthorized();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}
	}
}