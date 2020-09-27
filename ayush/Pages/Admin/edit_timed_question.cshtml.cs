using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
	public class edit_timed_questionModel : PageModel
	{
		private ayushContext _context { get; set; }
		public edit_timed_questionModel(ayushContext context)
		{
			_context = context;
		}

		public EditQuestionViewModel EditQuestionViewModel { get; set; }
		public IActionResult OnGet(int questionId)
		{
			EditQuestionViewModel = new EditQuestionViewModel();

			var question = _context.Questions.Include(x => x.Options).Include("Options.Image").Include(x => x.Image).FirstOrDefault(x => x.Id == questionId);

			if (question == null) return NotFound();

			EditQuestionViewModel.ID = question.Id;
			EditQuestionViewModel.QuizID = question.QuizID;
			EditQuestionViewModel.Title = question.Title;
			EditQuestionViewModel.Hours = question.TimeDuration.Hours;
			EditQuestionViewModel.Minutes = question.TimeDuration.Minutes;
			EditQuestionViewModel.Seconds = question.TimeDuration.Seconds;
			EditQuestionViewModel.HasOptionsTime = question.HasOptionsDuration;
			EditQuestionViewModel.OptionHours = question.OptionsTimeDuration.Hours;
			EditQuestionViewModel.OptionMinutes = question.OptionsTimeDuration.Minutes;
			EditQuestionViewModel.OptionSeconds = question.OptionsTimeDuration.Seconds;
			EditQuestionViewModel.ImagePath = question.Image?.Name;
			//EditQuestionViewModel.CorrectOptions = question.Options.Where(q => q.IsCorrect).ToList();
			EditQuestionViewModel.Options = question.Options.ToList();

			return Page();

		}

		public IActionResult OnPost(IFormCollection collection)
		{
			EditQuestionViewModel model = new EditQuestionViewModel();

			model.QuizID = GetQuizIDFromCollection(collection);

			var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == model.QuizID);

			if (quiz == null) return NotFound();

			model = GetEditTimedQuestionViewModelFromFormCollection(model, collection);

			var question = _context.Questions.FirstOrDefault(x => x.Id == model.ID);

			if (question == null) return NotFound();

			if (model == null || string.IsNullOrEmpty(model.Title) || model.Options.Where(x => x.IsCorrect).ToList().Count == 0 || model.Options.Count == 0
				|| model.TimeDuration < new TimeSpan(0, 0, 1) || model.TimeDuration > new TimeSpan(23, 59, 59)
				|| (model.HasOptionsTime == true && model.OptionTimeDuration < new TimeSpan(0, 0, 1) || model.OptionTimeDuration > new TimeSpan(23, 59, 59)))
			{
				if (string.IsNullOrEmpty(model.Title))
				{
					ModelState.AddModelError("Title", "Please enter question title.");
				}

				if (model.Options.Where(x => x.IsCorrect).ToList().Count == 0)
				{
					ModelState.AddModelError("CorrectOptions", "Please enter some correct options.");
				}

				if (model.Options.Count == 0)
				{
					ModelState.AddModelError("Options", "Please enter some other options.");
				}

				if (model.TimeDuration < new TimeSpan(0, 0, 1) || model.TimeDuration > new TimeSpan(23, 59, 59))
				{
					ModelState.AddModelError("TimeDuration", "Invalid Time");
				}

				if (model.OptionTimeDuration < new TimeSpan(0, 0, 1) || model.OptionTimeDuration > new TimeSpan(23, 59, 59))
				{
					ModelState.AddModelError("OptionTimeDuration", "Invalid Time");
				}

				EditQuestionViewModel = model;

				return Page();
			}

			question.QuizID = model.QuizID;
			question.Title = model.Title;
			question.TimeDuration = model.TimeDuration;

			question.HasOptionsDuration = model.HasOptionsTime;

			if(question.HasOptionsDuration)
				question.OptionsTimeDuration = model.OptionTimeDuration;

			var oldQuestion = _context.Questions.Include(x => x.Options).FirstOrDefault(x => x.Id == question.Id);


			//delete this old question with all options
			_context.Options.RemoveRange(oldQuestion.Options);


			//_context.Questions.Remove(oldQuestion);

			//_context.SaveChanges();

			question.Options = new List<Option>();
			question.Options.AddRange(model.CorrectOptions);
			question.Options.AddRange(model.Options);
			//question.Quiz = null;
			//question.Id = 0;

			if (_context.SaveChanges() > 0)
			{
				return Redirect("~/admin/question?quizid=" + question.QuizID);
			}
			else
			{
				return StatusCode(500);
			}
		}

		public IActionResult OnPostDeleteQuestion(IFormCollection collection)
		{
			EditQuestionViewModel model = new EditQuestionViewModel();

			model.QuizID = GetQuizIDFromCollection(collection);

			var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == model.QuizID);

			if (quiz == null) return NotFound();

			model = GetEditTimedQuestionViewModelFromFormCollection(model, collection);

			var question = _context.Questions
							   .Where(q => q.QuizID == model.QuizID && q.Id == model.ID)
							   .Include(x => x.Options)
							   .Include("Options.Image")
							   .FirstOrDefault();

			if (question == null) return NotFound();

			_context.Questions.Attach(question);

			_context.Options.RemoveRange(question.Options);
			_context.Questions.Remove(question);

			if (_context.SaveChanges() > 0)
			{
				return Redirect("~/admin/question?quizid=" + model.QuizID);
			}
			else
			{
				return StatusCode(500);
			}
		}

		private int GetQuizIDFromCollection(IFormCollection collection)
		{
			if (collection.Keys.Count() > 0)
			{
				foreach (var key in collection)
				{
					if (key.Key == "QuizID")
					{
						return int.Parse(collection[key.Key]);
					}
				}
			}

			return 0;
		}

		private EditQuestionViewModel GetEditTimedQuestionViewModelFromFormCollection(EditQuestionViewModel model, IFormCollection collection)
		{
			model.Options = new List<Option>();
			model.CorrectOptions = new List<Option>();

			if (collection.Keys.Count() > 0)
			{
				foreach (var key in collection)
				{
					if (key.Key == "ID")
					{
						model.ID = int.Parse(collection[key.Key]);
					}
					else if (key.Key == "Title")
					{
						model.Title = collection[key.Key];
					}
					//else if (key.Key.Contains("correctOption")) //this must be Correct Option
					//{
					//	if (!string.IsNullOrEmpty(collection[key.Key]))
					//	{
					//		try
					//		{
					//			var correctOption = new Option();
					//			correctOption.Image = _context.Images.FirstOrDefault(x => x.Id == int.Parse(collection[key.Key]));
					//			correctOption.IsCorrect = true;

					//			model.CorrectOptions.Add(correctOption);
					//		}
					//		catch
					//		{
					//			//ignore this option
					//		}
					//	}
					//}
					else if (key.Key.Contains("option")) //this must be Option
					{
						if (!string.IsNullOrEmpty(collection[key.Key]))
						{
							try
							{
								var option = new Option();
								option.Image = _context.Images.FirstOrDefault(x => x.Id == int.Parse(collection[key.Key]));

								var index = Regex.Replace(key.Key, "[^0-9]+", string.Empty);

								var isOptionCorrect = collection["isoptioncorrect" + index] == "on";

								option.IsCorrect = isOptionCorrect;

								model.Options.Add(option);
							}
							catch
							{
								//ignore this option
							}
						}
					}
					else if (key.Key == "Hours")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.Hours = Convert.ToInt32(collection[key.Key]);
					}
					else if (key.Key == "Minutes")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.Minutes = Convert.ToInt32(collection[key.Key]);
					}
					else if (key.Key == "Seconds")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.Seconds = Convert.ToInt32(collection[key.Key]);
					}
					else if (key.Key == "EnableOptionTimer")
					{
						model.HasOptionsTime = Convert.ToBoolean(collection[key.Key]);
					}
					else if (key.Key == "OptionHours")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.OptionHours = Convert.ToInt32(collection[key.Key]);
					}
					else if (key.Key == "OptionMinutes")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.OptionMinutes = Convert.ToInt32(collection[key.Key]);
					}
					else if (key.Key == "OptionSeconds")
					{
						if (string.IsNullOrEmpty(collection[key.Key]) == false)
							model.OptionSeconds = Convert.ToInt32(collection[key.Key]);
					}
				}
			}

			return model;
		}
	}
}