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
using Microsoft.Reporting.WinForms;
using QLThuVien.Models;
using System.Data.SqlClient;

namespace QLThuVien.Views.ChucNang.QuanLy
{
    public partial class frmLapPhieu : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("tbHoTen", QuanLyMuonSach.utcQuanLyMuonSach.tbTenDocGia.Text));
            reportParameters.Add(new ReportParameter("tbSoThe", LapPhieuMuon.utcLapPhieuMuon.tbSoThe.Text));
            this.rpLapPhieuMuon.LocalReport.SetParameters(reportParameters);

            CommonDataSet commonDataSet = new CommonDataSet();
            string query = "Select ds.MaSach as Ma_Sach, ds.TenSach as Ten_Sach, " +
                "pm.NgayMuon as Ngay_Muon from DauSach ds join Sach s on ds.MaSach = s.MaSach " +
                "join ChungThucTra ctt on ctt.SoCaBiet = s.SoCaBiet " +
                "join PhieuMuon pm on pm.IdPhieuMuon = ctt.IdPhieuMuon " +
                "where pm.IdPhieuMuon  = N'" + LapPhieuMuon.utcLapPhieuMuon.tbIdPhieuMuon.Text + "'";
            string strConnString = @"Data Source=DESKTOP-2NJ6H39\MSSQLSERVER1;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strConnString);
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(commonDataSet, commonDataSet.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("XuatBaoCao", commonDataSet.Tables[0]);
            this.rpLapPhieuMuon.LocalReport.DataSources.Clear();
            this.rpLapPhieuMuon.LocalReport.DataSources.Add(rds);
            this.rpLapPhieuMuon.LocalReport.Refresh();


            this.rpLapPhieuMuon.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}