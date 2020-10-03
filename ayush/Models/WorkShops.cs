using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
    public class WorkShops
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Id")]
        public int ID { get; set; }
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "Tittle")]
        public string Tittle { get; set; }
        [Required]
        [Column(TypeName = "varchar(max)")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Images")]
        [Column(TypeName = "nvarchar(max)")]
        public string Images { get; set; }
    }
    public class WorkShopsImng
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Id")]
        public int ImgID { get; set; }
        [Display(Name = "Images")]
        [Column(TypeName = "nvarchar(max)")]
        public string Images { get; set; }

        public virtual int ID { get; set; }
        [ForeignKey("ID")]
        public virtual WorkShops WorkShops { get; set; }

    }
}
