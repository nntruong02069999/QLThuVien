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
            
        }
    }
}
