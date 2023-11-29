using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using QuanLySucKhoe.Models;
using QuanLySucKhoe.Models.Auth;
using QuanLySucKhoe.Utilities;
using QuanLySucKhoe.Views;


namespace QuanLySucKhoe
{

    public partial class LoginForm : Form
    {
        private readonly Login log;
        public LoginForm() {
            InitializeComponent();
            log = new Login();
        }

        private void btnxn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (log.LoggedIn(user.Text, pass.Text, checkBoxRememberMe.Checked)) 
                {
                    Form mainform = null;
                    switch (AuthUser.Model.RoleId)
                    {
                        case Role.Admin: mainform = new AdminForm();
                            break;
                        case Role.Operator: mainform = new OperatorForm();
                            break;
                        default:mainform = new StaffForm();
                            break;
                    }
                    this.Hide();
                    mainform.ShowDialog();
                }
                else { MessageBox.Show("lỗi");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Activate();
            if (Properties.Settings.Default.LoginFormRememberMe)
            {
                user.Text = Properties.Settings.Default.LoginFormUsername;
                pass.Text = Properties.Settings.Default.LoginFormPassword;
                checkBoxRememberMe.Checked = Properties.Settings.Default.LoginFormRememberMe;
            }
        }

        private void user_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(user.Text)) 
            {
            e.Cancel = true;
            user.Focus();
            ErrorProvider.SetError(user, "nhập username");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(user, null);
            }
        }
    }
}
