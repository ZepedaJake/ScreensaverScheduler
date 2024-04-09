namespace ScreensaverScheduler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSettings = new Button();
            btnSchedules = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(8, 8);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(248, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Force Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.Location = new Point(8, 37);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(248, 23);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSchedules
            // 
            btnSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSchedules.Location = new Point(8, 66);
            btnSchedules.Name = "btnSchedules";
            btnSchedules.Size = new Size(248, 23);
            btnSchedules.TabIndex = 2;
            btnSchedules.Text = "Schedules";
            btnSchedules.UseVisualStyleBackColor = true;
            btnSchedules.Click += btnSchedules_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Screensaver Scheduler";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 96);
            Controls.Add(btnSchedules);
            Controls.Add(btnSettings);
            Controls.Add(btnStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Screensaver Scheduler";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Button btnSettings;
        private Button btnSchedules;
        private NotifyIcon notifyIcon1;
    }
}
