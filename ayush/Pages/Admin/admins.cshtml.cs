using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ayush.Data;
using System.Collections.Generic;
using System.Linq;
using ayush.Models;
using System.Threading.Tasks;

namespace ayush.Pages.Admin
{
    public class adminsModel : PageModel
    {
        ayushContext _Context;
        public adminsModel(ayushContext databasecontext)
        {
            _Context = databasecontext;
        }
        public List<AddAdmin> AdminList { get; set; }
        public void OnGet()
        {
            var data = (from adminlist in _Context.AddAdmin
                        select adminlist).ToList();

            AdminList = data;
        }
    }




   
}
