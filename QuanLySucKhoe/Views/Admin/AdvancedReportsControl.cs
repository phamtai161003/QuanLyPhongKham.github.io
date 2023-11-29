using LiveCharts.Wpf;
using LiveCharts;
using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brushes = System.Windows.Media.Brushes;
using System.Data.Entity;
using System.Drawing.Printing;

namespace QuanLySucKhoe.Views.Admin
{
    public partial class AdvancedReportsControl : UserControl
    {
        private EPatientContext _context;
        private WebBrowser myWebBrowser = new WebBrowser();
        private User _selectedDoctor;
        private int _selectedDoctorId;
        private List<DateReport> _dateReports;
        private List<HourReport> _hourReports;
        public AdvancedReportsControl()
        {
            _context = new EPatientContext();
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            InitializeComponent();

            listBoxSearchDoctor.DisplayMember = "NameSurname";
            listBoxSearchDoctor.ValueMember = "Id";
            var doctors = _context.Users.Where(d => d.RoleId == Role.Doctor || d.RoleId == Role.Nurse).Select(t => new
            {
                Id = t.Id,
                NameSurname = t.Name + " " + t.Surname
            }).ToList();

            doctors.Insert(0, new { Id = 0, NameSurname = "All Doctors" });
            listBoxSearchDoctor.DataSource = doctors;

        }
        public void FillChart1()
        {
            cartesianChart1.Series = new SeriesCollection();
            cartesianChart1.AxisX = new AxesCollection();
            cartesianChart1.AxisY = new AxesCollection();

            var seriesValue = new ChartValues<double>();
            List<string> labelsValue = new List<string>();

            foreach (var dateReport in _dateReports.OrderBy(t => t.Date))
            {
                labelsValue.Add(dateReport.Date.Value.ToShortDateString());
                seriesValue.Add(dateReport.TotalReservations);
            }
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Đặt chỗ",
                    Values = seriesValue,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = labelsValue
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sự đặt chỗ",
                Separator = new Separator
                {
                    Step = 1
                },
                MinValue = 0
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.Background = Brushes.White;
        }

        public void FillChart2()
        {
            cartesianChart2.Series = new SeriesCollection();
            cartesianChart2.AxisX = new AxesCollection();
            cartesianChart2.AxisY = new AxesCollection();

            var seriesValue = new ChartValues<double>();
            List<string> labelsValue = new List<string>();

            foreach (var hourReport in _hourReports)
            {
                labelsValue.Add(hourReport.Hour + ":00 - " + hourReport.Hour + ":59");
                seriesValue.Add(hourReport.TotalReservations);
            }

            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lịch hẹn",
                    Values = seriesValue,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Giờ",
                Labels = labelsValue
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Lich hẹn",
                Separator = new Separator
                {
                    Step = 1
                },
                MinValue = 0
            });

