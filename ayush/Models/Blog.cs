using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Blog
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public string ClassId { get; set; }
		public string FeaturedImagePath { get; set; }
		public string SubmittedByUserId { get; set; }
		public DateTime SubmittedDate { get; set; }
		public virtual BaseUser SubmittedByUser { get; set; }

	}
}
