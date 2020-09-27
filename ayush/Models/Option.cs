using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Option
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        public int? ImageID { get; set; }
        public virtual Image Image { get; set; }
    }
}
