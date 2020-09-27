using ayush.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class NewQuestionViewModel
    {
        [Required]
        public string Title { get; set; }
        public List<Option> Options { get; set; }
        public List<Option> CorrectOptions { get; set; }

        public int QuizId { get; set; }
        public int? ImageID { get; set; }
        [Display(Name = "Time")]
        [Range(typeof(TimeSpan), "00:01", "23:59")]
        public TimeSpan TimeDuration
        {
            get
            {
                return new TimeSpan(Hours, Minutes, Seconds);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int Hours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int Minutes { get; set; }
        [Required]
        [Range(0, 59, ErrorMessage = "Seconds should be between 0 to 59")]
        public int Seconds { get; set; }
        public bool HasOptionsTime { get; set; }
        public TimeSpan OptionTimeDuration
        {
            get
            {
                return new TimeSpan(OptionHours, OptionMinutes, OptionSeconds);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int OptionHours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int OptionMinutes { get; set; }
        [Required]
        [Range(0, 59, ErrorMessage = "Seconds should be between 0 to 59")]
        public int OptionSeconds { get; set; }
        public List<QuestionType> QuestionTypes { get; set; }
        public QuestionType SelectedQuestionType { get; set; }
    }

    public class NewTimedQuestionViewModel
    {
        [Required]
        public string Title { get; set; }

        public List<Option> Options { get; set; }
        public List<Option> CorrectOptions { get; set; }
        [Display(Name = "Time")]
        [Range(typeof(TimeSpan), "00:01", "23:59")]
        public TimeSpan TimeDuration
        {
            get
            {
                return new TimeSpan(Hours, Minutes, 0);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int Hours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int Minutes { get; set; }
        public TimeSpan OptionTimeDuration
        {
            get
            {
                return new TimeSpan(OptionHours, OptionMinutes, 0);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int OptionHours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int OptionMinutes { get; set; }

        public int QuizId { get; set; }
        public int? ImageID { get; set; }
        public List<QuestionType> QuestionTypes { get; set; }
        public QuestionType SelectedQuestionType { get; set; }
    }

    public class EditQuestionViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public int? ImageId { get; set; }
        public List<Option> Options { get; set; }
        public List<Option> CorrectOptions { get; set; }
        [Display(Name = "Time")]
        [Range(typeof(TimeSpan), "00:01", "23:59")]
        public TimeSpan TimeDuration
        {
            get
            {
                return new TimeSpan(Hours, Minutes, Seconds);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int Hours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int Minutes { get; set; }
        [Required]
        [Range(0, 59, ErrorMessage = "Seconds should be between 0 to 59")]
        public int Seconds { get; set; }
        public bool HasOptionsTime { get; set; }
        public TimeSpan OptionTimeDuration
        {
            get
            {
                return new TimeSpan(OptionHours, OptionMinutes, OptionSeconds);
            }
        }

        [Required]
        [Range(0, 23, ErrorMessage = "Hours should be between 0 to 23")]
        public int OptionHours { get; set; }

        [Required]
        [Range(0, 59, ErrorMessage = "Minutes should be between 0 to 59")]
        public int OptionMinutes { get; set; }
        [Required]
        [Range(0, 59, ErrorMessage = "Seconds should be between 0 to 59")]
        public int OptionSeconds { get; set; }
        public string ImagePath { get; set; }

        public int QuizID { get; set; }
    }
}
