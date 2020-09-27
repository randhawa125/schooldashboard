using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class questionModel : PageModel
    {
        private ayushContext _context { get; set; }
        public questionModel(ayushContext context)
        {
            _context = context;
        }
        public List<Question> Questions { get; set; }
        public int QuizId { get; set; }
        public void OnGet(int quizId)
        {
            QuizId = quizId;
            Questions = _context.Questions.Include(x => x.Options).Where(x => x.QuizID == quizId).ToList();
        }
    }
}