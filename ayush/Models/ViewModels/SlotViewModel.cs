using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models.ViewModels
{
	public class SlotViewModel
	{
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public string SlotName
        {
            get
            {
                return DateTime.Today.Add(StartTime).ToString("hh:mm tt", CultureInfo.InvariantCulture)
                    + " - " + DateTime.Today.Add(EndTime).ToString("hh:mm tt", CultureInfo.InvariantCulture);
            }
        }
        public SlotViewModel(int startHour, int endHour)
        {
            StartTime = new TimeSpan(startHour, 0, 0);
            EndTime = new TimeSpan(endHour, 0, 0);
            IsAvailable = true;
        }
        public SlotViewModel()
        {

        }
    }
}
