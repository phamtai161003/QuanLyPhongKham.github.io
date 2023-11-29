using QuanLySucKhoe.Models;
using QuanLySucKhoe.Models.Auth;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Staff
{
    public partial class TimetableControl : UserControl
    {
        private EPatientContext _context;

        public TimetableControl()
        {
            InitializeComponent();
            _context = new EPatientContext();
        }

        private void TimetableControl_Load(object sender, EventArgs e)
        {
            if (AuthUser.Model.RoleId == Role.Doctor)
            {

                if (_context != null)
                {
                    var doctor = _context.EmergencyDoctors.Where(d => d.UserId == AuthUser.Model.Id).ToList();
                    if (doctor != null)
                    {
                        emergencyDoctorBindingSource.DataSource = doctor;
                    }
                }
            }
            else if (AuthUser.Model.RoleId == Role.Nurse)
            {
                label1.Hide();
                //metroGridTimetable.Hide();
            }
            FillTimetable();
        }

        public void FillTimetable()
        {

            for (int i = 1; i <= 7; i++)
            {
                Timetable timetable = AuthUser.Model.Timetables.First(t => t.DayOfTheWeek == i);
                Label time = (Label)this.Controls.Find("time" + i, true)[0];
                time.Text = (timetable.DayOff == true)
                    ? "Nghỉ"
                    : timetable.StartTime.Value.TimeOfDay + " - " + timetable.EndTime.Value.TimeOfDay;
            }
        
    }
    }
}
