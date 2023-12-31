﻿using QuanLySucKhoe.Models;
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
    public partial class EmergencyDoctorControl : UserControl
    {
        private EPatientContext _context;
        private BindingSource source;
        private EmergencyDoctor _currentEmergencyDoctor;
        public EmergencyDoctorControl()
        {
            InitializeComponent();
        }
        private List<dynamic> GetItems()
        {
            return (from em in _context.EmergencyDoctors
                    join u in _context.Users on em.UserId equals u.Id
                    join p in _context.Pavilions on u.PavilionId equals p.Id
                    select new
                    {
                        id = em.Id,
                        emergencyDate = em.Date,
                        name = u.Name,
                        surname = u.Surname,
                        pavilion = p.Name
                    })
                .OrderBy(table => table.emergencyDate)
                .ToList<dynamic>();
        }

        private void EmergencyDoctorControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            source = new BindingSource { DataSource = GetItems() };

            if (source.Count != 0)
            {
                StyleGrid();
            }

            cboUsername.DisplayMember = "Username";
            cboUsername.ValueMember = "Id";
        }
        private void StyleGrid()
        {
            metroGrid1.DataSource = source;
            metroGrid1.Columns[0].Width = 140;
            metroGrid1.Columns[1].Width = 320;
            metroGrid1.Columns[1].HeaderText = "Ngày trực";
            metroGrid1.Columns[2].Width = 350;
            metroGrid1.Columns[2].HeaderText = "Tên";
            metroGrid1.Columns[3].Width = 300;
            metroGrid1.Columns[3].HeaderText = "Họ";
            metroGrid1.Columns[4].Width = 350;
            metroGrid1.Columns[4].HeaderText = "Khoa bệnh";

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var query = _context.Users.Where(u => u.RoleId == Role.Doctor || u.RoleId == Role.Nurse).ToList();
            if (query.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Không có bác sĩ hay y tá", "Thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            DateTime startDate;
            EmergencyDoctor lastEmergencyDoctor =
                _context.EmergencyDoctors.OrderByDescending(em => em.Id).FirstOrDefault();

            if (lastEmergencyDoctor == null)
            {
                startDate = DateTime.Today;
            }
            else
            {
                startDate = lastEmergencyDoctor.Date.AddDays(1);
            }

            foreach (Pavilion pavilion in _context.Pavilions.ToList())
            {
                var doctors = _context.Users.Where(u => u.RoleId == Role.Doctor && u.PavilionId == pavilion.Id)
                    .ToList();
                
                if (doctors.Count == 0)
                    continue;
                var yesterday = startDate.AddDays(-1);              
                var lastDoctorId = (from em in _context.EmergencyDoctors
                                    join u in _context.Users on em.UserId equals u.Id
                                    where u.PavilionId == pavilion.Id && em.Date == yesterday
                                    select u.Id).SingleOrDefault();

                for (int i = 0; i < 30; i++)
                {
                    var currentDate = startDate.AddDays(i);
                    int dayDoctorId;

                    if (lastDoctorId == 0)
                        dayDoctorId = doctors[0].Id;
                    else
                    {
                        int lastDoctorIndex = doctors.IndexOf(doctors.FirstOrDefault(d => d.Id == lastDoctorId));
                        if (lastDoctorIndex == doctors.Count - 1)
                            dayDoctorId = doctors[0].Id;
                        else
                            dayDoctorId = doctors[lastDoctorIndex + 1].Id;
                    }

                    EmergencyDoctor emergencyDoctor = new EmergencyDoctor
                    {
                        Date = currentDate,
                        UserId = dayDoctorId
                    };

                    _context.EmergencyDoctors.Add(emergencyDoctor);
                    _context.SaveChanges();

                    lastDoctorId = dayDoctorId;
                }
            }

            source.DataSource = GetItems();
            StyleGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dynamic selectedItem = source.Current;
            if (selectedItem != null)
            {
                int selectedItemId = selectedItem.id;
                groupBoxEdit.Show();
                _currentEmergencyDoctor = _context.EmergencyDoctors.Where(em => em.Id == selectedItemId).Include(em => em.User).Single();
                textDate.Text = _currentEmergencyDoctor.Date.ToString();

                int? pavilionId = _currentEmergencyDoctor.User.PavilionId;
                cboUsername.DataSource = _context.Users.Where(u => u.PavilionId == pavilionId && u.RoleId == Role.Doctor).ToList();
                cboUsername.SelectedIndex = cboUsername.FindStringExact(_currentEmergencyDoctor.User.Username);
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            _currentEmergencyDoctor = null;
            groupBoxEdit.Hide();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            _currentEmergencyDoctor.UserId = (int)cboUsername.SelectedValue;
            _context.SaveChanges();
            _currentEmergencyDoctor = null;
            groupBoxEdit.Hide();
            source.DataSource = GetItems();
        }
    }
}
