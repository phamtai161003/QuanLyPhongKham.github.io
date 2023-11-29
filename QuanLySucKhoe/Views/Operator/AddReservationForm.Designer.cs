namespace QuanLySucKhoe.Views.Operator
{
    partial class AddReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.comboBoxPavilion = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.labelService = new MetroFramework.Controls.MetroLabel();
            this.labelDoctor = new MetroFramework.Controls.MetroLabel();
            this.labelPatient = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDoctorBusy = new MetroFramework.Controls.MetroGrid();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textSearchPatient = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorBusy)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.ItemHeight = 16;
            this.listBoxPatient.Location = new System.Drawing.Point(1, 73);
            this.listBoxPatient.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(312, 260);
            this.listBoxPatient.TabIndex = 0;
            this.listBoxPatient.SelectedIndexChanged += new System.EventHandler(this.listBoxPatient_SelectedIndexChanged);
            // 
            // comboBoxPavilion
            // 
            this.comboBoxPavilion.FormattingEnabled = true;
            this.comboBoxPavilion.Location = new System.Drawing.Point(1, 71);
            this.comboBoxPavilion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPavilion.Name = "comboBoxPavilion";
            this.comboBoxPavilion.Size = new System.Drawing.Size(312, 24);
            this.comboBoxPavilion.TabIndex = 2;
            this.comboBoxPavilion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPavilion_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(2, 25);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(312, 22);
            this.datePicker.TabIndex = 3;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 16;
            this.listBoxService.Location = new System.Drawing.Point(2, 105);
            this.listBoxService.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(312, 228);
            this.listBoxService.TabIndex = 2;
            this.listBoxService.SelectedIndexChanged += new System.EventHandler(this.listBoxService_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Location = new System.Drawing.Point(96, 107);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(244, 25);
            this.labelDate.TabIndex = 10;
            // 
            // labelService
            // 
            this.labelService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelService.Location = new System.Drawing.Point(96, 49);
            this.labelService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(244, 25);
            this.labelService.TabIndex = 9;
            
            // 
            // labelDoctor
            // 
            this.labelDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDoctor.Location = new System.Drawing.Point(96, 78);
            this.labelDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(244, 25);
            this.labelDoctor.TabIndex = 8;
            
            // 
            // labelPatient
            // 
            this.labelPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatient.Location = new System.Drawing.Point(96, 19);
            this.labelPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(244, 22);
            this.labelPatient.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(473, 21);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Thời gian:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(4, 108);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 24);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Dữ liệu:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(844, 54);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giờ:";
            // 
            // gridDoctorBusy
            // 
            this.gridDoctorBusy.AllowUserToResizeRows = false;
            this.gridDoctorBusy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDoctorBusy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDoctorBusy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDoctorBusy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDoctorBusy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDoctorBusy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDoctorBusy.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridDoctorBusy.EnableHeadersVisualStyles = false;
            this.gridDoctorBusy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDoctorBusy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDoctorBusy.Location = new System.Drawing.Point(2, 73);
            this.gridDoctorBusy.Margin = new System.Windows.Forms.Padding(4);
            this.gridDoctorBusy.Name = "gridDoctorBusy";
            this.gridDoctorBusy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDoctorBusy.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDoctorBusy.RowHeadersWidth = 62;
            this.gridDoctorBusy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDoctorBusy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoctorBusy.Size = new System.Drawing.Size(313, 224);
            this.gridDoctorBusy.TabIndex = 1;
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(2, 26);
            this.comboBoxDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(312, 24);
            this.comboBoxDoctors.TabIndex = 0;
            this.comboBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctors_SelectedIndexChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(473, 70);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(141, 22);
            this.timePicker.TabIndex = 3;
            this.timePicker.Value = new System.DateTime(2018, 2, 4, 0, 0, 0, 0);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(6, 58);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Dịch vụ:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 83);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Bác sĩ:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(1, 27);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 22);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bệnh nhân:";
            // 
            // textSearchPatient
            // 
            // 
            // 
            // 
            this.textSearchPatient.CustomButton.Image = null;
            this.textSearchPatient.CustomButton.Location = new System.Drawing.Point(285, 2);
            this.textSearchPatient.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchPatient.CustomButton.Name = "";
            this.textSearchPatient.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textSearchPatient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSearchPatient.CustomButton.TabIndex = 1;
            this.textSearchPatient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSearchPatient.CustomButton.UseSelectable = true;
            this.textSearchPatient.CustomButton.Visible = false;
            this.textSearchPatient.Lines = new string[0];
            this.textSearchPatient.Location = new System.Drawing.Point(2, 25);
            this.textSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchPatient.MaxLength = 32767;
            this.textSearchPatient.Name = "textSearchPatient";
            this.textSearchPatient.PasswordChar = '\0';
            this.textSearchPatient.PromptText = "Tìm kiếm bệnh nhân";
            this.textSearchPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSearchPatient.SelectedText = "";
            this.textSearchPatient.SelectionLength = 0;
            this.textSearchPatient.SelectionStart = 0;
            this.textSearchPatient.ShortcutsEnabled = true;
            this.textSearchPatient.Size = new System.Drawing.Size(311, 28);
            this.textSearchPatient.TabIndex = 1;
            this.textSearchPatient.UseSelectable = true;
            this.textSearchPatient.WaterMark = "Tìm kiếm bệnh nhân";
            this.textSearchPatient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSearchPatient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textSearchPatient.TextChanged += new System.EventHandler(this.textSearchPatient_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelHours);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gridDoctorBusy);
            this.groupBox3.Controls.Add(this.comboBoxDoctors);
            this.groupBox3.Location = new System.Drawing.Point(712, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(330, 354);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bác sĩ";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(116, 318);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(0, 16);
            this.labelHours.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPavilion);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.listBoxService);
            this.groupBox2.Location = new System.Drawing.Point(364, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(330, 354);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày && Dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSearchPatient);
            this.groupBox1.Controls.Add(this.listBoxPatient);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(330, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bệnh nhân";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelDate);
            this.groupBox4.Controls.Add(this.labelService);
            this.groupBox4.Controls.Add(this.labelDoctor);
            this.groupBox4.Controls.Add(this.labelPatient);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.timePicker);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Location = new System.Drawing.Point(9, 370);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1093, 136);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng quan";
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1130, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddReservationForm";
            this.Text = "AddReservationForm";
            this.Load += new System.EventHandler(this.AddReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorBusy)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxPavilion;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox listBoxService;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroLabel labelService;
        private MetroFramework.Controls.MetroLabel labelDoctor;
        private MetroFramework.Controls.MetroLabel labelPatient;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid gridDoctorBusy;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.DateTimePicker timePicker;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textSearchPatient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}