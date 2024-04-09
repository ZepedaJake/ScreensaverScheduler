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
    public partial class FormSchedules : Form
    {
        List<Schedule> schedules = new List<Schedule>();
        public FormSchedules()
        {            
            InitializeComponent();
            ReloadSchedules();
        }

        public void ReloadSchedules()
        {
            schedules = FileManager.GetSchedules();
            pnlSchedules.Controls.Clear();
            foreach (Schedule s in schedules)
            {
                UserControlSchedule ucs = new UserControlSchedule(s, this);
                ucs.Dock = DockStyle.Top;
                pnlSchedules.Controls.Add(ucs);
            }
        }

        private void btnNewSchedule_Click(object sender, EventArgs e)
        {
            using (FormScheduleDetails formScheduleDetails = new FormScheduleDetails())
            {
                if(formScheduleDetails.ShowDialog() == DialogResult.OK)
                {
                    ReloadSchedules();
                }
            }
        }
    }
}
