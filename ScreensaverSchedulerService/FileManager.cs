using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScreensaverSchedulerService
{
    public static class FileManager
    {

        static string filesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ScreenSaverScheduler");
        static XmlSerializer xsSchedules = new XmlSerializer(typeof(List<Schedule>));
        static XmlSerializer xsSettings = new XmlSerializer(typeof(Settings));
        
        public static List<Schedule> GetSchedules()
        {
            string file = Path.Combine(filesPath, "Schedules.xml");
            List<Schedule> returnMe = new List<Schedule>();
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                returnMe = (List<Schedule>)xsSchedules.Deserialize(sr);
                sr.Close();
            }
            return returnMe;
        }

        public static Settings GetSettings()
        {
            string file = Path.Combine(filesPath, "Settings.xml");
            Settings returnMe = new Settings();
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                returnMe = (Settings)xsSettings.Deserialize(sr);
                sr.Close();
            }
            return returnMe;
        }
    }
}
