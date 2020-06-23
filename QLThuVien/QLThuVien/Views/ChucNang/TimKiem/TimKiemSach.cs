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

namespace QLThuVien.Views.ChucNang.TimKiem
{
    public partial class TimKiemSach : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public static TimKiemSach utcTimKiemSach = new TimKiemSach();
        public TimKiemSach()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            string querySachTrongThuVien = "SELECT MaSach as [Mã sách], TenSach as [Tên sách], tg.TenTacGia as [Tên tác giả], " +
                "tl.TenTheLoai as [Tên thể loại], nxb.TenNXB as [Nhà xuất bản], NamXuatBan as [Năm xuất bản] " +
                "From DauSach JOIN TacGia tg on DauSach.MaTacGia = tg.MaTacGia " +
                "Join TheLoai tl on DauSach.MaTheLoai = tl.MaTheLoai " +
                "join NXB nxb on DauSach.MaNXB = nxb.MaNXB";
            
            db.readDatathroughAdapter(querySachTrongThuVien, data);
            dgvTimKiemSach.DataSource = data;
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) 13)
            {
                DataView dv = data.DefaultView;
                dv.RowFilter = string.Format("[Tên sách] like '%{0}%'", tbTimKiem.Text);
                dgvTimKiemSach.DataSource = dv.ToTable();
            }
        }
    }
}
