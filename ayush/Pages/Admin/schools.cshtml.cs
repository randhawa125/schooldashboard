using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Models.admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ayush.Models;
using OfficeOpenXml;
using ayush.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ayush.Pages.Admin
{
    public class schoolsModel : PageModel
    {
        ayushContext _Context;
        public schoolsModel(ayushContext databasecontext)
        {
            _Context = databasecontext;
        }
        public List<AddSchoolInfo> SchoolList { get; set; }
        public void OnGet()
        {
            var data = (from schoollist in _Context.AddSchoolInfos
                        select schoollist).ToList();

            SchoolList = data;
        }
        public async Task<IActionResult> OnPostExportExcelAsync()
        {

            var MyList = await _Context.AddSchoolInfos.ToListAsync();
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(MyList, true);
                package.Save();
            }
            stream.Position = 0;

            string excelName = $"SchoolData-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            // above I define the name of the file using the current datetime.

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName); // this will be the actual export.
        }
    }
}
