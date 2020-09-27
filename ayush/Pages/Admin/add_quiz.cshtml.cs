using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush
{
    public class add_quizModel : PageModel
    {
        private ayushContext _context { get; set; }
        public add_quizModel(ayushContext context)
        {
            _context = context;
        }

        public NewQuizViewModel QuizViewModel;
        public void OnGet()
        {
            QuizViewModel = new NewQuizViewModel();

            QuizViewModel.EnableQuizTimer = true; //set Default Quiz Timer to true
        }

        public IActionResult OnPost(NewQuizViewModel model)
        {
            //check if Model is valid
            if (!ModelState.IsValid)
            {
                QuizViewModel = model;
                return Page();
            }

            //populate new Quiz from Model
            var quiz = new Quiz();
            quiz.OwnerID = User.Claims.ToList().FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            quiz.Name = model.Name;
            quiz.Description = model.Description;
            quiz.IsActive = true;
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

            _context.Quizzes.Add(quiz);

            if(_context.SaveChanges() > 0)
            {
                return Redirect("~/admin/question?quizId=" + quiz.Id);
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}