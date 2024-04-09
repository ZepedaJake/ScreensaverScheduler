using Microsoft.VisualBasic;
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
    public partial class FormScheduleDetails : Form
    {
        Schedule schedule = new Schedule();
        public FormScheduleDetails(Schedule sch = null)
        {
            InitializeComponent();
            schedule = sch;
            if (schedule != null)
            {
                dtpStartDate.Value = schedule.startTime;
                dtpStartTime.Value = schedule.startTime;
                txtDuration.Text = schedule.durationSeconds.ToString();
                cmbFrequency.SelectedIndex = (int)schedule.frequency;
                lblId.Text = $"guid: {schedule.guid}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(schedule == null)
            {
                schedule = new Schedule();
               
                
            }
            schedule.startTime = dtpStartDate.Value.Date + dtpStartTime.Value.TimeOfDay;
            schedule.durationSeconds = int.Parse(txtDuration.Text);
            schedule.frequency = (ScheduleFrequency)cmbFrequency.SelectedIndex;

            if(schedule.guid == "")
            {
                schedule.guid = Guid.NewGuid().ToString();
                FileManager.SaveSchedule(schedule);
            }
            else
            {
                FileManager.SaveSchedule(schedule,true);
            }

            DialogResult = DialogResult.OK;            
        }
    }
}
