using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
	public class SystemInformationViewModel
	{
		public string PropertyName { get; set; }
		[Required]
		public string PropertyValue { get; set; }
	}
}
