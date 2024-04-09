namespace ScreensaverScheduler
{
    partial class FormSettings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            chkEnable = new CheckBox();
            toolTip1 = new ToolTip(components);
            lblFilename = new Label();
            btnSelectFile = new Button();
            SuspendLayout();
            // 
            // chkEnable
            // 
            chkEnable.AutoSize = true;
            chkEnable.Location = new Point(12, 12);
            chkEnable.Name = "chkEnable";
            chkEnable.Size = new Size(157, 19);
            chkEnable.TabIndex = 0;
            chkEnable.Text = "Enable Auto-Screensaver";
            toolTip1.SetToolTip(chkEnable, "Turn this off if you want the program to run but never start the screen saver");
            chkEnable.UseVisualStyleBackColor = true;
            chkEnable.CheckedChanged += chkEnable_CheckedChanged;
            // 
            // lblFilename
            // 
            lblFilename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFilename.Location = new Point(12, 34);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(352, 60);
            lblFilename.TabIndex = 1;
            lblFilename.Text = "File:";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectFile.Location = new Point(370, 53);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "Change";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 111);
            Controls.Add(btnSelectFile);
            Controls.Add(lblFilename);
            Controls.Add(chkEnable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSettings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEnable;
        private ToolTip toolTip1;
        private Label lblFilename;
        private Button btnSelectFile;
    }
}