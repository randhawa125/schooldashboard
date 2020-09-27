using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class edit_quizModel : PageModel
    {
        private ayushContext _context { get; set; }
        public edit_quizModel(ayushContext context)
        {
            _context = context;
        }
        public int QuizId { get; set; }

        public EditQuizViewModel QuizViewModel { get; set; }

        public IActionResult OnGet(int quizId)
        {
            QuizId = quizId;

            var quiz = _context.Quizzes.Include(x => x.Questions).FirstOrDefault(x => x.Id == quizId);

            if (quiz == null)
                return NotFound();

            QuizViewModel = new EditQuizViewModel();

            QuizViewModel.ID = quiz.Id;
            QuizViewModel.Name = quiz.Name;
            QuizViewModel.Description = quiz.Description;

            QuizViewModel.EnableQuizTimer = quiz.EnableQuizTimer;

            if (QuizViewModel.EnableQuizTimer)
            {
                QuizViewModel.Hours = quiz.TimeDuration.Hours;
                QuizViewModel.Minutes = quiz.TimeDuration.Minutes;

                QuizViewModel.EnableQuestionTimer = quiz.EnableQuestionTimer;
            }
            else
            {
                QuizViewModel.Hours = 0;
                QuizViewModel.Minutes = 0;
                QuizViewModel.EnableQuestionTimer = false;
            }

            QuizViewModel.NoOfQuestions = quiz.Questions.Count;

            return Page();
        }

        public IActionResult OnPost(EditQuizViewModel model)
        {
            //get quiz by supplied ID and check if this User is its owner
            var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == model.ID);

            if (quiz == null)
                return NotFound();

            //check if Model is valid
            if (!ModelState.IsValid)
            {
                QuizViewModel = model;
                return Page();
            }

            //populate quiz from Model
            //quiz.OwnerID = User.Identity.GetUserId(); //<- Do not change owner of Quiz on update. Reason: if the Super Admin updated the quiz, it will no longer show in original owner
            quiz.Name = model.Name;
            quiz.Description = model.Description;

            //quiz type should not be changed because this will affect the display of questions 
            //quiz.QuizType = model.SelectedQuizType;

            quiz.EnableQuizTimer = model.EnableQuizTimer;

            if (quiz.EnableQuizTimer)
            {
                quiz.TimeDuration = new TimeSpan(model.Hours, model.Minutes, 0);
                quiz.EnableQuestionTimer = model.EnableQuestionTimer;
            }
            else
            {
                quiz.TimeDuration = new TimeSpan(0, 0, 0);
                quiz.EnableQuestionTimer = false;
            }

            _context.Entry(quiz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            if(_context.SaveChanges() > 0)
            {
                return Redirect("~/admin/quizzes");
            }
            else
            {
                return StatusCode(500);
            }
        }

        public IActionResult OnPostDeleteQuiz(EditQuizViewModel model)
        {
            //get quiz by supplied ID and check if this User is its owner
            var quiz = _context.Quizzes.Include(x => x.Questions)
                .Include("Questions.Options").FirstOrDefault(x => x.Id == model.ID);

            if (quiz == null)
                return NotFound();

            _context.Quizzes.Attach(quiz);

            quiz.Questions.ForEach(qu => _context.Options.RemoveRange(qu.Options));
            _context.Questions.RemoveRange(quiz.Questions);
            _context.Quizzes.Remove(quiz);


            if (_context.SaveChanges() > 0)
            {
                return Redirect("~/admin/quizzes");
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}