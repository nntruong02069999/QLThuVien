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
    public partial class QuanLyTacGia : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyTacGia()
        {
            InitializeComponent();
        }
        public static QuanLyTacGia utcQuanLyTacGia = new QuanLyTacGia();
        public void QuanLyTacGia_Loadding()
        {
            DataTable dt = new DataTable();
            string query = "Select MaTacGia as [Mã tác giả], TenTacGia as [Tên tác giả] from TacGia";
            db.readDatathroughAdapter(query, dt);
            dgvQuanLyTacGia.DataSource = dt;
        }

        private void QuanLyTacGia_Load(object sender, EventArgs e)
        {
            QuanLyTacGia_Loadding();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddItemQuanLyTacGia add = new AddItemQuanLyTacGia();
            add.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeItemQuanLyTacGia add = new ChangeItemQuanLyTacGia();
            add.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLyTacGia add = new DeleteQuanLyTacGia();
            add.Show();
        }
    }
}
