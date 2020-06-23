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
    public partial class ThongKeDocGiaDangMuon : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public ThongKeDocGiaDangMuon()
        {
            InitializeComponent();
        }
        public static ThongKeDocGiaDangMuon utcThongKeDocGiaDangMuon = new ThongKeDocGiaDangMuon();
        private void ThongKeDocGiaDangMuon_Load(object sender, EventArgs e)
        {
            CommonDataSet commonDataSet = new CommonDataSet();
            string querySachTrongThuVien = "SELECT dg.SoThe as So_The, dg.TenDocGia as Doc_Gia, ctt.SoCaBiet as So_Ca_Biet ," +
                "ds.TenSach as Ten_Sach ,pm.NgayMuon as Ngay_Muon , ctt.NgayTra as Ngay_Tra " +
                "FROM DocGia dg join TheThuVien ttv on ttv.ID_The = dg.SoThe " +
                "join PhieuMuon pm on pm.SoThe = ttv.ID_The " +
                "join ChungThucTra ctt on ctt.IdPhieuMuon = pm.IdPhieuMuon  " +
                "join Sach s on s.SoCaBiet = ctt.SoCaBiet join DauSach ds on ds.MaSach = s.MaSach";
            string strConnString = @"Data Source=DESKTOP-2NJ6H39\MSSQLSERVER1;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strConnString);
            SqlDataAdapter da = new SqlDataAdapter(querySachTrongThuVien, cn);
            da.Fill(commonDataSet, commonDataSet.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("ThongKeDocGiaDangMuon", commonDataSet.Tables[0]);
            this.rpLapPhieuMuon.LocalReport.DataSources.Clear();
            this.rpLapPhieuMuon.LocalReport.DataSources.Add(rds);
            this.rpLapPhieuMuon.LocalReport.Refresh();
            this.rpLapPhieuMuon.RefreshReport();
        }
    }
}
