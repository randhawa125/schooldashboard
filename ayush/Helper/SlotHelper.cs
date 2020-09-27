using ayush.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Helper
{
	public class SlotHelper
	{
        public static List<SlotViewModel> GetAllSlots()
        {
            return new List<SlotViewModel>()
            {
                new SlotViewModel(10, 11),
                new SlotViewModel(11, 12),
                new SlotViewModel(12, 13),
                new SlotViewModel(13, 14),
                new SlotViewModel(15, 16),
                new SlotViewModel(16, 17),
                new SlotViewModel(17, 18),
                new SlotViewModel(18, 19),
            };
        }
    }
}
