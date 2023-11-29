using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySucKhoe.Models.Auth;

namespace QuanLySucKhoe.Utilities
{
    public class Login
    {
        internal FormStartPosition StartPosition;
        private EPatientContext context;
        public bool LoggedIn(string username, string password,bool RememberMe)
        {
            using (context=new EPatientContext())
            {
                var user = context.Users.Include("TimeTables").SingleOrDefault(u => u.Username == username);
                if (user == null)
                {
                    return false;
                }
                var hashedpassword = user.Password;
                if (HashingPassword.CheckPassword(password,hashedpassword)) {
                    Remember(RememberMe, username, password);
                    AuthUser.Model = user;
                    return true;
                }
                return false;
            }
        }

        private void Remember(bool Check, string username, string password)
        {
            if (Check)
            {
                Properties.Settings.Default.LoginFormUsername = username;
                Properties.Settings.Default.LoginFormPassword = password;
            }
            else
            {
                Properties.Settings.Default.LoginFormUsername = null;
                Properties.Settings.Default.LoginFormPassword = null;
            }
            Properties.Settings.Default.LoginFormRememberMe = Check;
            Properties.Settings.Default.Save();
        }
    }
}
