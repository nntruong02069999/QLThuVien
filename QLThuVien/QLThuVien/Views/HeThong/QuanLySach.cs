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
    public partial class QuanLySach : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLySach()
        {
            InitializeComponent();
        }
        Database db = new Database();
        public static QuanLySach utcQuanLySach = new QuanLySach();

        private void btThem_Click(object sender, EventArgs e)
        {
            NewIteamQuanLySach addItem = new NewIteamQuanLySach();
            addItem.Show();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            QuanLySach_Loading();
        }
        public void QuanLySach_Loading ()
        {
            DataTable dt = new DataTable();
            string query = "Select MaSach as [Mã sách], TenSach as [Tên sách], NamXuatBan as [Năm xuất bản], " +
                "MaTacGia as [Mã tác giả], MaTheLoai as [Mã thể loại], MaNXB as [Mã NXB] from DauSach";
            db.readDatathroughAdapter(query, dt);
            dgvQuanLySach.DataSource = dt;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeItemQuanLySach addItem = new ChangeItemQuanLySach();
            addItem.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLySach addItem = new DeleteQuanLySach();
            addItem.Show();
        }
    }
}
