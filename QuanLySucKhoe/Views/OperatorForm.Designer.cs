namespace QuanLySucKhoe
{
    partial class OperatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.timetablesMenuButton = new System.Windows.Forms.Button();
            this.reservationsMenuButton = new System.Windows.Forms.Button();
            this.patientsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.timetablesMenuButton);
            this.panel1.Controls.Add(this.reservationsMenuButton);
            this.panel1.Controls.Add(this.patientsMenuButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 732);
            this.panel1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(4, 634);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(211, 35);
            this.labelName.TabIndex = 9;
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Location = new System.Drawing.Point(0, 671);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(215, 60);
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
            this.timetablesMenuButton.Location = new System.Drawing.Point(0, 214);
            this.timetablesMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetablesMenuButton.Name = "timetablesMenuButton";
            this.timetablesMenuButton.Size = new System.Drawing.Size(215, 70);
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
            this.reservationsMenuButton.Location = new System.Drawing.Point(0, 146);
            this.reservationsMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reservationsMenuButton.Name = "reservationsMenuButton";
            this.reservationsMenuButton.Size = new System.Drawing.Size(215, 70);
            this.reservationsMenuButton.TabIndex = 2;
            this.reservationsMenuButton.Text = "Đặt chỗ";
            this.reservationsMenuButton.UseVisualStyleBackColor = false;
            this.reservationsMenuButton.Click += new System.EventHandler(this.reservationsMenuButton_Click);
            // 
            // patientsMenuButton
            // 
            this.patientsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientsMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.patientsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientsMenuButton.Location = new System.Drawing.Point(0, 78);
            this.patientsMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientsMenuButton.Name = "patientsMenuButton";
            this.patientsMenuButton.Size = new System.Drawing.Size(215, 70);
            this.patientsMenuButton.TabIndex = 1;
            this.patientsMenuButton.Text = "Bệnh nhân";
            this.patientsMenuButton.UseVisualStyleBackColor = false;
            this.patientsMenuButton.Click += new System.EventHandler(this.patientsMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điều khiển";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(228, 8);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1124, 728);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 738);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            this.MaximumSizeChanged += new System.EventHandler(this.patientsMenuButton_Click);
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button timetablesMenuButton;
        private System.Windows.Forms.Button reservationsMenuButton;
        private System.Windows.Forms.Button patientsMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelName;
    }
}