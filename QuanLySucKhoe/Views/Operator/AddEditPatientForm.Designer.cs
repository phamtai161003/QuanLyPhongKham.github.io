namespace QuanLySucKhoe.Views.Operator
{
    partial class AddEditPatientForm
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAllergies = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(120, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(120, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 33);
            this.label4.TabIndex = 37;
            this.label4.Text = "Họ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(120, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 38;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(120, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(120, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(120, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 33);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(120, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 33);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ghi chú:";
            // 
            // textName
            // 
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.textName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textName.Location = new System.Drawing.Point(288, 155);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(494, 40);
            this.textName.TabIndex = 43;
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // textSurname
            // 
            this.textSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.textSurname.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textSurname.Location = new System.Drawing.Point(288, 228);
            this.textSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(494, 40);
            this.textSurname.TabIndex = 44;
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textSurname_Validating);
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Email", true));
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textEmail.Location = new System.Drawing.Point(288, 284);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(494, 40);
            this.textEmail.TabIndex = 45;
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // dateBirthday
            // 
            this.dateBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Birthday", true));
            this.dateBirthday.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateBirthday.Location = new System.Drawing.Point(288, 355);
            this.dateBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(494, 40);
            this.dateBirthday.TabIndex = 46;
            this.dateBirthday.Validating += new System.ComponentModel.CancelEventHandler(this.dateBirthday_Validating);
            // 
            // textPhone
            // 
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.textPhone.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textPhone.Location = new System.Drawing.Point(288, 490);
            this.textPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(494, 40);
            this.textPhone.TabIndex = 48;
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // textAllergies
            // 
            this.textAllergies.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Allergies", true));
            this.textAllergies.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textAllergies.Location = new System.Drawing.Point(288, 555);
            this.textAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAllergies.Multiline = true;
            this.textAllergies.Name = "textAllergies";
            this.textAllergies.Size = new System.Drawing.Size(494, 242);
            this.textAllergies.TabIndex = 49;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(467, 828);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 49);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.patientBindingSource, "Gender", true));
            this.checkBoxGender.Location = new System.Drawing.Point(288, 432);
            this.checkBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(53, 24);
            this.checkBoxGender.TabIndex = 52;
            this.checkBoxGender.Text = "??";
            this.checkBoxGender.UseVisualStyleBackColor = true;
            this.checkBoxGender.CheckStateChanged += new System.EventHandler(this.checkBoxGender_CheckStateChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(QuanLySucKhoe.Models.Patient);
            // 
            // AddEditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 918);
            this.Controls.Add(this.checkBoxGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textAllergies);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEditPatientForm";
            this.Text = "AddEditPatientForm";
            this.Load += new System.EventHandler(this.AddEditPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textAllergies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}