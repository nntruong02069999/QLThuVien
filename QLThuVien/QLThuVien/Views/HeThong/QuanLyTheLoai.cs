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
    public partial class QuanLyTheLoai : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyTheLoai()
        {
            InitializeComponent();
        }
        public static QuanLyTheLoai utcQuanLyTheLoai = new QuanLyTheLoai();

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            QuanLyTheLoai_Loading();
        }
        public void QuanLyTheLoai_Loading()
        {
            DataTable dt = new DataTable();
            string query = "Select MaTheLoai as [Thể loại], TenTheLoai as [Tên thể loại] from TheLoai";
            db.readDatathroughAdapter(query, dt);
            dgvQuanLyTheLoai.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddItemQuanLyTheLoai addItem = new AddItemQuanLyTheLoai();
            addItem.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeQuanLyTheLoai addItem = new ChangeQuanLyTheLoai();
            addItem.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLyTheLoai addItem = new DeleteQuanLyTheLoai();
            addItem.Show();
        }
    }
}
