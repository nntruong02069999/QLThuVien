using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace QLThuVien.Views
{
    public partial class ucChangePass : DevExpress.XtraEditors.XtraUserControl
    {
        public ucChangePass()
        {
            InitializeComponent();
        }
        Database db = new Database();
        frmLogin Login = new frmLogin();
        public static ucChangePass utcChangePass = new ucChangePass();

        private void btOk_Click(object sender, EventArgs e)
        {
            string password = tbOldPass.Text;
            string newPassword = tbNewPass.Text;
            string cfPassword = tbConfirmPass.Text;
            SqlCommand command = new SqlCommand();
            if (newPassword == "" || password == "" || cfPassword == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "select * from [User] where password = '" + password + "' and username = '" + frmLogin.gUserName + "'";
            string result = (string)db.executeSelectQuery(command);
            if (result == "")
            {
                XtraMessageBox.Show("Mật khẩu hiện tại không đúng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != cfPassword)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "update [User] set password = '" + newPassword + "' where password = '" + password + "'";
            int rs = db.executeQuery(command);
            if (rs != 0)
            {
                DialogResult log = XtraMessageBox.Show("Đổi mật khẩu tài khoản thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (log == DialogResult.OK)
                {
                    Hide();
                }
            }
        }
    }
}
