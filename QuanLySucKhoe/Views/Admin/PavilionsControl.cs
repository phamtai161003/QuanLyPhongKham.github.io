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

namespace QuanLySucKhoe.Views.Admin
{
    public partial class PavilionsControl : UserControl
    {
        private EPatientContext _context;
        private Pavilion _currentPavilion = null;

        public PavilionsControl()
        {
            InitializeComponent();
        }

        private void PavilionsControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            pavilionsBindingSource.DataSource = _context.Pavilions.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn về việc xóa bản ghi này không?", "Tin nhắn",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (pavilionsBindingSource.Current is Pavilion selectedPavilion)
                    {
                        pavilionsBindingSource.Remove(selectedPavilion);
                        _context.Pavilions.Remove(selectedPavilion);
                        pavilionsBindingSource.EndEdit();
                        _context.SaveChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (_currentPavilion == null)
                    {
                        _currentPavilion = new Pavilion { Name = textName.Text };
                        pavilionsBindingSource.Add(_currentPavilion);
                        _context.Pavilions.Add(_currentPavilion);
                    }
                    else
                    {
                        _currentPavilion.Name = textName.Text;
                        pavilionsBindingSource.EndEdit();
                    }


                    _context.SaveChanges();
                    pavilionsBindingSource.ResetBindings(true);
                    _currentPavilion = null;
                    textName.Text = "";

                    MetroFramework.MetroMessageBox.Show(this, "Thành công", "Tin nhắn", MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pavilionsBindingSource.Current is Pavilion selectedPavilion)
            {
                _currentPavilion = selectedPavilion;
                textName.Text = _currentPavilion.Name;
            }
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Vui lòng nhập tên khoa bệnh (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }
    }
}
