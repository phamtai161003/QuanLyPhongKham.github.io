using MetroFramework;
using QuanLySucKhoe.Models;
using QuanLySucKhoe.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySucKhoe.Views
{
    public partial class UsersControl : UserControl
    {
        private EPatientContext _context;
        public UsersControl()
        {
            InitializeComponent();
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            usersBindingSource.DataSource = _context.Users.ToList();
            rolesBindingSource.DataSource = _context.Roles.ToList();
            pavilionsBindingSource.DataSource = _context.Pavilions.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddEditUserForm frm = new AddEditUserForm(new User()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        usersBindingSource.Add(frm.UserInfo);
                        _context.Users.Add(frm.UserInfo);
                        _context.SaveChanges();
                        AddOrRemoveTimeTables(frm.UserInfo);
                        MetroMessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User obj = usersBindingSource.Current as User;
            if (obj != null)
            {
                using (AddEditUserForm frm = new AddEditUserForm(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            usersBindingSource.EndEdit();
                            _context.SaveChanges();
                            AddOrRemoveTimeTables(frm.UserInfo);
                            MetroMessageBox.Show(this, "Thành công", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn xóa bản ghi này không?", "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (usersBindingSource.Current is User selectedUser)
                    {
                        usersBindingSource.Remove(selectedUser);
                        _context.Users.Remove(selectedUser);
                        usersBindingSource.EndEdit();
                        _context.SaveChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddOrRemoveTimeTables(User user)
        {
            if ((user.RoleId == Role.Doctor || user.RoleId == Role.Nurse) && user.Timetables == null)
            {
                for (int i = 1; i <= 7; i++)
                {
                    Timetable timetable = new Timetable
                    {
                        DayOfTheWeek = i,
                        DayOff = true,
                        UserId = user.Id
                    };
                    _context.Timetables.Add(timetable);
                    _context.SaveChanges();
                }
            }
            else if (!(user.RoleId == Role.Doctor || user.RoleId == Role.Nurse) && user.Timetables != null)
            {
                _context.Timetables.RemoveRange(user.Timetables);
                _context.SaveChanges();
            }
        }
    }
}
