namespace ScreensaverScheduler
{
    partial class FormSchedules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedules));
            btnNewSchedule = new Button();
            pnlSchedules = new Panel();
            SuspendLayout();
            // 
            // btnNewSchedule
            // 
            btnNewSchedule.Dock = DockStyle.Top;
            btnNewSchedule.Location = new Point(0, 0);
            btnNewSchedule.Name = "btnNewSchedule";
            btnNewSchedule.Size = new Size(548, 29);
            btnNewSchedule.TabIndex = 0;
            btnNewSchedule.Text = "New Schedule";
            btnNewSchedule.UseVisualStyleBackColor = true;
            btnNewSchedule.Click += btnNewSchedule_Click;
            // 
            // pnlSchedules
            // 
            pnlSchedules.Dock = DockStyle.Fill;
            pnlSchedules.Location = new Point(0, 29);
            pnlSchedules.Name = "pnlSchedules";
            pnlSchedules.Size = new Size(548, 182);
            pnlSchedules.TabIndex = 1;
            // 
            // FormSchedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 211);
            Controls.Add(pnlSchedules);
            Controls.Add(btnNewSchedule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSchedules";
            Text = "Schedules";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewSchedule;
        private Panel pnlSchedules;
    }
}