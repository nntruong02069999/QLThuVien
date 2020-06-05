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
    public partial class ThongKeSachDangMuon : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public ThongKeSachDangMuon()
        {
            InitializeComponent();
        }
        public static ThongKeSachDangMuon utcThongKeSachDangMuon = new ThongKeSachDangMuon();
        private void ThongKeSachDangMuon_Load(object sender, EventArgs e)
        {
            CommonDataSet commonDataSet = new CommonDataSet();
            string querySachTrongThuVien = "SELECT pm.SoThe as So_The, ds.MaSach as Ma_Sach , ctt.SoCaBiet as So_Ca_Biet," +
                "ds.TenSach as Ten_Sach , pm.NgayMuon as Ngay_Muon, ctt.DaTra as Da_Tra " +
                "From DauSach ds join Sach s on ds.MaSach = s.MaSach " +
                "join ChungThucTra ctt on ctt.SoCaBiet = s.SoCaBiet " +
                "join PhieuMuon pm  on pm.IdPhieuMuon = ctt.IdPhieuMuon " +
                "where ctt.DaTra = 0 ORDER BY So_The";
            string strConnString = @"Data Source=DESKTOP-2NJ6H39\MSSQLSERVER1;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strConnString);
            SqlDataAdapter da = new SqlDataAdapter(querySachTrongThuVien, cn);
            da.Fill(commonDataSet, commonDataSet.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("ThongKeSachDangMuon", commonDataSet.Tables[0]);
            this.rpLapPhieuMuon.LocalReport.DataSources.Clear();
            this.rpLapPhieuMuon.LocalReport.DataSources.Add(rds);
            this.rpLapPhieuMuon.LocalReport.Refresh();
            this.rpLapPhieuMuon.RefreshReport();
        }
    }
}
