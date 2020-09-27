using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Slot
	{
		public int Id { get; set; }
		public string BaseUserId { get; set; }
		public virtual BaseUser BaseUser { get; set; }
		public DateTime Date { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public virtual Session Session { get; set; }
	}
}
