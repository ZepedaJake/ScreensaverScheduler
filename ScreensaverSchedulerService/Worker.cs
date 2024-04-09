
using System.Diagnostics;

namespace ScreensaverSchedulerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        List<Schedule> schedules = new List<Schedule>();
        Settings settings = new Settings();
        string currentSchedule = "";

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            FileManager.GetSettings();
            FileManager.GetSchedules();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            foreach(Schedule s in schedules)
            {
                //if no schedule is underway, find the schedule that is supposed to start now.
                if(currentSchedule == "" && (DateTime.Now.TimeOfDay - s.startTime.TimeOfDay).TotalSeconds <= 1)
                {                    
                    if(currentSchedule == "")
                    {
                        //keep track of its ID and start the screensaver
                        currentSchedule = s.guid;
                        s.lastQueued = DateTime.Now;                        
                        RunScreensaver();
                    }                  
                }

                if(currentSchedule == s.guid)
                {
                    StopScreensaver();
                }
            }

            await Task.Delay(500, stoppingToken);
        }

        void RunScreensaver()
        {
            ProcessStartInfo pi = new ProcessStartInfo(settings.ScreensaverFile);
            pi.Arguments = "/s";
            Process ss = Process.Start(pi);            
        }

        void StopScreensaver()
        {
            //SendKeys.Send("{+}");
        }
    }
}
