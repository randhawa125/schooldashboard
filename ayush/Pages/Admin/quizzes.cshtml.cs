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
    public class quizzesModel : PageModel
    {
        public List<Quiz> Quizzes;
        private ayushContext _context;
        public quizzesModel(ayushContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Quizzes = _context.Quizzes.Include(x => x.Questions).ToList();
        }
    }
}