            cartesianChart2.LegendLocation = LegendLocation.Right;
            cartesianChart2.Background = Brushes.White;
        }
        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPageSetupDialog();
            myWebBrowser.ShowPrintDialog();
        }

        private void textSearchDoctor_TextChanged(object sender, EventArgs e)
        {
            var search = textSearchDoctor.Text;
            listBoxSearchDoctor.DataSource = _context.Users
                .Where(t => t.Name.Contains(search) || t.Surname.Contains(search))
                .Select(t => new
                {
                    Id = t.Id,
                    NameSurname = t.Name + " " + t.Surname
                }).ToList();
        }
        private void FillControls()
        {
            FillDateGrid();
            FillHourGrid();
            FillChart1();
            FillChart2();
        }
        public void FillDateGrid()
        {
            var dates = _context.Reservations
                .Where(t => _selectedDoctorId == 0 || t.UserId == _selectedDoctorId)
                .Where(t => !checkBoxDate.Checked ||
                            DbFunctions.TruncateTime(t.StartTime) >= DbFunctions.TruncateTime(dateTimePickerStartDate.Value) && DbFunctions.TruncateTime(t.StartTime) <= DbFunctions.TruncateTime(dateTimePickerEndDate.Value))
                .Select(t => new
                {
                    Date = DbFunctions.TruncateTime(t.StartTime),
                    ReservationId = t.Id
                }).GroupBy(t => t.Date)
                .Select(t => new DateReport()
                {
                    Date = t.Select(r => r.Date).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.ReservationId != 0)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _dateReports = dates;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ngày");
            dataTable.Columns.Add("Tổng lượt");

            foreach (var date in dates)
            {
                DataRow row = dataTable.NewRow();
                row["Ngày"] = date.Date;
                row["Tổng lượt"] = date.TotalReservations;
                dataTable.Rows.Add(row);
            }

            metroGrid.DataSource = dataTable;

        }

        public void FillHourGrid()
        {
            List<HourReport> hourReports = new List<HourReport>();
            for (int i = 0; i < 24; i++)
            {
                var hourStart = (DateTime.Now.Date + new TimeSpan(i, 00, 00)).TimeOfDay;
                var hourEnd = (DateTime.Now.Date + new TimeSpan(i, 59, 00)).TimeOfDay;

                int count = _context.Reservations
                    .Where(t => _selectedDoctorId == 0 || t.UserId == _selectedDoctorId)
                    .Where(t => !checkBoxDate.Checked ||
                                DbFunctions.TruncateTime(t.StartTime) >= DbFunctions.TruncateTime(dateTimePickerStartDate.Value) && DbFunctions.TruncateTime(t.StartTime) <= DbFunctions.TruncateTime(dateTimePickerEndDate.Value))
                    .Count(t => hourStart <= DbFunctions.CreateTime(t.StartTime.Hour, t.StartTime.Minute, t.StartTime.Second) &&
                                hourEnd >= DbFunctions.CreateTime(t.StartTime.Hour, t.StartTime.Minute, t.StartTime.Second));
                hourReports.Add(new HourReport() { Hour = i, TotalReservations = count });
            }

            _hourReports = hourReports;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Giờ");
            dataTable.Columns.Add("Tổng lượt");

            foreach (var hourReport in hourReports)
            {
                DataRow row = dataTable.NewRow();
                row["Giờ"] = hourReport.Hour + ":00 - " + hourReport.Hour + ":59";
                row["Tổng lượt"] = hourReport.TotalReservations;
                dataTable.Rows.Add(row);
            }

            metroGrid1.DataSource = dataTable;
        }


        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePickerStartDate.Enabled = true;
                dateTimePickerEndDate.Enabled = true;
                FillControls();
            }
            else
            {
                dateTimePickerStartDate.Enabled = false;
                dateTimePickerEndDate.Enabled = false;
                FillControls();
            }
        }

        private void btnPrintTable1_Click(object sender, EventArgs e)
        {
            string TenBacSi;
            if (_selectedDoctorId == 0)
                TenBacSi = "Tất cả Bác Sĩ";
            else
                TenBacSi = _selectedDoctor.Name;
            string ngayBatDau = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "từ đầu";
            string ngayKetThuc = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Hiện tại";
            string tieuDe = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>Báo cáo cho {TenBacSi}</h2> <br><br> <h3 style = \'text-align:center;\'>Báo cáo từ {ngayBatDau} đến {ngayKetThuc}</h3><br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Ngày</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Tổng số đặt khám</th> </tr>";

            string noiDung = "";

            foreach (var dateReport in _dateReports)
            {
                string ngay = dateReport.Date.Value.ToShortDateString();
                string tongDatKham = dateReport.TotalReservations.ToString();
                string chuoiDatKham = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{ngay}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{tongDatKham}</td> </tr>";
                noiDung += chuoiDatKham;
            }

            string chanTrang = "</table></body></html>";
            string html = tieuDe + noiDung + chanTrang;
            myWebBrowser.DocumentText = html;
        }

        private void btnPrintTable2_Click(object sender, EventArgs e)
        {
            string TenBacSi;
            if (_selectedDoctorId == 0)
                TenBacSi = "Tất cả Bác Sĩ";
            else
                TenBacSi = _selectedDoctor.Name;
            string ngayBatDau = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "từ đầu";
            string ngayKetThuc = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Hiện tại";
            string tieuDe = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>Báo cáo cho {TenBacSi}</h2> <br><br> <h3 style = \'text-align:center;\'>Báo cáo từ {ngayBatDau} đến {ngayKetThuc}</h3><br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Giờ</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Tổng số đặt khám</th> </tr>";

            string noiDung = "";

            foreach (var hourReport in _hourReports)
            {
                string gio = hourReport.Hour + ":00 - " + hourReport.Hour + ":59";
                string tongDatKham = hourReport.TotalReservations.ToString();
                string chuoiDatKham = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{gio}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{tongDatKham}</td> </tr>";
                noiDung += chuoiDatKham;
            }

            string chanTrang = "</table></body></html>";
            string html = tieuDe + noiDung + chanTrang;
            myWebBrowser.DocumentText = html;
        }

        private void Doc_PrintPage1(object sender, PrintPageEventArgs e)
        {
            string TenBacSi;
            if (_selectedDoctorId == 0)
                TenBacSi = "Tất cả Bác Sĩ";
            else
                TenBacSi = _selectedDoctor.Name;
            string ngayBatDau = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "từ đầu";
            string ngayKetThuc = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Hiện tại";

            Bitmap bmp = new Bitmap(this.cartesianChart1.Width, this.cartesianChart1.Height);
            this.cartesianChart1.DrawToBitmap(bmp, new Rectangle(0, 0, this.cartesianChart1.Width, this.cartesianChart1.Height));
            e.Graphics.DrawString($"Báo cáo từ {TenBacSi}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(300, 100));
            e.Graphics.DrawString($"Báo cáo từ {ngayBatDau} đến {ngayKetThuc}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(250, 200));
            e.Graphics.DrawImage((Image)bmp, 100, 300);
        }

        private void btnPrintChart1_Click_1(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage1;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void btnPrintChart2_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage2;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage2(object sender, PrintPageEventArgs e)
        {
            string TenBacSi;
            if (_selectedDoctorId == 0)
                TenBacSi = "Tất cả Bác Sĩ";
            else
                TenBacSi = _selectedDoctor.Name;
            string ngayBatDau = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "từ đầu";
            string ngayKetThuc = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Hiện tại";

            Bitmap bmp = new Bitmap(this.cartesianChart2.Width, this.cartesianChart2.Height);
            this.cartesianChart2.DrawToBitmap(bmp, new Rectangle(0, 0, this.cartesianChart2.Width, this.cartesianChart2.Height));

            e.Graphics.DrawString($"Báo cáo từ {TenBacSi}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(300, 100));
            e.Graphics.DrawString($"Báo cáo từ {ngayBatDau} đến {ngayKetThuc}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(250, 200));
            e.Graphics.DrawImage((Image)bmp, 100, 300);
        }


        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            FillControls();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            FillControls();
        }

        private void listBoxSearchDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctorId = (int)listBoxSearchDoctor.SelectedValue;
            _selectedDoctorId = doctorId;
            _selectedDoctor = _context.Users.SingleOrDefault(d => d.Id == doctorId);
            FillControls();
        }

    }
    class HourReport
    {
        public int Hour;
        public int TotalReservations;
    }

    class DateReport
    {
        public DateTime? Date;
        public int TotalReservations;
    }
}
