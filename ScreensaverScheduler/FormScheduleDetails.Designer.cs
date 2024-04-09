namespace ScreensaverScheduler
{
    partial class FormScheduleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScheduleDetails));
            lblId = new Label();
            dtpStartDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtDuration = new TextBox();
            label3 = new Label();
            cmbFrequency = new ComboBox();
            btnSave = new Button();
            dtpStartTime = new DateTimePicker();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Bottom;
            lblId.Location = new Point(0, 141);
            lblId.Name = "lblId";
            lblId.Size = new Size(411, 15);
            lblId.TabIndex = 0;
            lblId.Text = "guid: ";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.CustomFormat = "";
            dtpStartDate.Location = new Point(55, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(223, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Start: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Duration (Seconds):";
            // 
            // txtDuration
            // 
            txtDuration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDuration.Location = new Point(129, 44);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(270, 23);
            txtDuration.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Frequency:";
            // 
            // cmbFrequency
            // 
            cmbFrequency.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFrequency.FormattingEnabled = true;
            cmbFrequency.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            cmbFrequency.Location = new Point(83, 75);
            cmbFrequency.Name = "cmbFrequency";
            cmbFrequency.Size = new Size(316, 23);
            cmbFrequency.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(324, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpStartTime.CustomFormat = "";
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(284, 12);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(115, 23);
            dtpStartTime.TabIndex = 8;
            // 
            // FormScheduleDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 156);
            Controls.Add(dtpStartTime);
            Controls.Add(btnSave);
            Controls.Add(cmbFrequency);
            Controls.Add(label3);
            Controls.Add(txtDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpStartDate);
            Controls.Add(lblId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormScheduleDetails";
            Text = "Schedule Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private DateTimePicker dtpStartDate;
        private Label label1;
        private Label label2;
        private TextBox txtDuration;
        private Label label3;
        private ComboBox cmbFrequency;
        private Button btnSave;
        private DateTimePicker dtpStartTime;
    }
}