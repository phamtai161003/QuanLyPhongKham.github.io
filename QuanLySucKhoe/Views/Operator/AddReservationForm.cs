using MetroFramework;
using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Operator
{
    public partial class AddReservationForm : Form
    {
        private EPatientContext _context;
        private int ReservationToPrintId;

        public AddReservationForm()
        {
            InitializeComponent();
            _context = new EPatientContext();
        }

        private void AddReservationForm_Load(object sender, EventArgs e)
        {
            listBoxPatient.DisplayMember = "NameSurname";
            listBoxPatient.ValueMember = "Id";
            listBoxPatient.DataSource = _context.Patients.Select(t => new
            {
                Id = t.Id,
                NameSurname = t.Name + " " + t.Surname
            }).ToList();

            comboBoxPavilion.DisplayMember = "Name";
            comboBoxPavilion.ValueMember = "Id";
            comboBoxPavilion.DataSource = _context.Pavilions.ToList();
        }

        private void comboBoxPavilion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pavilionId = (int)comboBoxPavilion.SelectedValue;
            var services = _context.Services.Where(s => s.PavilionId == pavilionId).ToList();
            listBoxService.DisplayMember = "Name";
            listBoxService.ValueMember = "Id";
            listBoxService.DataSource = services;

            var doctors = _context.Users.Where(d => d.RoleId == Role.Doctor || d.RoleId == Role.Nurse)
                .Where(d => d.PavilionId == pavilionId).Select(d => new
                {
                    Id = d.Id,
                    NameSurname = d.Name + " " + d.Surname
                }).ToList();


            comboBoxDoctors.DisplayMember = "NameSurname";
            comboBoxDoctors.ValueMember = "Id";
            if (doctors.Count == 0)
                comboBoxDoctors.SelectedIndex = -1;
            comboBoxDoctors.DataSource = doctors;
        }

        private bool CheckIfNotInTimetable(int doctorId)
        {
            var dayPicked = (int)datePicker.Value.DayOfWeek;
            if (dayPicked == 0)
                dayPicked = 7;

            var timetable = _context.Timetables.FirstOrDefault(t => t.UserId == doctorId && t.DayOfTheWeek == dayPicked);
            if (timetable != null)
            {
                if (timetable.DayOff)
                    return true;

                var serviceDuration =
                    _context.Services.SingleOrDefault(s => s.Id == (int)listBoxService.SelectedValue).Duration;

                var visitEndTime = timePicker.Value.AddMinutes(serviceDuration);

                if (timetable.StartTime.Value.TimeOfDay > timePicker.Value.TimeOfDay ||
                    timetable.EndTime.Value.TimeOfDay < visitEndTime.TimeOfDay)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDoctorId = (comboBoxDoctors.SelectedValue != null) ? (int)comboBoxDoctors.SelectedValue : 0;

            labelDoctor.Text = comboBoxDoctors.GetItemText(comboBoxDoctors.SelectedItem);

            var reservations = _context.Reservations
                .Where(r => r.UserId == selectedDoctorId)
                .Where(r => DbFunctions.TruncateTime(r.StartTime) == DbFunctions.TruncateTime(datePicker.Value))
                .Include("Patient")
                .Include("Service")
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StartTime");
            dataTable.Columns.Add("EndTime");
            dataTable.Columns.Add("Service");
            dataTable.Columns.Add("Patient");

            foreach (var reservation in reservations)
            {
                DataRow row = dataTable.NewRow();
                row["StartTime"] = reservation.StartTime.TimeOfDay;
                row["EndTime"] = reservation.EndTime.TimeOfDay;
                row["Service"] = reservation.Service.Name;
                row["Patient"] = reservation.Patient.Name + " " + reservation.Patient.Surname;
                dataTable.Rows.Add(row);
            }

            gridDoctorBusy.DataSource = dataTable;

            fillTimeTableLabel(selectedDoctorId);
        }

        private void fillTimeTableLabel(int selectedDoctor)
        {
            var dayPicked = (int)datePicker.Value.DayOfWeek;
            if (dayPicked == 0)
                dayPicked = 7;

            var timetable = _context.Timetables.FirstOrDefault(t => t.UserId == selectedDoctor && t.DayOfTheWeek == dayPicked);

            if (timetable != null)
            {
                if (timetable.DayOff)
                    labelHours.Text = "Nghỉ";
                else
                    labelHours.Text = timetable.StartTime.Value.TimeOfDay + " - " + timetable.EndTime.Value.TimeOfDay;
            }
            else
                labelHours.Text = "";
        }

        private void textSearchPatient_TextChanged(object sender, EventArgs e)
        {
            var search = textSearchPatient.Text;
            listBoxPatient.DataSource = _context.Patients
                .Where(t => t.Name.Contains(search) || t.Surname.Contains(search))
                .Select(t => new
                {
                    Id = t.Id,
                    NameSurname = t.Name + " " + t.Surname
                }).ToList();
        }

        private void listBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPatient.Text = listBoxPatient.GetItemText(listBoxPatient.SelectedItem);
        }

        private void listBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            int serviceId = (int)listBoxService.SelectedValue;
            var service = _context.Services.FirstOrDefault(s => s.Id == serviceId);
            labelService.Text = service.Name + " - " + service.Price + " Lek";
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            labelDate.Text = datePicker.Value.ToShortDateString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedDoctorId = (comboBoxDoctors.SelectedValue != null) ? (int)comboBoxDoctors.SelectedValue : 0;
            var selectedServiceId = (listBoxService.SelectedValue != null) ? (int)listBoxService.SelectedValue : 0;
            var selectedPatientId = (listBoxPatient.SelectedValue != null) ? (int)listBoxPatient.SelectedValue : 0;

            if (selectedDoctorId == 0 || selectedServiceId == 0 || selectedPatientId == 0)
            {
                MetroMessageBox.Show(this, "Bạn phải chọn bệnh nhân, dịch vụ, và bác sĩ.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thời gian có sẵn và bác sĩ không nghỉ

            DateTime dateTime = new DateTime(
                datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day
            );

            dateTime = dateTime.AddHours(timePicker.Value.Hour);
            dateTime = dateTime.AddMinutes(timePicker.Value.Minute);
            var service = _context.Services.SingleOrDefault(s => s.Id == selectedServiceId);
            DateTime endDateTime = dateTime.AddMinutes(service.Duration);

            // Kiểm tra bác sĩ có đang làm việc không

            if (CheckIfNotInTimetable(selectedDoctorId))
            {
                MetroMessageBox.Show(this, "Lỗi", "Bác sĩ không làm việc trong khoảng thời gian và ngày bạn chọn.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra bác sĩ có bận không

            var reservations = _context.Reservations
                .Where(r => r.UserId == selectedDoctorId)
                .Where(r => (dateTime >= r.StartTime && dateTime <= r.EndTime) || (endDateTime >= r.StartTime && endDateTime <= r.EndTime) || (r.StartTime >= dateTime && r.EndTime <= endDateTime))
                .ToList();

            if (reservations.Count != 0)
            {
                MetroMessageBox.Show(this, "Lỗi", "Bác sĩ đang có cuộc hẹn trong khoảng thời gian bạn chọn.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Lưu cuộc hẹn

            Reservation reservation = new Reservation();
            reservation.StartTime = dateTime;
            reservation.EndTime = endDateTime;
            reservation.UserId = selectedDoctorId;
            reservation.PatientId = selectedPatientId;
            reservation.ServiceId = service.Id;
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            if (MetroMessageBox.Show(this, "Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                reservation.Paid = true;
                _context.SaveChanges();
                ReservationToPrintId = reservation.Id;
                PrintReservation();
            }

            DialogResult = DialogResult.OK;
        }

        private void PrintReservation()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += printDocument1_PrintPage;
                    printDocument.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var reservation = _context.Reservations.Include("User").Include("Patient").Include("Service").FirstOrDefault(r => r.Id == ReservationToPrintId);
            e.Graphics.DrawString("EPatient - Cuộc hẹn", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 100));
            e.Graphics.DrawString("Bệnh nhân: " + reservation.Patient.Name + " " + reservation.Patient.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 150));
            e.Graphics.DrawString("Ngày: " + reservation.StartTime.Date.ToShortDateString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 150));
            e.Graphics.DrawString("Bác sĩ: " + reservation.User.Name + " " + reservation.User.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 200));
            e.Graphics.DrawString("Giờ: " + reservation.StartTime.ToString("H:mm"), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 200));
            e.Graphics.DrawString("Dịch vụ: " + reservation.Service.Name, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 250));
            e.Graphics.DrawString("Giá: " + reservation.Service.Price + " Lek", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 250));
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(50, 80, 730, 250));
        }
    }
}
