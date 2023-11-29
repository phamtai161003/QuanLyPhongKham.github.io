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

namespace QuanLySucKhoe.Views.Operator
{
    public partial class AddEditPatientForm : Form
    {
        public AddEditPatientForm(Patient obj)
        {
            InitializeComponent();
            patientBindingSource.DataSource = obj;
        }

        public Patient PatientInfo => patientBindingSource.Current as Patient;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                patientBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddEditPatientForm_Load(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Male";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Female";
            else
                checkBoxGender.Text = "??";
        }

        private void checkBoxGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Nam";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Nữ";
            else
                checkBoxGender.Text = "??";
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Vui lòng chọn tên bệnh nhân (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textSurname.Text) || textSurname.Text.Length > 255)
            {
                e.Cancel = true;
                textSurname.Focus();
                errorProvider.SetError(textSurname, "Vui lòng chọn họ bệnh nhân (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textSurname, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text) || textEmail.Text.Length > 50)
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider.SetError(textEmail, "Vui lòng chọn email bệnh nhân (Tối đa 50 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textEmail, null);
            }
        }

        private void dateBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateBirthday.Text))
            {
                e.Cancel = true;
                dateBirthday.Focus();
                errorProvider.SetError(dateBirthday, "Chọn ngày sinh");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dateBirthday, null);
            }
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textPhone.Text) || textPhone.Text.Length > 255)
            {
                e.Cancel = true;
                textPhone.Focus();
                errorProvider.SetError(textPhone, "Vui lòng chọn sđt bệnh nhân (Tối đa 255 ký tự)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textPhone, null);
            }
        }
    }
}
