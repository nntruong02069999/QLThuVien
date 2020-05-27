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
    public partial class TraSach : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public TraSach()
        {
            InitializeComponent();
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            string query = "SELECT pm.IdPhieuMuon as [ID phiếu mượn], ds.MaSach as [Mã sách] ,s.SoCaBiet as [Số cá biệt],ds.TenSach as [Tên sách], pm.NgayMuon as [Ngày mượn] , ctt.DaTra " +
                "FROM PhieuMuon pm join ChungThucTra ctt on pm.IdPhieuMuon = ctt.IdPhieuMuon " +
                "join Sach s on ctt.SoCaBiet = s.SoCaBiet join DauSach ds on s.MaSach = ds.MaSach " +
                "where ctt.IdPhieuMuon in " +
                "(Select IdPhieuMuon from PhieuMuon WHERE SoThe = N'" + QuanLyTraSach.utcQuanLyTraSach.tbSoThe.Text + "') " +
                "and ctt.DaTra = 0";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbSachDaMuon.Items.Add(dataTable.Rows[i].Field<int>("Số cá biệt"));
            }
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            DateTime ngayTra = System.DateTime.Now;
            int soCaBiet = Convert.ToInt32(cbSachDaMuon.Text);
            if(soCaBiet == 0)
            {
                XtraMessageBox.Show("Chọn sách muốn trả !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult log = XtraMessageBox.Show("Đã chắc chắn chưa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(log == DialogResult.Yes)
            {
                string query = "Update ChungThucTra set DaTra = 1 where SoCaBiet = " + soCaBiet;
                string query2 = "Update Sach set TrangThai = 1 where SoCaBiet = " + soCaBiet;
                string query3 = "Update ChungThucTra set NgayTra = '" + ngayTra + "' where SoCaBiet = " + soCaBiet;
                SqlCommand command1 = new SqlCommand(query);
                SqlCommand command2 = new SqlCommand(query2);
                SqlCommand command3 = new SqlCommand(query3);
                db.executeQuery(command1);
                db.executeQuery(command2);
                db.executeQuery(command3);
                cbSachDaMuon.Items.Remove(cbSachDaMuon.SelectedItem);
                QuanLyTraSach.utcQuanLyTraSach.RefreshSachDaMuon();
            }
            
        }
    }
}