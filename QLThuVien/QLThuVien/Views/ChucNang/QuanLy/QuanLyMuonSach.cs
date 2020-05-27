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
    public partial class QuanLyMuonSach : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public static string soTheDocGia;
        
        public QuanLyMuonSach()
        {
            InitializeComponent();
        }
        public static QuanLyMuonSach utcQuanLyMuonSach = new QuanLyMuonSach();

        private void QuanLyMuonSach_Load(object sender, EventArgs e)
        {
            QuanLyMuonSach_Loadding();
        }
        
        

        public void QuanLyMuonSach_Loadding()
        {
            DataTable dt = new DataTable();
            DataTable sachTrongThuVien = new DataTable();
            DataTable sachDangChon = new DataTable();
            string query = "Select IdDocGia as ID , DiaChi as [Địa chỉ], SoThe as [Số thẻ], " +
                "TenDocGia as [Tên độc giả], SDT as SĐT from DocGia";
            db.readDatathroughAdapter(query, dt);
            dgvDocGia.DataSource = dt;
            string querySachTrongThuVien = "SELECT MaSach as [Mã sách], TenSach as [Tên sách], tg.TenTacGia as [Tên tác giả], " +
                "tl.TenTheLoai as [Tên thể loại], nxb.TenNXB as [Nhà xuất bản], NamXuatBan as [Năm xuất bản] " +
                "From DauSach JOIN TacGia tg on DauSach.MaTacGia = tg.MaTacGia " +
                "Join TheLoai tl on DauSach.MaTheLoai = tl.MaTheLoai " +
                "join NXB nxb on DauSach.MaNXB = nxb.MaNXB";
            db.readDatathroughAdapter(querySachTrongThuVien, sachTrongThuVien);
            dgvSachTrongThuVien.DataSource = sachTrongThuVien;

            string querySachTrongThuVien2 = "Select ctc.IdPhieuMuon as [ID phiếu mượn], ctc.SoCaBiet as [Số cá biệt], MaSach as [Mã sách] " +
                "FROm ChungThucTra ctc JOin Sach on ctc.SoCaBiet = Sach.SoCaBiet where 1 = 0";
            db.readDatathroughAdapter(querySachTrongThuVien2, sachDangChon);
            dgvSachDangChon.DataSource = sachDangChon;

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
                XtraMessageBox.Show("Không tìm thấy đầu độc giả", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime dateTime = dataTable.Rows[0].Field<DateTime>("NgayHetHan");
            if(DateTime.Compare(dateTime,DateTime.Now) < 0)
            {
                XtraMessageBox.Show("Thẻ thư viện đã hết hạn !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataTable.Reset();
            string query_DocGia = "Select * from DocGia where SoThe ='" + soThe + "'";
            db.readDatathroughAdapter(query_DocGia, dataTable);
            tbTenDocGia.Text = dataTable.Rows[0].Field<string>("TenDocGia");
            tbSDT.Text = dataTable.Rows[0].Field<string>("SDT");
            tbDiaChi.Text = dataTable.Rows[0].Field<string>("DiaChi");

        }

        private void btLapPhieu_Click(object sender, EventArgs e)
        {
            LapPhieuMuon.utcLapPhieuMuon = new LapPhieuMuon();
            //LapPhieuMuon lapPhieuMuon = new LapPhieuMuon();
            string tenDocGia = tbTenDocGia.Text;
            if(tenDocGia == "")
            {
                XtraMessageBox.Show("Yêu cầu nhập số thẻ để lập phiếu mượn !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            soTheDocGia = tbSoThe.Text;
            LapPhieuMuon.utcLapPhieuMuon.Show();
            //lapPhieuMuon.Show();
        }
    }
}
