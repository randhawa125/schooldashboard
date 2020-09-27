using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ayush.Services
{
    public class UserService
	{
		private ayushContext _context { get; set; }
		private readonly UserManager<IdentityUser> _userManager;
		public UserService(ayushContext context, UserManager<IdentityUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		public bool IsPlanPurchased(ClaimsPrincipal user)
		{
			var userId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

			if (userId != null)
			{
				var userInformation = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
				if(userInformation != null)
				{
					return userInformation.PlanId.HasValue;
				}
			}

			return false;
		}

		public bool HasGivenAllTests(ClaimsPrincipal user)
		{
			var userId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

			if (userId != null)
			{
				bool hasGivenPersonalityTest = _context.StudentModuleThreeMarks.Any(x => x.UserId == userId);
				bool hasGivenAptitudeTest = _context.StudentQuizzes.Count(x => x.UserId == userId) == 8;
				bool hasGivenEQTest = _context.StudentModuleFiveMarks.Any(x => x.UserId == userId);
				bool hasGivenMotivatorTest = _context.StudentModuleTwoMarks.Any(x => x.UserId == userId);
				bool hasGivenIntertestTest = _context.StudentModuleOneMarks.Any(x => x.UserId == userId);
				return hasGivenIntertestTest && hasGivenAptitudeTest && hasGivenEQTest && hasGivenMotivatorTest && hasGivenPersonalityTest;
			}

			return false;
		}

		public string GetUserFullame(ClaimsPrincipal user)
		{
			var userId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

			if (userId != null)
			{
				var userInformation = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
				if (userInformation != null)
				{
					return userInformation.Firstname + " " + userInformation.Lastname;
				}
			}
			return null;
		}

		public string GetUserProfilePicturePath(ClaimsPrincipal user)
		{
			var userId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

			if (userId != null)
			{
				var userInformation = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
				if (userInformation != null)
				{
					return userInformation.ProfilePictureFilePath;
				}
			}
			return null;
		}


		public async Task<string> CalculatePercentage(ClaimsPrincipal user)
		{
			string percetange = "";
			double availableValue = 0;
			double value = 0;

			var loggedInUser = await _userManager.GetUserAsync(user);
			if(loggedInUser == null)
			{
				return "0 %";
			}
			var userInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(loggedInUser.Id));

			if (loggedInUser != null)
			{ if (!string.IsNullOrEmpty(loggedInUser.PhoneNumber)) { availableValue += 1; } }

			if (userInformation != null)
			{
				if (!string.IsNullOrEmpty(userInformation.Firstname))
				{ availableValue += 1; }

				if (userInformation.DateOfBirth.HasValue)
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.Lastname))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.Gender))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.Address))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.ClassName))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.SchoolName))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.FatherName))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.MotherName))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.FatherProfession))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.MotherProfession))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.FatherQualification))
				{ availableValue += 1; }

				if (!string.IsNullOrEmpty(userInformation.MotherQualification))
				{ availableValue += 1; }
			}

			value = (availableValue / 14) * 100;
			percetange = Convert.ToInt32(value).ToString() + "%";

			return percetange;
		}
	}
}
