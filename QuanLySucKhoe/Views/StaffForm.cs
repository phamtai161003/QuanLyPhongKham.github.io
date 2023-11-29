using QuanLySucKhoe.Models.Auth;
using QuanLySucKhoe.Views.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe
{
    public partial class StaffForm : Form
    {
        private Button[] _menuButtons;
        public StaffForm()
        {
            InitializeComponent();
        }

        

        private void StaffForm_Load(object sender, EventArgs e)
        {
            _menuButtons = new[]
            {
                reservationsMenuButton,
                timetablesMenuButton
            };


            labelName.Text = AuthUser.Model.Name + " " + AuthUser.Model.Surname;

            ReservationControl reservationControl = new ReservationControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(reservationControl);

            UnderlineMenuButton(reservationsMenuButton);
        }
        private void UnderlineMenuButton(Button b)
        {
            foreach (Button currentButton in _menuButtons)
            {
                if (currentButton == b)
                {
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Underline);
                }
                else
                {
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Regular);
                }
            }
        }
        private void usersMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ReservationControl reservationControl = new ReservationControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(reservationControl);
            UnderlineMenuButton(reservationsMenuButton);
        }

        private void timetablesMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TimetableControl timetableControl = new TimetableControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(timetableControl);
            UnderlineMenuButton(timetablesMenuButton);
        }
        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            AuthUser.Model = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
