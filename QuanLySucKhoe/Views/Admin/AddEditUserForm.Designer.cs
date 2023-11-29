namespace QuanLySucKhoe.Views.Admin
{
    partial class AddEditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxEditPassword = new System.Windows.Forms.CheckBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.cboPavilion = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label2.Location = new System.Drawing.Point(82, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label3.Location = new System.Drawing.Point(82, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label4.Location = new System.Drawing.Point(82, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label5.Location = new System.Drawing.Point(82, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label6.Location = new System.Drawing.Point(82, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khoa ";
            // 
            // textName
            // 
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Name", true));
            this.textName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textName.Location = new System.Drawing.Point(258, 98);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(519, 40);
            this.textName.TabIndex = 6;
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(QuanLySucKhoe.Models.User);
            // 
            // checkBoxEditPassword
            // 
            this.checkBoxEditPassword.AutoSize = true;
            this.checkBoxEditPassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.checkBoxEditPassword.Location = new System.Drawing.Point(806, 328);
            this.checkBoxEditPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEditPassword.Name = "checkBoxEditPassword";
            this.checkBoxEditPassword.Size = new System.Drawing.Size(149, 37);
            this.checkBoxEditPassword.TabIndex = 10;
            this.checkBoxEditPassword.Text = "Cho phép";
            this.checkBoxEditPassword.UseVisualStyleBackColor = true;
            this.checkBoxEditPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cboRole
            // 
            this.cboRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "RoleId", true));
            this.cboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(258, 402);
            this.cboRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(201, 40);
            this.cboRole.TabIndex = 11;
            this.cboRole.Validating += new System.ComponentModel.CancelEventHandler(this.cboRole_Validating);
            // 
            // textSurname
            // 
            this.textSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Surname", true));
            this.textSurname.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textSurname.Location = new System.Drawing.Point(258, 172);
            this.textSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(519, 40);
            this.textSurname.TabIndex = 12;
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textSurname_Validating);
            // 
            // textUsername
            // 
            this.textUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Username", true));
            this.textUsername.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textUsername.Location = new System.Drawing.Point(258, 245);
            this.textUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(519, 40);
            this.textUsername.TabIndex = 13;
            this.textUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textUsername_Validating);
            // 
            // textPassword
            // 
            this.textPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Password", true));
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textPassword.Location = new System.Drawing.Point(258, 322);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(519, 40);
            this.textPassword.TabIndex = 14;
            // 
            // cboPavilion
            // 
            this.cboPavilion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "PavilionId", true));
            this.cboPavilion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboPavilion.FormattingEnabled = true;
            this.cboPavilion.Location = new System.Drawing.Point(258, 482);
            this.cboPavilion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPavilion.Name = "cboPavilion";
            this.cboPavilion.Size = new System.Drawing.Size(201, 40);
            this.cboPavilion.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(915, 542);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 76);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 631);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPavilion);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.checkBoxEditPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditUserForm";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.CheckBox checkBoxEditPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.ComboBox cboPavilion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}