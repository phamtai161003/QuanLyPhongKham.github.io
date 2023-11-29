﻿using QuanLySucKhoe.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Operator
{
    public partial class TimetablesControl : UserControl
    {
        private EPatientContext _context;

        public TimetablesControl()
        {
            InitializeComponent();
            _context = new EPatientContext();
            var query = _context.Users.Where(u => u.RoleId == Role.Doctor || u.RoleId == Role.Nurse).Include("TimeTables").ToList();
            userBindingSource.DataSource = query;
            roleBindingSource.DataSource = _context.Roles.ToList();
        }

        public void FillTimetable(User user)
        {
            for (int i = 1; i <= 7; i++)
            {
                Timetable timetable = user.Timetables.FirstOrDefault(t => t.DayOfTheWeek == i);
                Label time = (Label)this.Controls.Find("time" + i, true).FirstOrDefault();

                if (timetable != null)
                {
                    time.Text = (timetable.DayOff == true)
                        ? "Nghỉ"
                        : timetable.StartTime.Value.TimeOfDay + " - " + timetable.EndTime.Value.TimeOfDay;
                }
                else
                {
                    time.Text = "Chưa cài đặt";
                }
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userBindingSource.Current is User selectedUser)
            {
                FillTimetable(selectedUser);
            }
        }
    }
}
