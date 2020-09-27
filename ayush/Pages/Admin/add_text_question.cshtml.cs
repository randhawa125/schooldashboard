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

namespace ayush
{
    public class add_questionModel : PageModel
    {
        private ayushContext _context { get; set; }
        public add_questionModel(ayushContext context)
        {
            _context = context;
        }
        public NewQuestionViewModel QuestionViewModel { get; set; }
        public int QuizId { get; set; }
        public IActionResult OnGet(int quizId)
        {
            QuestionViewModel = new NewQuestionViewModel();

            var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == quizId);

            if (quiz == null) return NotFound();

            QuestionViewModel.QuizId = quiz.Id;

            QuizId = quizId;

            return Page();
        }

        public IActionResult OnPost(IFormCollection collection)
        {
            NewQuestionViewModel model = new NewQuestionViewModel();

            model.QuizId = GetQuizIDFromCollection(collection);

            var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == model.QuizId);

            if (quiz == null) return NotFound();

            model = GetNewTextQuestionViewModelFromFormCollection(model, collection);

            if (string.IsNullOrEmpty(model.Title) || model.Options.Where(x => x.IsCorrect).ToList().Count == 0 || model.Options.Count == 0)
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

                QuestionViewModel = model;
                return Page();
            }

            var question = new Question();

            question.QuizID = quiz.Id;
            question.Title = model.Title;
            question.QuestionType = Models.Enums.QuestionType.Text;
            question.Options = new List<Option>();
            //question.Options.AddRange(model.CorrectOptions);
            question.Options.AddRange(model.Options);

            _context.Questions.Add(question);
            if(_context.SaveChanges() > 0)
            {
                return Redirect("~/admin/add_text_question?quizId=" + quiz.Id);
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

        private NewQuestionViewModel GetNewTextQuestionViewModelFromFormCollection(NewQuestionViewModel model, IFormCollection collection)
        {
            model.Options = new List<Option>();
            model.CorrectOptions = new List<Option>();

            if (collection.Keys.Count() > 0)
            {
                foreach (var key in collection)
                {
                    if (key.Key == "Title")
                    {
                        model.Title = collection[key.Key];
                    }
                    //else if (key.Key.Contains("correctOption")) //this must be Correct Option
                    //{
                    //    if (!string.IsNullOrEmpty(collection[key.Key]))
                    //    {
                    //        var correctOption = new Option();
                    //        correctOption.Answer = collection[key.Key];
                    //        correctOption.IsCorrect = true;

                    //        model.CorrectOptions.Add(correctOption);
                    //    }
                    //}
                    else if (key.Key.Contains("option") && key.Key.Contains("isoptioncorrect") == false) //this must be Option
                    {
                        if (!string.IsNullOrEmpty(collection[key.Key]))
                        {
                            var option = new Option();
                            option.Answer = collection[key.Key];

                            var index = Regex.Replace(key.Key, "[^0-9]+", string.Empty);

                            var isOptionCorrect = collection["isoptioncorrect" + index] == "on";

                            option.IsCorrect = isOptionCorrect;

                            model.Options.Add(option);
                        }
                    }
                }
            }

            return model;
        }

    }
}