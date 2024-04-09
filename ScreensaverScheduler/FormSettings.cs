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
    public partial class FormSettings : Form
    {
        Settings currentSettings;
        bool initFinished = false;
        public FormSettings()
        {
            currentSettings = FileManager.GetSettings();
            InitializeComponent();
            chkEnable.Checked = currentSettings.EnableAutoScreensaver;
            lblFilename.Text = $"File: {currentSettings.ScreensaverFile}";
            initFinished = true;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Windows\\System32";
            ofd.Filter = "Screensaver (*.scr)|*.scr";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentSettings.ScreensaverFile = ofd.FileName;
                FileManager.SaveSettings(currentSettings);
            }
            
        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            //just want to make sure this isnt triggered when the form loads and sets the checkbox.
            if(initFinished)
            {
                currentSettings.EnableAutoScreensaver = chkEnable.Checked;
                FileManager.SaveSettings(currentSettings);
            }            
        }
    }
}
