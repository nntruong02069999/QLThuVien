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

namespace QLThuVien.Views.HeThong
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        public static QuanLyNhanVien utcQuanLyNhanVien = new QuanLyNhanVien();
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            QuanLyNhanVien_Loading();
        }
        public void QuanLyNhanVien_Loading()
        {
            DataTable dt = new DataTable();
            string query = "Select IDNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên nhân viên] from NhanVien";
            db.readDatathroughAdapter(query, dt);
            dgvQuanLyTacGia.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddItemQuanLyNhanVien add = new AddItemQuanLyNhanVien();
            add.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeItemQuanLyNhanVien add = new ChangeItemQuanLyNhanVien();
            add.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLyNhanVien add = new DeleteQuanLyNhanVien();
            add.Show();
        }
    }
}
