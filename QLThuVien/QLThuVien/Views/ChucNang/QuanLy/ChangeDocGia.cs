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
    public partial class ChangeDocGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public ChangeDocGia()
        {
            InitializeComponent();
        }

        private void ChangeDocGia_Load(object sender, EventArgs e)
        {
            dtpNgayHetHan.MinDate = System.DateTime.Now;
            tbTenDocGia.Enabled = false;
            tbDiaChi.Enabled = false;
            tbSDT.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            string query = "Select * from TheThuVien";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            for(int i = 0; i < dataTable.Rows.Count; i ++)
            {
                cbNhanVienTao.Items.Add(dataTable.Rows[i].Field<string>("ID_The"));
            }
        }

        private void cbNhanVienTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenDocGia.Enabled = true;
            tbDiaChi.Enabled = true;
            tbSDT.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            string soThe = cbNhanVienTao.Text;
            string query = "Select TenDocGia , DiaChi , SDT , ttv.NgayHetHan " +
                "From DocGia join TheThuVien ttv on DocGia.SoThe = ttv.ID_The " +
                "where DocGia.SoThe = N'" + soThe + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            tbDiaChi.Text = dataTable.Rows[0].Field<string>("DiaChi");
            tbTenDocGia.Text = dataTable.Rows[0].Field<string>("TenDocGia");
            tbSDT.Text =  dataTable.Rows[0].Field<string>("SDT");
            dtpNgayHetHan.Value = (DateTime)dataTable.Rows[0].Field<DateTime>("NgayHetHan");


        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string soThe = cbNhanVienTao.Text;
            string tenDocGia = tbTenDocGia.Text;
            string diaChi = tbDiaChi.Text;
            string sdt = tbSDT.Text;
            DateTime ngayHetHan = dtpNgayHetHan.Value;
            if(string.IsNullOrWhiteSpace(tenDocGia))
            {
                XtraMessageBox.Show("Hãy chọn độc giả muốn sửa !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult log = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                string queryUpdateTheThuVien = "Update TheThuVien set NgayHetHan = '" + ngayHetHan + "' " +
                    "where ID_The =N'" + soThe + "'";
                SqlCommand sql1 = new SqlCommand(queryUpdateTheThuVien);
                db.executeQuery(sql1);

                string queryUpdateDocGia = "Update DocGia set TenDocGia = N'" + tenDocGia + "', " +
                    "DiaChi = N'" + diaChi + "', SDT = N'" + sdt + "' where SoThe = N'" + soThe + "'";
                SqlCommand sql2 = new SqlCommand(queryUpdateDocGia);
                db.executeQuery(sql2);
                XtraMessageBox.Show("Thành công .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuanLyDocGia.utcQuanLyDocGia.QuanLyDocGiaLoading();
                this.Hide();

            }
        }
    }
}