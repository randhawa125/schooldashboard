using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class StudentSlot
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public DateTime Date { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public virtual Session Session { get; set; }
	}
}
