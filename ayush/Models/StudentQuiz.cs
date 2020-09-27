using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class StudentQuiz
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
        public int QuizID { get; set; }
        public virtual Quiz Quiz { get; set; }
        public Nullable<DateTime> StartedAt { get; set; }
        public Nullable<DateTime> CompletedAt { get; set; }
        public virtual List<AttemptedQuestion> AttemptedQuestions { get; set; }
        public decimal Score { get; set; }
    }
}
