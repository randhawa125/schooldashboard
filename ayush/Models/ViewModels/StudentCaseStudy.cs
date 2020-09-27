using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class StudentCaseStudy
    {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime UploadedOn { get; set; }
        public string FileName { get; set; }
    }
}
