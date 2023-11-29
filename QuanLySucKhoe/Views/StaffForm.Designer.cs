namespace QuanLySucKhoe
{
    partial class StaffForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.timetablesMenuButton = new System.Windows.Forms.Button();
            this.reservationsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(214, 7);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1133, 636);
            this.mainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.timetablesMenuButton);
            this.panel1.Controls.Add(this.reservationsMenuButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 636);
            this.panel1.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(0, 550);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(199, 29);
            this.labelName.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Location = new System.Drawing.Point(0, 590);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(201, 44);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Logout";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // timetablesMenuButton
            // 
            this.timetablesMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timetablesMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.timetablesMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timetablesMenuButton.Location = new System.Drawing.Point(0, 146);
            this.timetablesMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.timetablesMenuButton.Name = "timetablesMenuButton";
            this.timetablesMenuButton.Size = new System.Drawing.Size(201, 64);
            this.timetablesMenuButton.TabIndex = 2;
            this.timetablesMenuButton.Text = "Thời gian biểu";
            this.timetablesMenuButton.UseVisualStyleBackColor = false;
            this.timetablesMenuButton.Click += new System.EventHandler(this.timetablesMenuButton_Click);
            // 
            // reservationsMenuButton
            // 
            this.reservationsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reservationsMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.reservationsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsMenuButton.Location = new System.Drawing.Point(0, 78);
            this.reservationsMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.reservationsMenuButton.Name = "reservationsMenuButton";
            this.reservationsMenuButton.Size = new System.Drawing.Size(201, 64);
            this.reservationsMenuButton.TabIndex = 1;
            this.reservationsMenuButton.Text = "Lịch đặt chỗ";
            this.reservationsMenuButton.UseVisualStyleBackColor = false;
            this.reservationsMenuButton.Click += new System.EventHandler(this.usersMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng nhân viên";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 656);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button timetablesMenuButton;
        private System.Windows.Forms.Button reservationsMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
    }
}