using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreensaverScheduler
{
    public partial class UserControlSchedule : UserControl
    {
        Schedule schedule;
        FormSchedules parentForm;
        public UserControlSchedule(Schedule sch, FormSchedules parent = null)
        {
            InitializeComponent();
            this.schedule = sch;
            parentForm = parent;
            switch (schedule.frequency)
            {
                case ScheduleFrequency.Daily:
                    {
                        lblInfo.Text = $"{schedule.startTime.ToString("HH:mm")} for {schedule.durationSeconds} seconds.";
                        break;
                    }
                case ScheduleFrequency.Weekly:
                    {
                        lblInfo.Text = $"{schedule.startTime.ToString("dddd")}s, {schedule.startTime.ToString("HH:mm")} for {schedule.durationSeconds} seconds.";
                        break;
                    }
                case ScheduleFrequency.Monthly:
                    {
                        lblInfo.Text = $"{schedule.startTime.ToString("dd")} every Month, {schedule.startTime.ToString("HH:mm")} for {schedule.durationSeconds} seconds.";
                        break;
                    }
                default:
                    {
                        lblInfo.Text = $"{schedule.startTime.ToString("HH:mm")} for {schedule.durationSeconds} seconds.";
                        break;
                    }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FileManager.DeleteSchedule(schedule.guid))
            {
                this.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FormScheduleDetails frmScheduleDetails = new FormScheduleDetails(schedule))
            {
                frmScheduleDetails.ShowDialog();
                if(frmScheduleDetails.DialogResult == DialogResult.OK)
                {
                    parentForm.ReloadSchedules();
                }
            }
            
        }
    }
}
