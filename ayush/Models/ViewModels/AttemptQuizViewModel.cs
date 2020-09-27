using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class QuizDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan TimeDuration { get; set; }
        public int NoOfQuestions { get; set; }

        public bool EnableQuizTimer { get; set; }
        public bool EnableQuestionTimer { get; set; }
    }
    public class AttemptQuizViewModel
    {
        public Question Question { get; set; }
        public List<Option> Options { get; set; }
        public int StudentQuizID { get; set; }
        public int QuizID { get; set; }
        public int QuestionID { get; set; }
        public string SelectedOptionIDs { get; set; }
        public bool TimerExpired { get; set; }
        public int TotalQuestions { get; set; }
        public int QuestionIndex { get; set; }
        public bool EnableQuestionTimer { get; set; }
        public double Seconds { get; set; }
        public double QuestionSeconds { get; set; }
        public double OptionSeconds { get; set; }
        public bool HasOptionsTime { get; set; }
    }
}
