using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;

namespace QLThuVien.Views.ChucNang.QuanLy
{
    public partial class AddDocGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public AddDocGia()
        {
            InitializeComponent();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            string soThe = tbSoThe.Text;
            string tenDocGia = tbTenDocGia.Text;
            string diaChi = tbSDT.Text;
            string sdt = tbSDT.Text;
            string nhanVienTao = cbNhanVienTao.Text;
            DateTime ngayTao = dtpNgayTao.Value;
            DateTime ngayHetHan = dtpNgayHetHan.Value;
            if(string.IsNullOrWhiteSpace(soThe) || string.IsNullOrWhiteSpace(tenDocGia) 
                || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(nhanVienTao) )
            {
                XtraMessageBox.Show("Không được phép để trống thông tin độc giả !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(DateTime.Compare(ngayTao,ngayHetHan) >= 1)
            {
                XtraMessageBox.Show("Ngày hết hạn không thể có giá trị thấp hơn ngày khởi tạo !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string queryCheck = "Select * from TheThuVien where ID_The = N'" + soThe + "'";
            DataTable data = new DataTable();
            db.readDatathroughAdapter(queryCheck, data);
            if(data.Rows.Count > 0)
            {
                XtraMessageBox.Show("Số thẻ đã tồn tại !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string getIDNhanVien = "Select * from NhanVien where TenNhanVien = N'" + cbNhanVienTao.Text + "'";
            DataTable dt1 = new DataTable();
            db.readDatathroughAdapter(getIDNhanVien, dt1);
            string IdNhanVien = dt1.Rows[0].Field<string>("IDNhanVien");
            //Insert TheThuVien
            string queryInsertTheThuVien = "Insert into TheThuVien values (N'" + soThe + "', " +
                "'" + ngayTao + "', '" + ngayHetHan + "', N'" + IdNhanVien + "' )";
            SqlCommand sql1 = new SqlCommand(queryInsertTheThuVien);
            db.executeQuery(sql1);
            // Insert Độc giả
            string queryInsertDocGia = "Insert into DocGia (DiaChi,TenDocGia,SDT,SoThe) " +
                "values (N'" + diaChi + "', N'" + tenDocGia + "', N'" + sdt + "', N'" + soThe + "')";
            SqlCommand sql2 = new SqlCommand(queryInsertDocGia);
            db.executeQuery(sql2);

            XtraMessageBox.Show("Thành công . ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            QuanLyDocGia.utcQuanLyDocGia.QuanLyDocGiaLoading();
            this.Hide();
        }

        private void AddDocGia_Load(object sender, EventArgs e)
        {
            LoadingDocGia();
        }
        public void LoadingDocGia()
        {
            string queryNhanVien = "Select TenNhanVien From NhanVien";
            DataTable nhanVien = new DataTable();
            db.readDatathroughAdapter(queryNhanVien, nhanVien);
            foreach (DataRow row in nhanVien.Rows)
            {
                cbNhanVienTao.Items.Add(row[0]);
            }
        }
    }
}