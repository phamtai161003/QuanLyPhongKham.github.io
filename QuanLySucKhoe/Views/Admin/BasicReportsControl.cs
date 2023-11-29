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
    public partial class BasicReportsControl : UserControl
    {
        private EPatientContext _context;
        private WebBrowser myWebBrowser = new WebBrowser();
        private List<DoctorReport> _doctorReports;
        private List<ServiceReport> _serviceReports;
        private List<PatientReport> _patientReports;

        private DateTime _reservationsStartFilter;
        private DateTime _reservationsEndFilter;
        private int _reservationsCount;
        public BasicReportsControl()
        {
            _context = new EPatientContext();
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            InitializeComponent();
            FillGrids();
        }
        public void FillGrids()
        {
            var reservations = _context.Reservations.Where(r => !checkBoxEnable.Checked ||
                                                                DbFunctions.TruncateTime(r.StartTime) >=
                                                                DbFunctions.TruncateTime(dateTimePicker1.Value) &&
                                                                DbFunctions.TruncateTime(r.StartTime) <=
                                                                DbFunctions.TruncateTime(dateTimePicker2.Value));
            if (checkBoxEnable.Checked)
            {
                textStartDate.Text = dateTimePicker1.Value.ToShortDateString();
                textEndDate.Text = dateTimePicker2.Value.ToShortDateString();
            }
            else
            {
                var firstReservation = reservations.FirstOrDefault();
                var lastReservation = reservations.OrderByDescending(r => r.Id).FirstOrDefault();
                textStartDate.Text = firstReservation != null ? firstReservation.StartTime.ToShortDateString() : "";
                textEndDate.Text = lastReservation != null ? lastReservation.StartTime.ToShortDateString() : "";

                if (firstReservation != null)
                    _reservationsStartFilter = firstReservation.StartTime;
                if (lastReservation != null)
                    _reservationsEndFilter = lastReservation.StartTime;
            }

            textTotReservations.Text = reservations.Count().ToString();
            _reservationsCount = reservations.Count();

            FillDoctorsGrid();
            FillServicesGrid();
            FillPatientsGrid();
        }

        public void FillDoctorsGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("User")
                .Include("Service")
                .GroupBy(t => t.UserId)
                .Select(t => new DoctorReport()
                {
                    UserNameSurname = t.Select(r => r.User.Name + " " + r.User.Surname).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0),
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _doctorReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Bác sĩ");
            dataTable.Columns.Add("Tổng số lịch hẹn");
            dataTable.Columns.Add("Tổng thu nhập");

            foreach (var doctorReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Bác sĩ"] = doctorReport.UserNameSurname;
                row["Tổng số lịch hẹn"] = doctorReport.TotalReservations;
                row["Tổng thu nhập"] = $"{doctorReport.TotalPrice:N0} VND"; 
                dataTable.Rows.Add(row);
            }

            metroGridDoctor.DataSource = dataTable;
        }

        public void FillServicesGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("Service")
                .GroupBy(t => t.ServiceId)
                .Select(t => new ServiceReport()
                {
                    ServiceName = t.Select(r => r.Service.Name).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0),
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _serviceReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Dịch vụ");
            dataTable.Columns.Add("Tổng số lịch hẹn");
            dataTable.Columns.Add("Tổng thu nhập");

            foreach (var serviceReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Dịch vụ"] = serviceReport.ServiceName;
                row["Tổng số lịch hẹn"] = serviceReport.TotalReservations;
                row["Tổng thu nhập"] = $"{serviceReport.TotalPrice:N0} VND"; // Format tiền tệ thành nghìn
                dataTable.Rows.Add(row);
            }

            metroGridService.DataSource = dataTable;
        }

        public void FillPatientsGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("Patient")
                .Include("Service")
                .GroupBy(t => t.PatientId)
                .Select(t => new PatientReport()
                {
                    PatientNameSurname = t.Select(r => r.Patient.Name + " " + r.Patient.Surname).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0),
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _patientReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Bệnh nhân");
            dataTable.Columns.Add("Tổng số lịch hẹn");
            dataTable.Columns.Add("Tổng thu nhập");

            foreach (var patientReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Bệnh nhân"] = patientReport.PatientNameSurname;
                row["Tổng số lịch hẹn"] = patientReport.TotalReservations;
                row["Tổng thu nhập"] = $"{patientReport.TotalPrice:N0} VND"; // Format tiền tệ thành nghìn
                dataTable.Rows.Add(row);
            }

            metroGridPatient.DataSource = dataTable;
        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPageSetupDialog();
            myWebBrowser.ShowPrintDialog();
        }

        private void checkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnable.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                FillGrids();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void btnPrintDoctor_Click(object sender, EventArgs e)
        {
            string ModelName = "Doctor";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $@"<!DOCTYPE html> <html> <body> <h2 style='text-align: center;'>{ModelName} Report</h2> <br><br> <h3 style='text-align:center;'>Báo Cáo từ {startDate} đến {endDate}</h3> <h3 style='text-align:center;'>Tổng số Đặt chỗ: {reservationsCount}</h3> <br><br> <table style='border: 1px solid black; border-collapse: collapse; width: 100%;'> <tr style='text-align: center;'> <th style='border: 1px solid black; border-collapse: collapse;'>{ModelName}</th> <th style='border: 1px solid black; border-collapse: collapse;'>Tổng số Đặt chỗ</th> <th style='border: 1px solid black; border-collapse: collapse;'>Tổng Thu Nhập</th> </tr>";

            string body = "";

            foreach (var doctor in _doctorReports)
            {
                string name = doctor.UserNameSurname;
                string totalReservations = doctor.TotalReservations.ToString();
                string totalIncome = doctor.TotalPrice.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{name}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalIncome}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void btnPrintService_Click(object sender, EventArgs e)
        {
            string ModelName = "Service";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $"<!DOCTYPE html> <html> <body> <h2 style='text-align: center;'>Báo Cáo {ModelName}</h2> <br><br> <h3 style='text-align:center;'>Báo Cáo từ {startDate} đến {endDate}</h3> <h3 style='text-align:center;'>Tổng số Đặt chỗ: {reservationsCount}</h3> <br><br> <table style='border: 1px solid black; border-collapse: collapse; width: 100%;'> <tr style='text-align: center;'> <th style='border: 1px solid black; border-collapse: collapse;'>{ModelName}</th> <th style='border: 1px solid black; border-collapse: collapse;'>Tổng số Đặt chỗ</th> <th style='border: 1px solid black; border-collapse: collapse;'>Tổng Thu Nhập</th> </tr>";

            string body = "";

            foreach (var service in _serviceReports)
            {
                string name = service.ServiceName;
                string totalReservations = service.TotalReservations.ToString();
                string totalIncome = service.TotalPrice.ToString();
                string reservationString = $"<tr style='text-align: center;'> <td style='border: 1px solid black; border-collapse: collapse;'>{name}</td> <td style='border: 1px solid black; border-collapse: collapse;'>{totalReservations}</td> <td style='border: 1px solid black; border-collapse: collapse;'>{totalIncome}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void btnPrintPatient_Click(object sender, EventArgs e)
        {
            string ModelName = "Patient";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $@"<!DOCTYPE html>
<html>
<body>
    <h2 style='text-align: center;'>{ModelName} Report</h2>
    <br><br>
    <h3 style='text-align:center;'>Báo Cáo từ {startDate} đến {endDate}</h3>
    <h3 style='text-align:center;'>Tổng số Đặt chỗ: {reservationsCount}</h3>
    <br><br>
    <table style='border: 1px solid black; border-collapse: collapse; width: 100%;'>
        <tr style='text-align: center;'>
            <th style='border: 1px solid black; border-collapse: collapse;'>{ModelName}</th>
            <th style='border: 1px solid black; border-collapse: collapse;'>Tổng số Đặt chỗ</th>
            <th style='border: 1px solid black; border-collapse: collapse;'>Tổng Thu Nhập</th>
        </tr>";

            string body = "";

            foreach (var patient in _patientReports)
            {
                string name = patient.PatientNameSurname;
                string totalReservations = patient.TotalReservations.ToString();
                string totalIncome = patient.TotalPrice.ToString();
                string reservationString = $@"<tr style='text-align: center;'>
    <td style='border: 1px solid black; border-collapse: collapse;'>{name}</td>
    <td style='border: 1px solid black; border-collapse: collapse;'>{totalReservations}</td>
    <td style='border: 1px solid black; border-collapse: collapse;'>{totalIncome}</td>
</tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }
    }
    class DoctorReport
    {
        public string UserNameSurname;
        public int TotalReservations;
        public float TotalPrice;
    }

    class ServiceReport
    {
        public string ServiceName;
        public int TotalReservations;
        public float TotalPrice;
    }

    class PatientReport
    {
        public string PatientNameSurname;
        public int TotalReservations;
        public float TotalPrice;
    }
}
