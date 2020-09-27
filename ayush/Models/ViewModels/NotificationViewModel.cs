using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
	public class NotificationViewModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(50)]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }
		public bool IsActive { get; set; }
		[Required]
		public DateTime EndDate { get; set; }
		public string CreatedByUserId { get; set; }
		public string CreatedByUserFullName { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
