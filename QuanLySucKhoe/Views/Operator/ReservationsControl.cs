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
    public partial class ReservationsControl : UserControl
    {
        private EPatientContext _context;
        public ReservationsControl()
        {
            InitializeComponent();
            _context = new EPatientContext();
        }

        private void ReservationsControl_Load(object sender, EventArgs e)
        {
            gridView.DataSource = FillTable();
            gridView.Columns[0].Width = 100;
            gridView.Columns[1].Width = 250;
            gridView.Columns[2].Width = 250;
            gridView.Columns[3].Width = 300;
            gridView.Columns[4].Width = 300;
            gridView.Columns[5].Width = 250;
            gridView.Columns[6].Width = 250;
            gridView.Columns[7].Width = 200;
        }
        private DataTable FillTable(string search = null, DateTime? date = null)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Bệnh nhân");
            dataTable.Columns.Add("Dịch vụ");
            dataTable.Columns.Add("Ngày");
            dataTable.Columns.Add("Bác sĩ/Điều dưỡng");
            dataTable.Columns.Add("Đã thanh toán");
            dataTable.Columns.Add("Đã hoàn thành");
            dataTable.Columns.Add("Giá");

            try
            {
                var query = from r in _context.Reservations
                            join u in _context.Users on r.UserId equals u.Id
                            join p in _context.Patients on r.PatientId equals p.Id
                            join s in _context.Services on r.ServiceId equals s.Id
                            orderby r.StartTime descending
                            select new { u, p, s, r };

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(t => t.p.Name.Contains(search) ||
                                              t.p.Surname.Contains(search) ||
                                              t.p.Email.Contains(search));
                }

                if (date != null)
                {
                    query = query.Where(t => DbFunctions.TruncateTime(t.r.StartTime) == DbFunctions.TruncateTime(date));
                }

                var reservations = query.Select(t => new
                {
                    Id = t.r.Id,
                    PatientName = t.p.Name,
                    PatientSurname = t.p.Surname,
                    ServiceName = t.s.Name,
                    StartTime = t.r.StartTime,
                    UserName = t.u.Name,
                    UserSurname = t.u.Surname,
                    Paid = t.r.Paid,
                    Done = t.r.Done,
                    Price = t.s.Price
                }).ToList(); // Chuyển đổi thành danh sách để đảm bảo dữ liệu không rỗng.

                foreach (var reservation in reservations)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = reservation.Id;
                    row["Bệnh nhân"] = $"{reservation.PatientName} {reservation.PatientSurname}";
                    row["Dịch vụ"] = reservation.ServiceName;
                    row["Ngày"] = reservation.StartTime;
                    row["Bác sĩ/Điều dưỡng"] = $"{reservation.UserName} {reservation.UserSurname}";
                    row["Đã thanh toán"] = reservation.Paid ? "Có" : "Không";
                    row["Đã hoàn thành"] = reservation.Done ? "Có" : "Không";
                    row["Giá"] = $"{reservation.Price} VNĐ";
                    dataTable.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Bạn có chắc chắn về việc xóa bản ghi này không?", "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                    if (id != 0)
                    {
                        var reservation = _context.Reservations.SingleOrDefault(r => r.Id == id);
                        _context.Reservations.Remove(reservation);
                        _context.SaveChanges();
                        gridView.DataSource = FillTable();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dateTimePicker1.Enabled = true;
            else
            {
                dateTimePicker1.Enabled = false;
                gridView.DataSource = FillTable();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gridView.DataSource = FillTable(searchTextBox.Text, dateTimePicker1.Value);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled)
                gridView.DataSource = FillTable(searchTextBox.Text, dateTimePicker1.Value);
            else
                gridView.DataSource = FillTable(searchTextBox.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddReservationForm frm = new AddReservationForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MetroMessageBox.Show(this, "Thành công", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                        gridView.DataSource = FillTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            using (AddQuickReservation frm = new AddQuickReservation())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MetroMessageBox.Show(this, "thành công", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                        gridView.DataSource = FillTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "đã hết chỗ!", "thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                if (id != 0)
                {
                    var reservation = _context.Reservations.SingleOrDefault(r => r.Id == id);
                    if (reservation.Paid)
                    {
                        MetroMessageBox.Show(this, "Đặt phòng vừa được thanh toán", "cảnh báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (MetroMessageBox.Show(this, "Bạn muốn in hóa đơn?", "thanh toán", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        reservation.Paid = true;
                        _context.SaveChanges();
                        gridView.DataSource = FillTable();
                        PrintReservation();
                        MetroMessageBox.Show(this, "Thanh toán thành công!", "thành công", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "Không có thông tin", "thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            PrintReservation();
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
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "Không có thông tin", "Thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                var reservation = _context.Reservations.Include("Service").Include("User").Include("Patient").SingleOrDefault(r => r.Id == id);
                e.Graphics.DrawString("EPatient - Đặt chỗ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 100));
                e.Graphics.DrawString("Bệnh nhân: " + reservation.Patient.Name + " " + reservation.Patient.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 150));
                e.Graphics.DrawString("Ngày: " + reservation.StartTime.Date.ToShortDateString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 150));
                e.Graphics.DrawString("Bác sĩ: " + reservation.User.Name + " " + reservation.User.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 200));
                e.Graphics.DrawString("Giờ: " + reservation.StartTime.ToString("H:mm"), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 200));
                e.Graphics.DrawString("Dịch vụ: " + reservation.Service.Name, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 250));
                e.Graphics.DrawString("Giá: " + reservation.Service.Price + " nghìn đồng", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 250));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(50, 80, 730, 250));
            }
        }



    }
}
