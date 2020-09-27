using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ayush.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class AttemptQuizController : ControllerBase
	{
		private ayushContext _context { get; set; }
		public AttemptQuizController(ayushContext context)
		{
			_context = context;
		}
		//[HttpPost]
		//public async Task<ActionResult> Attempt(int quizId)
		//{
		//	var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == quizId);

		//	if (quiz == null) return NotFound();

		//	StudentQuiz studentQuiz = new StudentQuiz();

		//	studentQuiz.UserId = User.Claims.ToList().FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
		//	studentQuiz.QuizID = quiz.Id;
		//	studentQuiz.StartedAt = DateTime.Now;

		//	_context.StudentQuizzes.Add(studentQuiz);
		//	if (_context.SaveChanges() > 0)
		//	{
		//		var model = new AttemptQuizViewModel();
		//		model.QuizID = quizId;
		//		model.StudentQuizID = studentQuiz.Id;
		//		model.TotalQuestions = quiz.Questions.Count;
		//		model.Question = quiz.Questions.FirstOrDefault();
		//		model.QuestionIndex = 0;

		//		model.Options = new List<Option>();
		//		model.Options.AddRange(model.Question.Options);
		//		Shuffle(model.Options);

		//		model.EnableQuestionTimer = quiz.EnableQuestionTimer;
		//		model.Seconds = CalculateAllowedQuestionTime(quiz);

		//		return Partial("quizQuestion", model);
		//	}
		//	else
		//	{
		//		return StatusCode(500);
		//	}
		//}
		public static double CalculateAllowedQuestionTime(Quiz quiz)
		{
			double seconds = 0;

			if (quiz != null && quiz.Questions != null && quiz.Questions.Count > 0)
			{
				seconds = quiz.TimeDuration.TotalSeconds / quiz.Questions.Count;
			}

			return seconds;
		}

		public static void Shuffle(List<Option> list)
		{
			if (list != null)
			{
				System.Security.Cryptography.RNGCryptoServiceProvider provider = new System.Security.Cryptography.RNGCryptoServiceProvider();
				int n = list.Count;
				while (n > 1)
				{
					byte[] box = new byte[1];
					do provider.GetBytes(box);
					while (!(box[0] < n * (Byte.MaxValue / n)));
					int k = (box[0] % n);
					n--;
					Option value = list[k];
					list[k] = list[n];
					list[n] = value;
				}
			}
		}
	}
}