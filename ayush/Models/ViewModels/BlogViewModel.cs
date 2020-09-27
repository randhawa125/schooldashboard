using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
	public class BlogViewModel
	{
		public int Id { get; set; }

		[Required()]
		[MaxLength(50)]
		public string Title { get; set; }
		
		[Required]
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public string ClassId { get; set; }
		public string FeaturedImagePath { get; set; }
		public string SubmittedByUserId { get; set; }
		public DateTime SubmittedDate { get; set; }
		public string SubmittedByUserFullName { get; set; }
	}
}
