﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush
{
    public class EQmodel : PageModel
    {
        private ayushContext _context;
      

        public EQmodel(ayushContext context)
        {
            _context = context;
        }
       
    }
}