﻿using MetroFramework;
using MetroFramework.Controls;
using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Admin
{
    public partial class TimetablesControl : UserControl
    {
        private EPatientContext _context;
        private User _currentUser = null;
        public TimetablesControl()
        {
            InitializeComponent();
        }



        private void TimetablesControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            usersBindingSource.DataSource = _context.Users.Where(u => u.RoleId == Role.Doctor || u.RoleId == Role.Nurse).Include(u => u.Timetables).ToList();
            rolesBindingSource.DataSource = _context.Roles.ToList();
            pavilionsBindingSource.DataSource = _context.Pavilions.ToList();
            timetablePanel.Hide();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (usersBindingSource.Current is User selectedUser)
            {
                _currentUser = selectedUser;
                userLabel.Text = "Thời gian biểu của : " + _currentUser.Name;
                timetablePanel.Show();
                FillTimetable();
            }
        }
        public void FillTimetable()
        {
            for (int i = 1; i <= 7; i++)
            {
                Timetable timetable = _currentUser.Timetables.First(t => t.DayOfTheWeek == i);
                DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + i, true)[0];
                DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                MetroCheckBox checkDayOff = (MetroCheckBox)this.Controls.Find("checkDayOff" + i, true)[0];


                startTimePicker.Value = (timetable.StartTime == null) ? DateTime.Today : (DateTime)timetable.StartTime;
                endTimePicker.Value = (timetable.EndTime == null) ? DateTime.Today : (DateTime)timetable.EndTime;
                checkDayOff.Checked = timetable.DayOff;
            }
        }

        private void checkDayOff1_CheckedChanged(object sender, EventArgs e)
        {
            MetroCheckBox cb = sender as MetroCheckBox;

            string cbName = cb.Name;
            int index = int.Parse(cbName.Substring(cbName.Length - 1));

            DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + index, true)[0];
            DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + index, true)[0];

            startTimePicker.Enabled = !cb.Checked;
            endTimePicker.Enabled = !cb.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateStartTime())
            {
                for (int i = 1; i <= 7; i++)
                {
                    Timetable timetable = _currentUser.Timetables.First(t => t.DayOfTheWeek == i);
                    DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + i, true)[0];
                    DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                    MetroCheckBox checkDayOff = (MetroCheckBox)this.Controls.Find("checkDayOff" + i, true)[0];

                    timetable.DayOff = checkDayOff.Checked;

                    if (checkDayOff.Checked)
                    {
                        timetable.StartTime = null;
                        timetable.EndTime = null;
                    }
                    else
                    {
                        timetable.StartTime = startTimePicker.Value;
                        timetable.EndTime = endTimePicker.Value;
                    }

                    timetablePanel.Hide();
                }

                usersBindingSource.EndEdit();
                _context.SaveChanges();
                MetroMessageBox.Show(this, "Lưu thành công", "Tin nhắn", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
            else
            {
                MetroMessageBox.Show(this, "Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "Tin nhắn", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timetablePanel.Hide();
        }
        public bool ValidateStartTime()
        {
            for (int i = 1; i <= 7; i++)
            {
                DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + i, true)[0];
                DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                if (startTimePicker.Value > endTimePicker.Value)
                    return false;

            }

            return true;
        }
    }
}
