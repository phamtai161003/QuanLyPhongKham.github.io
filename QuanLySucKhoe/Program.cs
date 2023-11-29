using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SplashScreen
            Thread t = new Thread(() =>
            {
                frmSplashScreen frm = new frmSplashScreen();
                Application.Run(frm);
            });
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(new LoginForm());
        }
    }
}
