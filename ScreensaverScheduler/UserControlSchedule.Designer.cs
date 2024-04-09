namespace ScreensaverScheduler
{
    partial class UserControlSchedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnEdit = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(482, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Right;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Blue;
            btnEdit.Location = new Point(442, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(40, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "E";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Location = new Point(0, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(5, 0, 0, 0);
            lblInfo.Size = new Size(442, 40);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "INFO";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserControlSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblInfo);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "UserControlSchedule";
            Size = new Size(522, 40);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Label lblInfo;
    }
}
