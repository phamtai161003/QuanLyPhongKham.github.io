namespace QuanLySucKhoe
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.advancedReportsMenuButton = new System.Windows.Forms.Button();
            this.basicReportsMenuButton = new System.Windows.Forms.Button();
            this.pavilionsMenuButton = new System.Windows.Forms.Button();
            this.servicesMenuButton = new System.Windows.Forms.Button();
            this.emergencyDoctorMenuButton = new System.Windows.Forms.Button();
            this.workingHoursMenuButton = new System.Windows.Forms.Button();
            this.usersMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.advancedReportsMenuButton);
            this.panel1.Controls.Add(this.basicReportsMenuButton);
            this.panel1.Controls.Add(this.pavilionsMenuButton);
            this.panel1.Controls.Add(this.servicesMenuButton);
            this.panel1.Controls.Add(this.emergencyDoctorMenuButton);
            this.panel1.Controls.Add(this.workingHoursMenuButton);
            this.panel1.Controls.Add(this.usersMenuButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 659);
            this.panel1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(2, 564);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(222, 29);
            this.labelName.TabIndex = 8;
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Location = new System.Drawing.Point(0, 601);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(270, 41);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Logout";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // advancedReportsMenuButton
            // 
            this.advancedReportsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.advancedReportsMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.advancedReportsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.advancedReportsMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.advanced_chart_icon;
            this.advancedReportsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advancedReportsMenuButton.Location = new System.Drawing.Point(0, 488);
            this.advancedReportsMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.advancedReportsMenuButton.Name = "advancedReportsMenuButton";
            this.advancedReportsMenuButton.Size = new System.Drawing.Size(270, 64);
            this.advancedReportsMenuButton.TabIndex = 6;
            this.advancedReportsMenuButton.Text = "Báo cáo nâng cao";
            this.advancedReportsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.advancedReportsMenuButton.UseVisualStyleBackColor = false;
            this.advancedReportsMenuButton.Click += new System.EventHandler(this.advancedReportsMenuButton_Click);
            // 
            // basicReportsMenuButton
            // 
            this.basicReportsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.basicReportsMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.basicReportsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.basicReportsMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.chart_icon;
            this.basicReportsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.basicReportsMenuButton.Location = new System.Drawing.Point(0, 419);
            this.basicReportsMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basicReportsMenuButton.Name = "basicReportsMenuButton";
            this.basicReportsMenuButton.Size = new System.Drawing.Size(270, 64);
            this.basicReportsMenuButton.TabIndex = 5;
            this.basicReportsMenuButton.Text = "Báo cáo cơ bản";
            this.basicReportsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.basicReportsMenuButton.UseVisualStyleBackColor = false;
            this.basicReportsMenuButton.Click += new System.EventHandler(this.basicReportsMenuButton_Click);
            // 
            // pavilionsMenuButton
            // 
            this.pavilionsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pavilionsMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.pavilionsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pavilionsMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.hospital_icon;
            this.pavilionsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pavilionsMenuButton.Location = new System.Drawing.Point(0, 351);
            this.pavilionsMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pavilionsMenuButton.Name = "pavilionsMenuButton";
            this.pavilionsMenuButton.Size = new System.Drawing.Size(270, 64);
            this.pavilionsMenuButton.TabIndex = 4;
            this.pavilionsMenuButton.Text = "Khoa bệnh";
            this.pavilionsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pavilionsMenuButton.UseVisualStyleBackColor = false;
            this.pavilionsMenuButton.Click += new System.EventHandler(this.pavilionsMenuButton_Click);
            // 
            // servicesMenuButton
            // 
            this.servicesMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.servicesMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.servicesMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.servicesMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.list_icon;
            this.servicesMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesMenuButton.Location = new System.Drawing.Point(0, 283);
            this.servicesMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicesMenuButton.Name = "servicesMenuButton";
            this.servicesMenuButton.Size = new System.Drawing.Size(270, 64);
            this.servicesMenuButton.TabIndex = 3;
            this.servicesMenuButton.Text = "Dịch vụ";
            this.servicesMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicesMenuButton.UseVisualStyleBackColor = false;
            this.servicesMenuButton.Click += new System.EventHandler(this.servicesMenuButton_Click);
            // 
            // emergencyDoctorMenuButton
            // 
            this.emergencyDoctorMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emergencyDoctorMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.emergencyDoctorMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emergencyDoctorMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.emergency_icon;
            this.emergencyDoctorMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergencyDoctorMenuButton.Location = new System.Drawing.Point(0, 214);
            this.emergencyDoctorMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emergencyDoctorMenuButton.Name = "emergencyDoctorMenuButton";
            this.emergencyDoctorMenuButton.Size = new System.Drawing.Size(270, 64);
            this.emergencyDoctorMenuButton.TabIndex = 2;
            this.emergencyDoctorMenuButton.Text = "Bác sĩ cấp cứu";
            this.emergencyDoctorMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emergencyDoctorMenuButton.UseVisualStyleBackColor = false;
            this.emergencyDoctorMenuButton.Click += new System.EventHandler(this.emergencyDoctorMenuButton_Click);
            // 
            // workingHoursMenuButton
            // 
            this.workingHoursMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.workingHoursMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.workingHoursMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workingHoursMenuButton.Image = global::QuanLySucKhoe.Properties.Resources.calendar_icon;
            this.workingHoursMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workingHoursMenuButton.Location = new System.Drawing.Point(0, 146);
            this.workingHoursMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workingHoursMenuButton.Name = "workingHoursMenuButton";
            this.workingHoursMenuButton.Size = new System.Drawing.Size(270, 64);
            this.workingHoursMenuButton.TabIndex = 2;
            this.workingHoursMenuButton.Text = "Thời gian làm việc";
            this.workingHoursMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workingHoursMenuButton.UseVisualStyleBackColor = false;
            this.workingHoursMenuButton.Click += new System.EventHandler(this.workingHoursMenuButton_Click);
            // 
            // usersMenuButton
            // 
            this.usersMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usersMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.usersMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("usersMenuButton.Image")));
            this.usersMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersMenuButton.Location = new System.Drawing.Point(0, 78);
            this.usersMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersMenuButton.Name = "usersMenuButton";
            this.usersMenuButton.Size = new System.Drawing.Size(270, 64);
            this.usersMenuButton.TabIndex = 1;
            this.usersMenuButton.Text = "Người dùng";
            this.usersMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersMenuButton.UseVisualStyleBackColor = false;
            this.usersMenuButton.Click += new System.EventHandler(this.usersMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 6;
            this.mainPanel.Location = new System.Drawing.Point(276, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(862, 652);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 659);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label labelName;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Windows.Forms.Button advancedReportsMenuButton;
        private System.Windows.Forms.Button basicReportsMenuButton;
        private System.Windows.Forms.Button pavilionsMenuButton;
        private System.Windows.Forms.Button servicesMenuButton;
        private System.Windows.Forms.Button emergencyDoctorMenuButton;
        private System.Windows.Forms.Button workingHoursMenuButton;
        private System.Windows.Forms.Button usersMenuButton;
    }
}