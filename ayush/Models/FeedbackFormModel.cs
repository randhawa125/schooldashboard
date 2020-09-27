using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ayush.Models
{
    public class FeedbackFormModel
    {
        [Key]
        public int ID { get; set; }

        public string UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Select an option of Question 1")]
        public string WereInstructionsClear { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Select an option of Question 2")]
        public string WasEngaging { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Select an option of Question 3")]
        public string WasEasyToUnderstand { get; set; }

      
        public string ModulesConcernWith { get; set; }



        [Required(AllowEmptyStrings = false, ErrorMessage = "Select an option of Question 4")]
        public string DifficultyLevelFine { get; set; }

      
        public string WhichModulesDifficult { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Select an option of Question 6")]
        public string OverallExperience { get; set; }
    }
}
