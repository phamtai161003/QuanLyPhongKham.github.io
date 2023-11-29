using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Admin
{
    public partial class AddEditUserForm : Form
    {
        public User UserInfo => bindingSourceUser.Current as User;

        public AddEditUserForm(User obj)
        {
            InitializeComponent();
            bindingSourceUser.DataSource = obj;
        }
        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            if (UserInfo != null)
            {
                cboRole.DisplayMember = "Name";
                cboRole.ValueMember = "Id";
                cboPavilion.DisplayMember = "Name";
                cboPavilion.ValueMember = "Id";

                using (EPatientContext _context = new EPatientContext())
                {
                    // Kiểm tra có dữ liệu trong bảng Roles
                    var roles = _context.Roles.ToList();
                    if (roles.Count > 0)
                    {
                        cboRole.DataSource = roles;

                        // Kiểm tra RoleId trước khi chọn mặc định
                        if (UserInfo.RoleId != 0)
                        {
                            int roleIndex = cboRole.FindStringExact(UserInfo.Role.Name);
                            if (roleIndex != -1)
                            {
                                cboRole.SelectedIndex = roleIndex;
                            }
                        }
                    }

                    // Kiểm tra có dữ liệu trong bảng Pavilions
                    var pavilions = _context.Pavilions.ToList();
                    if (pavilions.Count > 0)
                    {
                        cboPavilion.DataSource = pavilions;

                        // Kiểm tra PavilionId trước khi chọn mặc định
                        if (UserInfo.PavilionId != null)
                        {
                            int pavilionIndex = cboPavilion.FindStringExact(UserInfo.Pavilion.Name);
                            if (pavilionIndex != -1)
                            {
                                cboPavilion.SelectedIndex = pavilionIndex;
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(UserInfo.Name))
                {
                    textPassword.Enabled = true;
                    checkBoxEditPassword.Hide();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrEmpty(textPassword.Text))
                {
                    UserInfo.Password = Utilities.HashingPassword.Hash(textPassword.Text);
                }

                bindingSourceUser.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditPassword.Checked)
            {
                textPassword.Enabled = true;
            }
            else
            {
                textPassword.Enabled = false;
            }
        }

       
        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Vui lòng nhập tên người dùng (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textSurname.Text) || textSurname.Text.Length > 255)
            {
                e.Cancel = true;
                textSurname.Focus();
                errorProvider.SetError(textSurname, "Vui lòng nhập họ người dùng (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textSurname, null);
            }
        }

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text) || textUsername.Text.Length > 255)
            {
                e.Cancel = true;
                textUsername.Focus();
                errorProvider.SetError(textUsername, "Vui lòng nhập tên đăng nhập (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textUsername, null);
            }
        }

        private void cboRole_Validating(object sender, CancelEventArgs e)
        {
            if (cboRole.SelectedIndex < 0)
            {
                e.Cancel = true;
                cboRole.Focus();
                errorProvider.SetError(cboRole, "Chọn vai trò của bạn");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cboRole, null);
            }
        }

        
    }
}
