﻿using ayush.Data;
using ayush.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Services
{
	public class CareerService
	{
		private ayushContext _context { get; set; }
		public CareerService(ayushContext context)
		{
			_context = context;
		}
		public List<Career> GetCareers(string userId)
		{
			var user = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
			List<Career> careers = new List<Career>();
			if (user.FirstCareerId.HasValue && user.SecondCareerId.HasValue && user.ThirdCareerId.HasValue)
			{
				careers.Add(_context.Careers.FirstOrDefault(x => x.Id == user.FirstCareerId));
				careers.Add(_context.Careers.FirstOrDefault(x => x.Id == user.SecondCareerId));
				careers.Add(_context.Careers.FirstOrDefault(x => x.Id == user.ThirdCareerId));
			}
			return careers;
		}

		public void SaveCareers(string userId)
		{
			var firstMarks = _context.StudentModuleOneMarks.FirstOrDefault(x => x.UserId == userId);
			var secondMarks = _context.StudentModuleTwoMarks.FirstOrDefault(x => x.UserId == userId);
			var thirdMarks = _context.StudentModuleThreeMarks.FirstOrDefault(x => x.UserId == userId);
			var fourthMarks = _context.StudentModuleFourMarks.FirstOrDefault(x => x.UserId == userId);
			var fifthMarks = _context.StudentModuleFiveMarks.FirstOrDefault(x => x.UserId == userId);

			List<Career> userCareers = new List<Career>();

			List<Career> searchCareers = _context.Careers.ToList();

			//First Pass
			foreach (var career in searchCareers)
			{
				//check if all the factors have values above 6.5
				if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5)
					&& DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5)
						&& DoEQFactorsMatch(career, fifthMarks, (decimal)6.5))
				{
					userCareers.Add(career);
				}
			}


			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)6.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)3.5) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)6.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)3.5) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)6.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)3.5) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)6.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)3.5) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)6.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)3.5))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}

			if (userCareers.Count < 3)
			{
				var careers = new List<Career>();
				foreach (var career in searchCareers.Except(userCareers))
				{
					if (DoPersonalityFactorsMatch(career, thirdMarks, (decimal)0) && DoAptitudeFactorsMatch(career, fourthMarks, (decimal)0) && DoEQFactorsMatch(career, fifthMarks, (decimal)0) && DoMotivationFactorsMatch(career, secondMarks, (decimal)0) && DoInterestFactorsMatch(career, firstMarks, (decimal)0))
					{
						careers.Add(career);
					}
				}
				int careersLeft = 3 - userCareers.Count;
				userCareers.AddRange(GetTopNCareers(careers, careersLeft, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks));
			}



			if (userCareers.Count == 3)
			{
				var careerArray = userCareers.ToArray();
				SaveUserCareers(userId, careerArray);
			}
			else if (userCareers.Count > 3) //If more than 3
			{
				Career[] careerArray = GetTopNCareers(userCareers, 3, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks);
				SaveUserCareers(userId, careerArray);
			}
		}

		private void SaveUserCareers(string userId, Career[] careerArray)
		{
			if (careerArray.Count() == 3)
			{

				var user = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
				user.FirstCareerId = careerArray[0].Id;
				user.SecondCareerId = careerArray[1].Id;
				user.ThirdCareerId = careerArray[2].Id;

				_context.SaveChanges();
			}
		}

		private Career[] GetTopNCareers(List<Career> careers, int n, StudentModuleOneMarks firstMarks, StudentModuleTwoMarks secondMarks, StudentModuleThreeMarks thirdMarks, StudentModuleFourMarks fourthMarks, StudentModuleFiveMarks fifthMarks)
		{
			List<CareerViewModel> sortedCareers = new List<CareerViewModel>();

			foreach (var career in careers)
			{
				CareerViewModel careerView = GetCareerWithSten(career, firstMarks, secondMarks, thirdMarks, fourthMarks, fifthMarks);
				sortedCareers.Add(careerView);
			}

			sortedCareers = sortedCareers.OrderByDescending(x => x.TotalSten).ThenByDescending(x => x.PersonalitySten)
				.ThenByDescending(x => x.AptitudeSten)
				.ThenByDescending(x => x.EQSten)
				.ThenByDescending(x => x.MotivatorSten)
				.ThenByDescending(x => x.InterestSten).Take(n).ToList();



			var careerArray = sortedCareers.Select(x => x.Career).ToArray();
			return careerArray;
		}

		private CareerViewModel GetCareerWithSten(Career career, StudentModuleOneMarks firstMarks, StudentModuleTwoMarks secondMarks, StudentModuleThreeMarks thirdMarks, StudentModuleFourMarks fourthMarks, StudentModuleFiveMarks fifthMarks)
		{
			var careerVM = new CareerViewModel();
			//careerVM.CareerId = career.Id;
			//careerVM.Name = career.Name;
			careerVM.Career = career;
			decimal aptitudeStenSum = 0;
			foreach (var factor in career.AptitudeFactors.Split(','))
			{
				aptitudeStenSum += Convert.ToDecimal(fourthMarks.GetType().GetProperty(factor.Trim()).GetValue(fourthMarks));
			}
			careerVM.AptitudeSten = GetAptitudeSten(aptitudeStenSum, career);

			decimal personalitySum = 0;
			foreach (var factor in career.PersonalityFactors.Split(','))
			{
				personalitySum += Convert.ToDecimal(thirdMarks.GetType().GetProperty(factor.Trim()).GetValue(thirdMarks));
			}
			careerVM.PersonalitySten = GetPersonalitySten(personalitySum, career);

			decimal interestSum = 0;
			foreach (var factor in career.InterestFactors.Split(','))
			{
				interestSum += Convert.ToDecimal(firstMarks.GetType().GetProperty(factor.Trim()).GetValue(firstMarks));
			}
			careerVM.InterestSten = GetInterestSten(interestSum, career);

			decimal MotivatorSum = 0;
			foreach (var factor in career.MotivatorFactors.Split(','))
			{
				MotivatorSum += Convert.ToDecimal(secondMarks.GetType().GetProperty(factor.Trim()).GetValue(secondMarks));
			}
			careerVM.MotivatorSten = GetMotivatorSten(MotivatorSum, career);

			decimal eqSum = 0;
			foreach (var factor in career.EQFactors.Split(','))
			{
				eqSum += Convert.ToDecimal(fifthMarks.GetType().GetProperty(factor.Trim()).GetValue(fifthMarks));
			}
			careerVM.EQSten = GetEQSten(eqSum, career);

			return careerVM;
		}

		private decimal GetAptitudeSten(decimal aptitudeStenSum, Career career)
		{
			var zScore = (aptitudeStenSum - career.AptitudeStenConstant1) / career.AptitudeStenConstant2;
			var sten = (zScore * career.AptitudeStenConstant3) + career.AptitudeStenConstant4;
			return Math.Round(sten);
		}

		private decimal GetPersonalitySten(decimal personalitySum, Career career)
		{
			var zScore = (personalitySum - career.PersonalityStenConstant1) / career.PersonalityStenConstant2;
			var sten = (zScore * career.PersonalityStenConstant3) + career.PersonalityStenConstant4;
			return Math.Round(sten);
		}

		private decimal GetInterestSten(decimal interestSum, Career career)
		{
			var zScore = (interestSum - career.InterestStenConstant1) / career.InterestStenConstant2;
			var sten = (zScore * career.InterestStenConstant3) + career.InterestStenConstant4;
			return Math.Round(sten);
		}

		private decimal GetEQSten(decimal eqSum, Career career)
		{
			var zScore = (eqSum - career.EQStenConstant1) / career.EQStenConstant2;
			var sten = (zScore * career.EQStenConstant3) + career.EQStenConstant4;
			return Math.Round(sten);
		}

		private decimal GetMotivatorSten(decimal motivatorSum, Career career)
		{
			//This method calculates the sten using constants saved in the career table for the corresponding career.
			var zScore = (motivatorSum - career.MotivatorStenConstant1) / career.MotivatorStenConstant2;
			var sten = (zScore * career.MotivatorStenConstant3) + career.MotivatorStenConstant4;
			return Math.Round(sten);
		}

		private bool DoAptitudeFactorsMatch(Career career, StudentModuleFourMarks fourthMarks, decimal valueToCompare)
		{
			//AptitudeFactors has all the factors the careers needs to check against in a comma-seperated list.
			//We check the values for only those factors.
			foreach (var personalityFactor in career.StenAptitudeFactors.Split(','))
			{
				if (Convert.ToDecimal(fourthMarks.GetType().GetProperty(personalityFactor.Trim()).GetValue(fourthMarks)) < valueToCompare)
				{
					return false;
				}
			}
			return true;
		}

		private bool DoPersonalityFactorsMatch(Career career, StudentModuleThreeMarks thirdMarks, decimal valueToCompare)
		{
			foreach (var personalityFactor in career.StenPersonalityFactors.Split(','))
			{
				if (Convert.ToDecimal(thirdMarks.GetType().GetProperty(personalityFactor.Trim()).GetValue(thirdMarks)) < valueToCompare)
				{
					return false;
				}
			}
			return true;
		}

		private bool DoInterestFactorsMatch(Career career, StudentModuleOneMarks firstMarks, decimal valueToCompare)
		{
			foreach (var personalityFactor in career.StenInterestFactors.Split(','))
			{
				if (Convert.ToDecimal(firstMarks.GetType().GetProperty(personalityFactor.Trim()).GetValue(firstMarks)) < valueToCompare)
				{
					return false;
				}
			}
			return true;
		}

		private bool DoMotivationFactorsMatch(Career career, StudentModuleTwoMarks secondMarks, decimal valueToCompare)
		{
			foreach (var personalityFactor in career.StenMotivatorFactors.Split(','))
			{
				if (Convert.ToDecimal(secondMarks.GetType().GetProperty(personalityFactor.Trim()).GetValue(secondMarks)) < valueToCompare)
				{
					return false;
				}
			}
			return true;
		}

		private bool DoEQFactorsMatch(Career career, StudentModuleFiveMarks fifthMarks, decimal valueToCompare)
		{
			foreach (var personalityFactor in career.StenEQFactors.Split(','))
			{
				if (Convert.ToDecimal(fifthMarks.GetType().GetProperty(personalityFactor.Trim()).GetValue(fifthMarks)) < valueToCompare)
				{
					return false;
				}
			}
			return true;
		}

		//private static decimal GetSten(decimal value, Career career)
		//{
		//	//This method calculates the sten using constants saved in the career table for the corresponding career.
		//	var zScore = (value - career.StenConstant1) / career.StenConstant2;
		//	var sten = (zScore * career.StenConstant3) + career.StenConstant4;
		//	return Math.Round(sten);
		//}

		public class CareerViewModel
		{
			public Career Career { get; set; }
			//public int CareerId { get; set; }
			//public string Name { get; set; }
			public decimal PersonalitySten { get; set; }
			public decimal AptitudeSten { get; set; }
			public decimal EQSten { get; set; }
			public decimal InterestSten { get; set; }
			public decimal MotivatorSten { get; set; }
			public decimal TotalSten
			{
				get
				{
					return PersonalitySten + EQSten + AptitudeSten + InterestSten + MotivatorSten;
				}
			}
		}
	}
}
