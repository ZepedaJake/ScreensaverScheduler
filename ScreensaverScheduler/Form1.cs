using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace ScreensaverScheduler
{
    public partial class Form1 : Form
    {
        string screensaverLocation = @"C:\Windows\System32\Ribbons.scr";
        Settings settings = new Settings();
        List<Schedule> schedules = new List<Schedule>();
        string currentSchedule = "";
        public Form1()
        {
            FileManager.CheckFiles();
            FileManager.GetSettings();
            FileManager.GetSchedules();
            InitializeComponent();
            timer1.Start();
            notifyIcon1.Visible = true;
        }

        void RunScreensaver()
        {
            ProcessStartInfo pi = new ProcessStartInfo(screensaverLocation);
            pi.Arguments = "/s";
            Process ss = Process.Start(pi);
        }

        void StopScreensaver()
        {
            //toggle insert on then off
            SendKeys.Send("{INS}");
            SendKeys.Send("{INS}");
            currentSchedule = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FileManager.SettingsNeedUpdate)
            {
                settings = FileManager.GetSettings();
                FileManager.SettingsNeedUpdate = false;
            }

            if (FileManager.SchedulesNeedUpdate)
            {
                schedules = FileManager.GetSchedules();
                FileManager.SchedulesNeedUpdate = false;
            }

            if (settings.EnableAutoScreensaver)
            {
                foreach (Schedule s in schedules)
                {
                    if (currentSchedule == "")
                    {
                        switch (s.frequency)
                        {
                            case ScheduleFrequency.Daily:
                                {
                                    //if no schedule is underway, find the schedule that is supposed to start now.
                                    if (Math.Abs((DateTime.Now.TimeOfDay - s.startTime.TimeOfDay).TotalSeconds) <= 1)
                                    {

                                        //keep track of its ID and start the screensaver
                                        currentSchedule = s.guid;
                                        s.lastQueued = DateTime.Now;
                                        RunScreensaver();

                                    }
                                    break;
                                }
                            case ScheduleFrequency.Weekly:
                                {
                                    if (DateTime.Now.DayOfWeek == s.startTime.DayOfWeek && Math.Abs((DateTime.Now.TimeOfDay - s.startTime.TimeOfDay).TotalSeconds) <= 1)
                                    {
                                        currentSchedule = s.guid;
                                        s.lastQueued = DateTime.Now;
                                        RunScreensaver();
                                    }
                                    break;
                                }
                            case ScheduleFrequency.Monthly:
                                {
                                    if (DateTime.Now.Day == s.startTime.Day && Math.Abs((DateTime.Now.TimeOfDay - s.startTime.TimeOfDay).TotalSeconds) <= 1)
                                    {
                                        currentSchedule = s.guid;
                                        s.lastQueued = DateTime.Now;
                                        RunScreensaver();
                                    }
                                    break;
                                }
                            default:
                                {

                                    break;
                                }
                        }
                        FileManager.SaveSchedule(s, true);
                        return;
                    }

                    if (currentSchedule == s.guid && (DateTime.Now - s.lastQueued).TotalSeconds >= s.durationSeconds)
                    {
                        StopScreensaver();
                    }
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunScreensaver();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            using (FormSchedules formSchedules = new FormSchedules())
            {
                formSchedules.ShowDialog();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close Screensaver Scheduler?", "Close Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            notifyIcon1?.Dispose();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (FormSettings formSettings = new FormSettings())
            {
                formSettings.ShowDialog();
            }
        }
    }
}
