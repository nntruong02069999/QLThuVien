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
    public partial class QuanLyTraSach : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyTraSach()
        {
            InitializeComponent();
        }
        public static QuanLyTraSach utcQuanLyTraSach = new QuanLyTraSach();
        private void QuanLyTraSach_Load(object sender, EventArgs e)
        {
            QuanLyMuonSachLoading();
        }
        public void QuanLyMuonSachLoading()
        {
            DataTable dt = new DataTable();
            string query = "Select IdDocGia as ID , DiaChi as [Địa chỉ], SoThe as [Số thẻ], " +
                "TenDocGia as [Tên độc giả], SDT as SĐT from DocGia";
            db.readDatathroughAdapter(query, dt);
            dgvDocGia.DataSource = dt;
        }

        public void RefreshSachDaMuon()
        {
            string querySachDangMuon = "SELECT pm.IdPhieuMuon as [ID phiếu mượn], ds.MaSach as [Mã sách] ,s.SoCaBiet as [Số cá biệt],ds.TenSach as [Tên sách], pm.NgayMuon as [Ngày mượn] , ctt.DaTra " +
                "FROM PhieuMuon pm join ChungThucTra ctt on pm.IdPhieuMuon = ctt.IdPhieuMuon " +
                "join Sach s on ctt.SoCaBiet = s.SoCaBiet join DauSach ds on s.MaSach = ds.MaSach " +
                "where ctt.IdPhieuMuon in " +
                "(Select IdPhieuMuon from PhieuMuon WHERE SoThe = N'" + tbSoThe.Text + "') " +
                "and ctt.DaTra = 0";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(querySachDangMuon, dataTable);
            dgvSachDaMuon.DataSource = dataTable;
        }
        public void SachDangMuonLoading()
        {
            string query = "Select * from PhieuMuon where SoThe = N'" + tbSoThe.Text + "'";
            DataTable data = new DataTable();
            db.readDatathroughAdapter(query, data);
            if (data.Rows.Count == 0)
            {
                XtraMessageBox.Show("Độc giả này đang không mượn sách !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string querySachDangMuon = "SELECT pm.IdPhieuMuon as [ID phiếu mượn], ds.MaSach as [Mã sách] ,s.SoCaBiet as [Số cá biệt],ds.TenSach as [Tên sách], pm.NgayMuon as [Ngày mượn] , ctt.DaTra " +
                "FROM PhieuMuon pm join ChungThucTra ctt on pm.IdPhieuMuon = ctt.IdPhieuMuon " +
                "join Sach s on ctt.SoCaBiet = s.SoCaBiet join DauSach ds on s.MaSach = ds.MaSach " +
                "where ctt.IdPhieuMuon in " +
                "(Select IdPhieuMuon from PhieuMuon WHERE SoThe = N'" + tbSoThe.Text + "') " +
                "and ctt.DaTra = 0";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(querySachDangMuon, dataTable);
            dgvSachDaMuon.DataSource = dataTable;
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string soThe = tbSoThe.Text;
            DataTable dataTable = new DataTable();
            if (string.IsNullOrWhiteSpace(soThe))
            {
                XtraMessageBox.Show("Không được phép để trống số thẻ !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "Select * from TheThuVien where ID_The = '" + soThe + "'";
            db.readDatathroughAdapter(query, dataTable);
            if (dataTable.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không tìm thấy độc giả", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /*DateTime dateTime = dataTable.Rows[0].Field<DateTime>("NgayHetHan");
            if (DateTime.Compare(dateTime, DateTime.Now) < 0)
            {
                XtraMessageBox.Show("Thẻ thư viện đã hết hạn !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            SachDangMuonLoading();

            dataTable.Reset();
            string query_DocGia = "Select * from DocGia where SoThe ='" + soThe + "'";
            db.readDatathroughAdapter(query_DocGia, dataTable);
            tbTenDocGia.Text = dataTable.Rows[0].Field<string>("TenDocGia");
            tbSDT.Text = dataTable.Rows[0].Field<string>("SDT");
            tbDiaChi.Text = dataTable.Rows[0].Field<string>("DiaChi");
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            string tenDocGia = tbTenDocGia.Text;
            if(string.IsNullOrEmpty(tenDocGia) == true)
            {
                XtraMessageBox.Show("Yêu cầu nhập số thẻ để tìm kiếm !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TraSach traSach = new TraSach();
            traSach.Show();
        }
    }
}
