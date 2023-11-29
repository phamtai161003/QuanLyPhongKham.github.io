using QuanLySucKhoe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views.Staff
{
    public partial class ReservationDiagnose : Form
    {
        public EPatientContext _context;
        public Reservation CurrentReservation;

        private struct FileUploaded
        {
            public static byte[] FileBytes;
            public static string FileName;
        }
        public ReservationDiagnose(int reservation_id)
        {
            _context = new EPatientContext();
            CurrentReservation = _context.Reservations.Include("Patient").FirstOrDefault(r => r.Id == reservation_id);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentReservation.Recipe = textRecipe.Text;
            if (FileUploaded.FileBytes != null)
            {
                CurrentReservation.File = FileUploaded.FileBytes;
                CurrentReservation.FileName = FileUploaded.FileName;
            }
            _context.SaveChanges();
            FileUploaded.FileBytes = null;
            FileUploaded.FileName = null;
            DialogResult = DialogResult.OK;

        }

        private void ReservationDiagnose_Load(object sender, EventArgs e)
        {
            textBoxAllergies.Text = CurrentReservation.Patient.Allergies;
            textRecipe.Text = CurrentReservation.Recipe;
            if (CurrentReservation.File == null)
            {
                btnDownload.Visible = false;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            var extension = Path.GetExtension(CurrentReservation.FileName);
            var filterExtension = "(*" + extension + ")|*" + extension;
            using (SaveFileDialog sfd = new SaveFileDialog() { FileName = CurrentReservation.FileName, DefaultExt = extension, Filter = filterExtension })
            {
                byte[] file = (byte[])CurrentReservation.File;

                if (sfd.ShowDialog() != DialogResult.Cancel)
                {
                    string strFileToSave = sfd.FileName;
                    FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                    objFileStream.Write(file, 0, file.Length);
                    objFileStream.Close();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var filePath = ofd.FileName;
                    FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    int intLength = Convert.ToInt32(stream.Length);
                    byte[] file = new byte[intLength];
                    stream.Read(file, 0, intLength);
                    stream.Close();
                    FileUploaded.FileBytes = file;
                    string[] strPath = filePath.Split(Convert.ToChar(@"\"));
                    FileUploaded.FileName = strPath[strPath.Length - 1];
                    btnUpload.Enabled = false;
                }
            }
        }
    }
}
