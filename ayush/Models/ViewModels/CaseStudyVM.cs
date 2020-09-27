using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
    public class CaseStudyVM
    {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string CaseTitle { get; set; }
        public string CaseDescription { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedOn { get; set; }
        public string FileName { get; set; }
        public bool UploadedByStudent { get; set; }
    }
}
