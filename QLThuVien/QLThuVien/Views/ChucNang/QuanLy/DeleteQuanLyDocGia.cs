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
    public partial class DeleteQuanLyDocGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyDocGia_Load(object sender, EventArgs e)
        {
            string query = "Select * from TheThuVien";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbNhanVienTao.Items.Add(dataTable.Rows[i].Field<string>("ID_The"));
            }
        }

        private void cbNhanVienTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string soThe = cbNhanVienTao.Text;
            string query = "Select TenDocGia , DiaChi , SDT , ttv.NgayHetHan " +
                "From DocGia join TheThuVien ttv on DocGia.SoThe = ttv.ID_The " +
                "where DocGia.SoThe = N'" + soThe + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            tbDiaChi.Text = dataTable.Rows[0].Field<string>("DiaChi");
            tbTenDocGia.Text = dataTable.Rows[0].Field<string>("TenDocGia");
            tbSDT.Text = dataTable.Rows[0].Field<string>("SDT");
            dtpNgayHetHan.Value = (DateTime)dataTable.Rows[0].Field<DateTime>("NgayHetHan");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string soThe = cbNhanVienTao.Text;
            if(string.IsNullOrWhiteSpace(soThe))
            {
                XtraMessageBox.Show("Hãy chọn độc giả muốn xóa !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult log = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                try
                {
                    string queryDeleteTTV = "Delete from TheThuVien where ID_The =N'" + soThe + "'";
                    string queryDeleteDocGia = "Delete from DocGia where SoThe = N'" + soThe + "'";
                    SqlCommand sql1 = new SqlCommand(queryDeleteTTV);
                    SqlCommand sql2 = new SqlCommand(queryDeleteDocGia);
                    
                    db.executeQuery(sql2);
                    db.executeQuery(sql1);
                    XtraMessageBox.Show("Thành công .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLyDocGia.utcQuanLyDocGia.QuanLyDocGiaLoading();
                    this.Hide();
                } catch (Exception err)
                {
                    XtraMessageBox.Show("Độc giả không được phép xóa !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}