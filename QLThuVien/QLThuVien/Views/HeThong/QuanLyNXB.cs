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
    public partial class QuanLyNXB : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyNXB()
        {
            InitializeComponent();
        }
        public static QuanLyNXB utcQuanLyNXB = new QuanLyNXB();

        private void QuanLyNXB_Load(object sender, EventArgs e)
        {
            QuanLyNXB_Loading();
        }
        public void QuanLyNXB_Loading()
        {
            DataTable dt = new DataTable();
            string query = "Select MaNXB as [Mã NXB], TenNXB as [Nhà xuất bản] from NXB";
            db.readDatathroughAdapter(query, dt);
            dgvQuanLyNXB.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddItemQuanLyNXB add = new AddItemQuanLyNXB();
            add.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeItemQuanLyNXB add = new ChangeItemQuanLyNXB();
            add.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLyNXB add = new DeleteQuanLyNXB();
            add.Show();
        }
    }
}
