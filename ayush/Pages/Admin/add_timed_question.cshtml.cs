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

namespace ayush.Pages.Admin
{
    public class add_timed_questionModel : PageModel
    {
        private ayushContext _context { get; set; }
        public add_timed_questionModel(ayushContext context)
        {
            _context = context;
        }

        public NewQuestionViewModel QuestionViewModel { get; set; }
        public int QuizId { get; set; }

        public IActionResult OnGet(int quizID, int ID)
        {
            QuestionViewModel = new NewQuestionViewModel();

            var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == quizID);

            if (quiz == null) return NotFound();

            QuestionViewModel.QuizId = quiz.Id;

            QuestionViewModel.HasOptionsTime = true;

            QuizId = quizID;

            return Page();
        }

        public IActionResult OnPost(IFormCollection collection)
        {
            NewQuestionViewModel model = new NewQuestionViewModel();

            model.QuizId = GetQuizIDFromCollection(collection);

            var quiz = _context.Quizzes.FirstOrDefault(x => x.Id == model.QuizId);

            if (quiz == null) return NotFound();

            model = GetNewImageQuestionViewModelFromFormCollection(model, collection);

            if (string.IsNullOrEmpty(model.Title) || model.Options.Where(x => x.IsCorrect).ToList().Count == 0 || model.Options.Count == 0
                || model.TimeDuration < new TimeSpan(0,0,1) || model.TimeDuration > new TimeSpan(23, 59, 59)
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

                if(model.TimeDuration < new TimeSpan(0, 0, 1) || model.TimeDuration > new TimeSpan(23, 59, 59))
                {
                    ModelState.AddModelError("TimeDuration", "Invalid Time");
                }

                if (model.OptionTimeDuration < new TimeSpan(0, 0, 1) || model.OptionTimeDuration > new TimeSpan(23, 59, 59))
                {
                    ModelState.AddModelError("OptionTimeDuration", "Invalid Time");
                }

                QuestionViewModel = model;
                return Page();
            }

            var question = new Question();

            question.QuizID = quiz.Id;
            question.Title = model.Title;
            question.ImageID = model.ImageID;
            question.TimeDuration = model.TimeDuration;
            question.HasOptionsDuration = model.HasOptionsTime;
            
            if(question.HasOptionsDuration)
                question.OptionsTimeDuration = model.OptionTimeDuration;
            
            question.QuestionType = Models.Enums.QuestionType.Timed;
            question.Options = new List<Option>();
            //question.Options.AddRange(model.CorrectOptions);
            question.Options.AddRange(model.Options);

            _context.Questions.Add(question);
            if (_context.SaveChanges() > 0)
            {
                return Redirect("~/admin/add_timed_question?quizId=" + quiz.Id);
            }
            else
            {
                return StatusCode(500);
            }
        }

        private NewQuestionViewModel GetNewImageQuestionViewModelFromFormCollection(NewQuestionViewModel model, IFormCollection collection)
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
                    //        try
                    //        {
                    //            var correctOption = new Option();
                    //            correctOption.Image = _context.Images.FirstOrDefault(x => x.Id == int.Parse(collection[key.Key]));
                    //            correctOption.IsCorrect = true;

                    //            model.CorrectOptions.Add(correctOption);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            //ignore this option
                    //        }
                    //    }
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
                            catch (Exception ex)
                            {
                                //ignore this option
                            }
                        }
                    }
                    else if (key.Key.Contains("questionfile"))
                    {
                        if (string.IsNullOrEmpty(collection[key.Key]) == false)
                            model.ImageID = Convert.ToInt32(collection[key.Key]);
                    }
                    else if (key.Key == "Hours")
                    {
                        if(string.IsNullOrEmpty(collection[key.Key]) == false)
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
                    else if(key.Key == "EnableOptionTimer")
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
    }
}
