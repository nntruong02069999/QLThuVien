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
            
        }
    }
}
