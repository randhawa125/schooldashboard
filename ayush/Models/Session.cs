using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class Session
	{
		public int Id { get; set; }
		public int StudentSlotId { get; set; }
		public virtual StudentSlot StudentSlot { get; set; }
		public int SlotId { get; set; }
		public virtual Slot Slot { get; set; }
	}
}
