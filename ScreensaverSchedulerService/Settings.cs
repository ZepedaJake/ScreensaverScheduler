using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensaverSchedulerService
{
    public class Settings
    {
        public bool EnableAutoScreensaver { get; set; } = true;//can toggle this off if you need to temprorarily disable the auto-screensaver stuff
        public string ScreensaverFile { get; set; } = @"C:\Windows\System32\Ribbons.scr";
    }
}

