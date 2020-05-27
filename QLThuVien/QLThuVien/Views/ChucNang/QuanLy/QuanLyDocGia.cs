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

namespace QLThuVien.Views.ChucNang.QuanLy
{
    public partial class QuanLyDocGia : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyDocGia()
        {
            InitializeComponent();
        }

        public static QuanLyDocGia utcQuanLyDocGia = new QuanLyDocGia();
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            QuanLyDocGiaLoading();
        }
        public void QuanLyDocGiaLoading()
        {
            string query = "Select IdDocGia as [ID độc giả], SoThe as [Số thẻ], TenDocGia as [Tên độc giả], DiaChi as [Địa chỉ], SDT as [SĐT] from DocGia";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            dgvDocGia.DataSource = dataTable;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddDocGia add = new AddDocGia();
            add.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChangeDocGia changeDocGia = new ChangeDocGia();
            changeDocGia.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DeleteQuanLyDocGia deleteQuanLyDocGia = new DeleteQuanLyDocGia();
            deleteQuanLyDocGia.Show();
        }
    }
}
