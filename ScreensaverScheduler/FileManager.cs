using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScreensaverScheduler
{
    public static class FileManager
    {

        static string filesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ScreenSaverScheduler");
        static XmlSerializer xsSchedules = new XmlSerializer(typeof(List<Schedule>));
        static XmlSerializer xsSettings = new XmlSerializer(typeof(Settings));

        public static bool SchedulesNeedUpdate { get; set; } = false;
        public static bool SettingsNeedUpdate { get; set; } = false;

        public static bool CheckFiles()
        {
            if(!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
            }
            return true;
        }
        public static List<Schedule> GetSchedules()
        {
            string file = Path.Combine(filesPath, "Schedules.xml");
            List<Schedule> returnMe = new List<Schedule>();
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    returnMe = (List<Schedule>)xsSchedules.Deserialize(sr);
                }                                   
            }
            return returnMe;
        }

        public static bool DeleteSchedule(string id)
        {
            List<Schedule> tempList = GetSchedules();
            Schedule deleteMe = tempList.FirstOrDefault(x => x.guid == id);
            if(deleteMe != null)
            {
                tempList.Remove(deleteMe);
                SaveSchedules(tempList);
                return true;
            }
            return false;
        }

        public static bool SaveSchedule(Schedule saveMe, bool existingSchedule = false)
        {
            List<Schedule> tempList = GetSchedules();
            if (existingSchedule)
            {
                Schedule refSched = tempList.FirstOrDefault(x => x.guid == saveMe.guid);
                refSched.durationSeconds = saveMe.durationSeconds;
                refSched.frequency = saveMe.frequency;
                refSched.startTime = saveMe.startTime;
                refSched.lastQueued = saveMe.lastQueued;
            }
            else
            {
                tempList.Add(saveMe);
            }
           
            return SaveSchedules(tempList);

        }
        public static bool SaveSchedules(List<Schedule> saveMe)
        {
            string file = Path.Combine(filesPath, "Schedules.xml");
            using (TextWriter tw = new StreamWriter(file))
            {
                xsSchedules.Serialize(tw, saveMe);                
            }
            SchedulesNeedUpdate = true;
            return true;
        }


        public static bool SaveSettings(Settings saveMe)
        {
            string file = Path.Combine(filesPath, "Settings.xml");
            using (TextWriter tw = new StreamWriter(file))
            {
                xsSettings.Serialize(tw, saveMe);                
            }
            SettingsNeedUpdate = true;
            return true;
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
