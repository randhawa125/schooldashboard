using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class OneTimePassword
	{
		public int Id { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
		public bool IsKeyUsed { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}
