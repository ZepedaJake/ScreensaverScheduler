using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensaverSchedulerService
{
    public class Schedule
    {
        public string guid = "";
        public DateTime startTime;
        public DateTime endTime;
        public DateTime lastQueued;//tracker to prevent requeuing when timer ticks again in same minute
        public ScheduleFrequency frequency;
    }

    public enum ScheduleFrequency
    {
        Daily,//go by time selected
        Weekly,//go by day of week and time selected
        Monthly//go by day of month and time selected
    }

}
