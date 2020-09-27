using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class AttemptedOption
    {
        public int Id { get; set; }
        public int AttemptedQuestionID { get; set; }
        public virtual AttemptedQuestion AttemptedQuestion { get; set; }

        public int OptionID { get; set; }
        public virtual Option Option { get; set; }
    }
}
