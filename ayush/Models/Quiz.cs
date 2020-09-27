using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Quiz
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan TimeDuration { get; set; }
        public bool EnableQuizTimer { get; set; }
        public bool EnableQuestionTimer { get; set; }
        public string OwnerID { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual List<StudentQuiz> StudentQuizzes { get; set; }
    }
}
