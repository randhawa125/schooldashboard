using ayush.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Question
	{
        public int Id { get; set; }

        public string Title { get; set; }
        public virtual List<Option> Options { get; set; }
        public int QuizID { get; set; }
        public int? ImageID { get; set; }
        public TimeSpan TimeDuration { get; set; }
        public bool HasOptionsDuration { get; set; }
        public TimeSpan OptionsTimeDuration { get; set; }
        public virtual Image Image { get; set; }
        public QuestionType QuestionType { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
