using MetroFramework;
using QuanLySucKhoe.Models;
using QuanLySucKhoe.Models.Auth;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Staff
{
    public partial class ReservationControl : UserControl
    {
        private EPatientContext _context;

        public ReservationControl()
        {
            InitializeComponent();
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            gridViewReservation.DataSource = FillTable(null, DateTime.Now);
            StyleGrid();
        }

        private void StyleGrid()
        {
            gridViewReservation.Columns[0].Width = 300;
            gridViewReservation.Columns[1].Width = 500;
            gridViewReservation.Columns[2].Width = 500;
            gridViewReservation.Columns[3].Width = 500;
            gridViewReservation.Columns[4].Width = 300;
        }

        private DataTable FillTable(string search = null, DateTime? date = null)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Bệnh nhân");
            dataTable.Columns.Add("Dịch vụ");
            dataTable.Columns.Add("Ngày");
            dataTable.Columns.Add("Đã thực hiện");

            var query = from r in _context.Reservations
                        join p in _context.Patients on r.PatientId equals p.Id
                        join s in _context.Services on r.ServiceId equals s.Id
                        where r.UserId == AuthUser.Model.Id
                        orderby r.StartTime descending
                        select new { p, s, r };

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
                Done = t.r.Done
            });

            foreach (var reservation in reservations)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = reservation.Id;
                row["Bệnh nhân"] = reservation.PatientName + " " + reservation.PatientSurname;
                row["Dịch vụ"] = reservation.ServiceName;
                row["Ngày"] = reservation.StartTime;
                row["Đã thực hiện"] = reservation.Done ? "Có" : "Không";
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePicker.Enabled = true;
            }
            else
            {
                dateTimePicker.Enabled = false;
                gridViewReservation.DataSource = FillTable();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            gridViewReservation.DataSource = FillTable(textSearch.Text, dateTimePicker.Value);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Enabled)
            {
                gridViewReservation.DataSource = FillTable(textSearch.Text, dateTimePicker.Value);
            }
            else
            {
                gridViewReservation.DataSource = FillTable(textSearch.Text);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (gridViewReservation.RowCount == 0)
            {
                MetroMessageBox.Show(this, "Không có bản ghi nào để xem.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = int.Parse(gridViewReservation.SelectedRows[0].Cells[0].Value.ToString());
                if (id != 0)
                {
                    var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
                    if (reservation == null)
                        return;

                    using (FolderForm frm = new FolderForm(reservation.PatientId))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                gridViewReservation.DataSource = FillTable(null, DateTime.Now);
                                MetroMessageBox.Show(this, "Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            gridViewReservation.DataSource = FillTable(null, null);
                        }
                    }
                }
            }
        }
    }
}
