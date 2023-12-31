﻿using QuanLySucKhoe.Models;
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
    public partial class ServicesControl : UserControl
    {
        private EPatientContext _context;
        private Service _currentService = null;
        public ServicesControl()
        {
            InitializeComponent();
        }

        private void ServicesControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            var pavilions = _context.Pavilions.ToList();
            pavilionsBindingSource.DataSource = pavilions;
            servicesBindingSource.DataSource = _context.Services.ToList();

            cboPavilion.DisplayMember = "Name";
            cboPavilion.ValueMember = "Id";

            cboPavilion.DataSource = pavilions;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (_currentService == null)
                    {
                        _currentService = new Service
                        {
                            Name = textName.Text,
                            Price = float.Parse(textPrice.Text),
                            Duration = int.Parse(textDuration.Text),
                            PavilionId = (int)cboPavilion.SelectedValue
                        };
                        servicesBindingSource.Add(_currentService);
                        _context.Services.Add(_currentService);
                    }
                    else
                    {
                        _currentService.Name = textName.Text;
                        _currentService.Price = (float)Convert.ToDouble(textPrice.Text);
                        _currentService.Duration = int.Parse(textDuration.Text);
                        _currentService.PavilionId = (int)cboPavilion.SelectedValue;
                        servicesBindingSource.EndEdit();
                    }

                    _context.SaveChanges();
                    pavilionsBindingSource.ResetBindings(true);
                    _currentService = null;
                    textName.Text = null;
                    textPrice.Text = null;
                    textDuration.Text = null;
                    cboPavilion.SelectedIndex = -1;

                    MetroFramework.MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (servicesBindingSource.Current is Service selectedService)
            {
                _currentService = selectedService;
                textName.Text = _currentService.Name;
                textPrice.Text = _currentService.Price.ToString();
                textDuration.Text = _currentService.Duration.ToString();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn về việc xóa bản ghi này không?", "Tin nhắn",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (servicesBindingSource.Current is Service selectedService)
                    {
                        servicesBindingSource.Remove(selectedService);
                        _context.Services.Remove(selectedService);
                        servicesBindingSource.EndEdit();
                        _context.SaveChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Vui lòng nhập tên dịch vụ (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textPrice_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(textPrice.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                textPrice.Focus();
                errorProvider.SetError(textPrice, "Vui lòng nhập giá tiền");
                return;
            }

            e.Cancel = false;
            errorProvider.SetError(textPrice, null);
        }

        private void textDuration_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToInt32(textDuration.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                textPrice.Focus();
                errorProvider.SetError(textDuration, "Vui lòng nhập thời gian");
                return;
            }

            e.Cancel = false;
            errorProvider.SetError(textDuration, null);
        }

        private void cboPavilion_Validating(object sender, CancelEventArgs e)
        {
            if (cboPavilion.SelectedIndex < 0)
            {
                e.Cancel = true;
                cboPavilion.Focus();
                errorProvider.SetError(cboPavilion, "Vui lòng nhập tên khoa");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cboPavilion, null);
            }
        }

        
    }
}