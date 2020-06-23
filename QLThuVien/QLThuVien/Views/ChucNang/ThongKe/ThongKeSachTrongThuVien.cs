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
using Microsoft.Reporting.WinForms;

namespace QLThuVien.Views.ChucNang.ThongKe
{
    public partial class ThongKeSachTrongThuVien : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public static ThongKeSachTrongThuVien utcThongKeSachTrongThuVien = new ThongKeSachTrongThuVien();
        public ThongKeSachTrongThuVien()
        {
            InitializeComponent();
        }

        private void ThongKeSachTrongThuVien_Load(object sender, EventArgs e)
        {
            CommonDataSet commonDataSet = new CommonDataSet();
            string querySachTrongThuVien = "SELECT MaSach as Ma_Sach, TenSach as Ten_Sach, tg.TenTacGia as Tac_Gia, " +
                "tl.TenTheLoai as The_Loai, nxb.TenNXB as Nha_San_Xuat, NamXuatBan as Nam_Xuat_Ban " +
                "From DauSach JOIN TacGia tg on DauSach.MaTacGia = tg.MaTacGia " +
                "Join TheLoai tl on DauSach.MaTheLoai = tl.MaTheLoai " +
                "join NXB nxb on DauSach.MaNXB = nxb.MaNXB";
            string strConnString = @"Data Source=DESKTOP-2NJ6H39\MSSQLSERVER1;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strConnString);
            SqlDataAdapter da = new SqlDataAdapter(querySachTrongThuVien, cn);
            da.Fill(commonDataSet, commonDataSet.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("ThongKeSachTrongThuVien", commonDataSet.Tables[0]);
            this.rpLapPhieuMuon.LocalReport.DataSources.Clear();
            this.rpLapPhieuMuon.LocalReport.DataSources.Add(rds);
            this.rpLapPhieuMuon.LocalReport.Refresh();
            this.rpLapPhieuMuon.RefreshReport();
        }
    }
}
